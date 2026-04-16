Imports System.IO
Imports System.Security.Cryptography
Module HashModule
    Public Function GetMD5(filePath As String) As String
        Using stream = File.OpenRead(filePath)
            Using md5 As MD5 = MD5.Create()
                Return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower()
            End Using
        End Using
    End Function

    Public Function GetSHA256(filePath As String) As String
        Using stream = File.OpenRead(filePath)
            Using sha As SHA256 = SHA256.Create()
                Return BitConverter.ToString(sha.ComputeHash(stream)).Replace("-", "").ToLower()
            End Using
        End Using
    End Function
End Module
