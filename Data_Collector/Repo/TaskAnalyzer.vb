Module TaskAnalyzer

    Public Function Analyze(taskOutput As String) As List(Of String)

        Dim alerts As New List(Of String)

        ' ================= CONFIG =================
        Dim suspiciousExec As String() = {
            "powershell", "cmd.exe", "wscript", "cscript",
            "mshta", "rundll32"
        }

        Dim suspiciousPaths As String() = {
            "\appdata\", "\temp\", "\downloads\",
            "\programdata\", "\users\public\"
        }

        Dim lines = taskOutput.Split(Environment.NewLine)

        Dim currentTask As String = ""
        Dim currentRun As String = ""
        Dim currentUser As String = ""

        ' ================= PARSE =================
        For Each line In lines

            Dim lowerLine = line.ToLower()

            ' Task Name
            If lowerLine.StartsWith("taskname:") Then
                currentTask = line
            End If

            ' ================= RUN COMMAND =================
            If lowerLine.StartsWith("task to run:") Then
                currentRun = line

                ' 🔴 Suspicious executables
                For Each exe In suspiciousExec
                    If lowerLine.Contains(exe) Then
                        alerts.Add("[HIGH] Suspicious Execution: " & currentTask & " → " & line)
                    End If
                Next

                ' 🔴 Suspicious paths
                For Each path In suspiciousPaths
                    If lowerLine.Contains(path) Then
                        alerts.Add("[HIGH] Suspicious Path: " & currentTask & " → " & line)
                    End If
                Next

                ' 🔥 Encoded / Obfuscated commands
                If lowerLine.Contains("-enc") Or lowerLine.Contains("base64") Then
                    alerts.Add("[HIGH] Encoded Command Detected: " & currentTask & " → " & line)
                End If

            End If

            ' ================= USER CONTEXT =================
            If lowerLine.StartsWith("run as user:") Then
                currentUser = line

                If lowerLine.Contains("system") Then
                    alerts.Add("[HIGH] Running as SYSTEM: " & currentTask)
                End If
            End If

            ' ================= TRIGGER =================
            If lowerLine.StartsWith("schedule type:") Then

                If lowerLine.Contains("minute") Then
                    alerts.Add("[MEDIUM] Frequent Task (every minute): " & currentTask)
                End If

                If lowerLine.Contains("logon") Then
                    alerts.Add("[MEDIUM] Runs at Logon: " & currentTask)
                End If

            End If

            ' ================= HIDDEN =================
            If lowerLine.StartsWith("hidden:") Then
                If lowerLine.Contains("yes") Then
                    alerts.Add("[HIGH] Hidden Task: " & currentTask)
                End If
            End If

        Next

        Return alerts

    End Function

End Module