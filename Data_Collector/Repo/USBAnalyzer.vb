Imports System.Text.RegularExpressions

Public Module USBAnalyzer

    Public Function ParseUSBStor(raw As String) As List(Of String)
        Dim results As New List(Of String)

        Dim pattern As String =
            "USBSTOR\\Disk&Ven_(.*?)&Prod_(.*?)&Rev_.*?\\([^\r\n\\]+)"

        Dim matches = Regex.Matches(raw, pattern, RegexOptions.IgnoreCase)

        For Each m As Match In matches
            Dim vendor = m.Groups(1).Value
            Dim product = m.Groups(2).Value
            Dim serial = m.Groups(3).Value

            results.Add("Vendor: " & vendor &
                        " | Product: " & product &
                        " | Serial: " & serial)
        Next

        Return results.Distinct().ToList()
    End Function


    Public Function DetectUSBAlerts(parsed As List(Of String)) As List(Of String)
        Dim alerts As New List(Of String)

        For Each item In parsed
            Dim lower = item.ToLower()

            If lower.Contains("generic") Then
                alerts.Add("⚠ Generic USB device detected: " & item)
            End If

            If lower.Contains("unknown") Then
                alerts.Add("⚠ Unknown USB device: " & item)
            End If

            If item.Length < 30 Then
                alerts.Add("⚠ Suspicious short USB identifier: " & item)
            End If
        Next

        Return alerts
    End Function

End Module
