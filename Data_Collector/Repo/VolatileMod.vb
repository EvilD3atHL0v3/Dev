Imports System.Diagnostics
Imports System.IO
Imports System.Threading.Tasks
Module VolatileMod
    Public Async Function RunCommandAsync(cmd As String) As Task(Of String)
        Return Await Task.Run(Function()
                                  Dim psi As New ProcessStartInfo("cmd.exe", "/c " & cmd)
                                  psi.RedirectStandardOutput = True
                                  psi.UseShellExecute = False
                                  psi.CreateNoWindow = True

                                  Dim p As Process = Process.Start(psi)
                                  Return p.StandardOutput.ReadToEnd()
                              End Function)
    End Function

    Public Sub SaveToFile(folderPath As String, fileName As String, content As String)
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        File.WriteAllText(Path.Combine(folderPath, fileName), content)
    End Sub
    Public Sub AppendToCsv(folderPath As String, filePath As String)

        Dim csvPath = Path.Combine(folderPath, "report.csv")

        Dim md5 = GetMD5(filePath)
        Dim sha = GetSHA256(filePath)

        Dim line = $"{DateTime.Now:yyyy-MM-dd},{DateTime.Now:HH:mm:ss},{Path.GetFileName(filePath)},{md5},{sha}"

        If Not File.Exists(csvPath) Then
            File.WriteAllText(csvPath,
                "DATE OF COLLECT,TIME OF COLLECT,FILE NAME,MD5,SHA256" & Environment.NewLine)
        End If

        File.AppendAllText(csvPath, line & Environment.NewLine)

    End Sub
End Module
