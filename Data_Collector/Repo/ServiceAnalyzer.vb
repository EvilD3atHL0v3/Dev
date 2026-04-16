Module ServiceAnalyzer

    Public Class ServiceOptions
        Public Property DetectAutoStart As Boolean = True
        Public Property DetectSystemServices As Boolean = True
        Public Property DetectServiceCreation As Boolean = True
        Public Property DetectServiceFlood As Boolean = True
    End Class

    Public Function Analyze(serviceOutput As String,
                            Optional options As ServiceOptions = Nothing) As List(Of String)

        If options Is Nothing Then options = New ServiceOptions()

        Dim alerts As New List(Of String)

        Dim suspiciousKeywords As String() = {
            "powershell", "cmd.exe", "wscript", "cscript",
            "rundll32", "mshta", "regsvr32"
        }

        Dim suspiciousPaths As String() = {
            "\appdata\", "\temp\", "\users\public\", "\programdata\"
        }

        Dim hackingTools As String() = {
            "mimikatz", "nc", "netcat", "psexec", "procdump"
        }

        Dim serviceCount As New Dictionary(Of String, Integer)

        For Each line In serviceOutput.Split(Environment.NewLine)

            Dim lowerLine = line.ToLower()

            ' ================= PROCESS CHECK =================
            For Each keyword In suspiciousKeywords
                If lowerLine.Contains(keyword) Then
                    alerts.Add("[HIGH] Suspicious Service Process: " & line)
                End If
            Next

            ' ================= PATH CHECK =================
            For Each path In suspiciousPaths
                If lowerLine.Contains(path) Then
                    alerts.Add("[HIGH] Service Running From Suspicious Path: " & line)
                End If
            Next

            ' ================= TOOL DETECTION =================
            For Each tool In hackingTools
                If lowerLine.Contains(tool) Then
                    alerts.Add("[CRITICAL] Hacking Tool Service: " & line)
                End If
            Next

            ' ================= OPTIONAL: AUTO START =================
            If options.DetectAutoStart Then
                If lowerLine.Contains("auto start") Then
                    alerts.Add("[MEDIUM] Auto-Start Service: " & line)
                End If
            End If

            ' ================= OPTIONAL: SYSTEM SERVICE =================
            If options.DetectSystemServices Then
                If lowerLine.Contains("start name: system") Then
                    alerts.Add("[HIGH] SYSTEM Service Detected: " & line)
                End If
            End If

            ' ================= SERVICE CREATION ABUSE =================
            If options.DetectServiceCreation Then
                If lowerLine.Contains("sc create") Or lowerLine.Contains("create service") Then
                    alerts.Add("[HIGH] Service Creation Abuse Detected: " & line)
                End If
            End If

            ' ================= COUNT SERVICES =================
            If options.DetectServiceFlood Then
                Dim parts = line.Split(" "c)
                If parts.Length > 0 Then
                    Dim svc = parts(0)

                    If serviceCount.ContainsKey(svc) Then
                        serviceCount(svc) += 1
                    Else
                        serviceCount(svc) = 1
                    End If
                End If
            End If

        Next

        ' ================= FLOOD DETECTION =================
        If options.DetectServiceFlood Then
            For Each kv In serviceCount
                If kv.Value > 10 Then
                    alerts.Add("[MEDIUM] Service Flooding Detected: " & kv.Key & " (" & kv.Value & ")")
                End If
            Next
        End If

        Return alerts

    End Function

End Module
