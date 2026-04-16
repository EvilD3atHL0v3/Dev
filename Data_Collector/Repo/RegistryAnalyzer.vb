Module RegistryAnalyzer

    Public Class RegistryOptions
        Public Property DetectRunKeys As Boolean = True
        Public Property DetectRunOnce As Boolean = True
        Public Property DetectSuspiciousPaths As Boolean = True
        Public Property DetectEncodedPayloads As Boolean = True
        Public Property DetectHackingTools As Boolean = True
    End Class

    Public Function Analyze(registryOutput As String,
                            Optional options As RegistryOptions = Nothing) As List(Of String)

        If options Is Nothing Then options = New RegistryOptions()

        Dim alerts As New List(Of String)

        Dim suspiciousKeywords As String() = {
            "powershell", "cmd.exe", "wscript", "cscript",
            "mshta", "rundll32", "regsvr32"
        }

        Dim suspiciousPaths As String() = {
            "\appdata\", "\temp\", "\users\public\", "\programdata\"
        }

        Dim hackingTools As String() = {
            "mimikatz", "nc.exe", "netcat", "psexec", "procdump"
        }

        Dim lines = registryOutput.Split(Environment.NewLine)

        For Each line In lines

            Dim lowerLine = line.ToLower()

            ' ================= RUN KEYS =================
            If options.DetectRunKeys Then
                If lowerLine.Contains("\currentversion\run") Then
                    For Each kw In suspiciousKeywords
                        If lowerLine.Contains(kw) Then
                            alerts.Add("[HIGH] Suspicious Run Key Entry: " & line)
                        End If
                    Next
                End If
            End If

            ' ================= RUNONCE =================
            If options.DetectRunOnce Then
                If lowerLine.Contains("runonce") Then
                    alerts.Add("[MEDIUM] RunOnce Persistence Detected: " & line)
                End If
            End If

            ' ================= SUSPICIOUS PATHS =================
            If options.DetectSuspiciousPaths Then
                For Each path In suspiciousPaths
                    If lowerLine.Contains(path) Then
                        alerts.Add("[HIGH] Registry Persistence in Suspicious Path: " & line)
                    End If
                Next
            End If

            ' ================= ENCODED PAYLOAD =================
            If options.DetectEncodedPayloads Then
                If lowerLine.Contains("-enc") Or lowerLine.Contains("base64") Then
                    alerts.Add("[HIGH] Encoded Payload in Registry Entry: " & line)
                End If
            End If

            ' ================= HACKING TOOLS =================
            If options.DetectHackingTools Then
                For Each tool In hackingTools
                    If lowerLine.Contains(tool) Then
                        alerts.Add("[CRITICAL] Known Attack Tool in Registry: " & line)
                    End If
                Next
            End If

        Next

        Return alerts

    End Function

End Module
