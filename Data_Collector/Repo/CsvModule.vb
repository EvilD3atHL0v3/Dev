Imports System.IO
Module CsvModule
    Public Sub AppendToCsv(folderPath As String, filePath As String)
        Dim csvPath As String = Path.Combine(folderPath, "report.csv")

        Dim dateNow As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim timeNow As String = DateTime.Now.ToString("HH:mm:ss")

        ' Call HashModule
        Dim md5Hash As String = HashModule.GetMD5(filePath)
        Dim sha256Hash As String = HashModule.GetSHA256(filePath)

        Dim line As String = $"{dateNow},{timeNow},{Path.GetFileName(filePath)},{md5Hash},{sha256Hash}"

        ' Create CSV with header if not exists
        If Not File.Exists(csvPath) Then
            Dim header As String = "DATE COLLECT,TIME OF COLLECT,FILENAME,HASHFILE MD5,HASHFILE SHA256"
            File.WriteAllText(csvPath, header & Environment.NewLine)
        End If

        File.AppendAllText(csvPath, line & Environment.NewLine)
    End Sub
End Module
