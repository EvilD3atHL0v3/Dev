Module ProcessAnalyzer

    Public Function Analyze(tasklistOutput As String) As List(Of String)

        Dim alerts As New List(Of String)

        ' ================= CONFIG =================
        Dim suspiciousProcesses As String() = {
            "powershell.exe", "cmd.exe", "wscript.exe", "cscript.exe",
            "mshta.exe", "rundll32.exe", "regsvr32.exe"
        }

        Dim hackingTools As String() = {
            "mimikatz", "nc.exe", "netcat", "psexec", "procdump"
        }

        Dim processCount As New Dictionary(Of String, Integer)

        ' ================= ANALYSIS =================
        For Each line In tasklistOutput.Split(Environment.NewLine)

            Dim lowerLine = line.ToLower()

            ' Skip headers
            If String.IsNullOrWhiteSpace(line) OrElse lowerLine.Contains("image name") Then
                Continue For
            End If

            ' Count duplicate processes
            Dim parts = line.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

            If parts.Length > 0 Then
                Dim procName = parts(0).ToLower()

                ' Count instances
                If processCount.ContainsKey(procName) Then
                    processCount(procName) += 1
                Else
                    processCount(procName) = 1
                End If

                ' 🔴 Suspicious built-in tools
                For Each sp In suspiciousProcesses
                    If procName = sp Then
                        alerts.Add("[MEDIUM] Suspicious Process: " & line)
                    End If
                Next

                ' 🔥 Known hacking tools
                For Each tool In hackingTools
                    If procName.Contains(tool) Then
                        alerts.Add("[HIGH] Hacking Tool Detected: " & line)
                    End If
                Next

            End If

        Next

        ' ================= DUPLICATE PROCESS DETECTION =================
        For Each kv In processCount
            If kv.Value > 10 Then
                alerts.Add("[MEDIUM] Too many instances: " & kv.Key & " (" & kv.Value & ")")
            End If
        Next

        Return alerts

    End Function

End Module
