Imports System.IO
Imports System.Diagnostics
Public Class Form1
    Private Sub btn_Checker_Click(sender As Object, e As EventArgs) Handles btn_Checker.Click
        Dim csvPath As String = "sites.csv"

        If Not File.Exists(csvPath) Then
            MessageBox.Show("Please ensure sites.csv exists in: " & Application.StartupPath)
            Return
        End If

        dgvResults.Rows.Clear()

        Try
            ' Read all lines into an array
            Dim domains As String() = File.ReadAllLines(csvPath)

            ' Use a specific variable name 'siteUrl' and declare it 'As String'
            For Each siteUrl As String In domains
                If String.IsNullOrWhiteSpace(siteUrl) Then Continue For

                Dim currentTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                ' Clean the string before passing it
                Dim cleanedUrl As String = siteUrl.Trim()

                Dim statusCode As String = GetHttpStatus(cleanedUrl)
                Dim remark As String = GetStatusDescription(statusCode)

                ' Add to DataGridView
                dgvResults.Rows.Add(cleanedUrl, currentTime, statusCode, remark)
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Function GetHttpStatus(url As String) As String
        Try
            Dim proc As New Process()
            ' curl -s (silent) -o /dev/null (ignore body) -w (write out status code)
            proc.StartInfo.FileName = "curl"
            proc.StartInfo.Arguments = $"-s -o NUL -w ""%{{http_code}}"" {url}"
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.StartInfo.CreateNoWindow = True
            proc.Start()

            Dim output As String = proc.StandardOutput.ReadToEnd()
            proc.WaitForExit()
            Return output.Trim()
        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    Private Function GetStatusDescription(code As String) As String
        Select Case code
            Case "200" : Return "OK - Success"
            Case "301" : Return "Moved Permanently"
            Case "302" : Return "Found (Redirect)"
            Case "403" : Return "Forbidden"
            Case "404" : Return "Not Found"
            Case "500" : Return "Internal Server Error"
            Case "503" : Return "Service Unavailable"
            Case "000" : Return "Connection Failed"
            Case "Error" : Return "Execution Error"
            Case Else : Return "Unknown Status"
        End Select
    End Function


End Class
