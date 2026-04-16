Imports System.Text.RegularExpressions

Module NetworkAnalyzer

    Public Function Analyze(netstatOutput As String,
                            dnsOutput As String,
                            tcpOutput As String) As List(Of String)

        Dim alerts As New List(Of String)

        ' ================= CONFIG =================
        Dim suspiciousPorts As String() = {"4444", "5555", "6666", "1337", "9001", "8080", "8443"}
        Dim suspiciousDomains As String() = {".ru", ".cn", ".tk", ".xyz", "pastebin", "ngrok", "discord", "bit.ly"}
        Dim suspiciousProcesses As String() = {"powershell", "cmd.exe", "wscript", "cscript", "mshta", "rundll32"}

        ' ================= NETSTAT ANALYSIS =================
        For Each line In netstatOutput.Split(Environment.NewLine)

            Dim lowerLine = line.ToLower()

            If line.Contains("ESTABLISHED") Then

                ' External IP
                If Not lowerLine.Contains("127.") AndAlso
                   Not lowerLine.Contains("192.168") AndAlso
                   Not lowerLine.Contains("10.") Then

                    alerts.Add("External Connection: " & line)
                End If

                ' Suspicious ports
                For Each port In suspiciousPorts
                    If line.Contains(":" & port) Then
                        alerts.Add("Suspicious Port: " & line)
                    End If
                Next

                ' Suspicious process keyword
                For Each proc In suspiciousProcesses
                    If lowerLine.Contains(proc) Then
                        alerts.Add("Suspicious Process: " & line)
                    End If
                Next

            End If

            ' Listening ports
            If line.Contains("LISTENING") Then
                alerts.Add("Listening Port (Possible Backdoor): " & line)
            End If

        Next

        ' ================= DNS ANALYSIS =================
        For Each line In dnsOutput.Split(Environment.NewLine)

            Dim lowerLine = line.ToLower()

            For Each keyword In suspiciousDomains
                If lowerLine.Contains(keyword) Then
                    alerts.Add("Suspicious DNS: " & line)
                End If
            Next

        Next

        ' ================= TCP (POWERSHELL) =================
        For Each line In tcpOutput.Split(Environment.NewLine)

            Dim lowerLine = line.ToLower()

            If lowerLine.Contains("established") Then

                If lowerLine.Contains("powershell") Then
                    alerts.Add("PowerShell Network Activity: " & line)
                End If

                If lowerLine.Contains("cmd.exe") Then
                    alerts.Add("CMD Network Activity: " & line)
                End If

            End If

        Next

        ' ================= BEACONING DETECTION =================
        Dim connectionCount As New Dictionary(Of String, Integer)

        For Each line In netstatOutput.Split(Environment.NewLine)

            If line.Contains("ESTABLISHED") Then
                If connectionCount.ContainsKey(line) Then
                    connectionCount(line) += 1
                Else
                    connectionCount(line) = 1
                End If
            End If

        Next

        For Each kv In connectionCount
            If kv.Value > 5 Then
                alerts.Add("Possible Beaconing: " & kv.Key)
            End If
        Next

        Return alerts

    End Function

End Module
