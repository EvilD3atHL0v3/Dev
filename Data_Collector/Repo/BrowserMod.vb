Imports System.IO

Module BrowserMod

    Public Sub CollectEdge(folderPath As String, timestamp As String)
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        Dim edgePath As String = userProfile & "\AppData\Local\Microsoft\Edge\User Data\Default\History"

        If File.Exists(edgePath) Then
            Dim dest As String = Path.Combine(folderPath, "Edge_History_" & timestamp & ".db")
            File.Copy(edgePath, dest, True)

            VolatileMod.AppendToCsv(folderPath, dest)
        End If
    End Sub

    Public Sub CollectChrome(folderPath As String, timestamp As String)
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        Dim chromePath As String = userProfile & "\AppData\Local\Google\Chrome\User Data\Default\History"

        If File.Exists(chromePath) Then
            Dim dest As String = Path.Combine(folderPath, "Chrome_History_" & timestamp & ".db")
            File.Copy(chromePath, dest, True)

            VolatileMod.AppendToCsv(folderPath, dest)
        End If
    End Sub

    ' ================= BRAVE =================
    Public Sub CollectBrave(folderPath As String, timestamp As String)
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        Dim bravePath As String = userProfile & "\AppData\Local\BraveSoftware\Brave-Browser\User Data\Default\History"

        If File.Exists(bravePath) Then
            Dim dest As String = Path.Combine(folderPath, "Brave_History_" & timestamp & ".db")
            File.Copy(bravePath, dest, True)

            VolatileMod.AppendToCsv(folderPath, dest)
        End If
    End Sub

    ' ================= OPERA =================
    Public Sub CollectOpera(folderPath As String, timestamp As String)
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        Dim operaPath As String = userProfile & "\AppData\Roaming\Opera Software\Opera Stable\History"

        If File.Exists(operaPath) Then
            Dim dest As String = Path.Combine(folderPath, "Opera_History_" & timestamp & ".db")
            File.Copy(operaPath, dest, True)

            VolatileMod.AppendToCsv(folderPath, dest)
        End If
    End Sub

    Public Sub CollectFirefox(folderPath As String, timestamp As String)
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        Dim ffBase As String = userProfile & "\AppData\Roaming\Mozilla\Firefox\Profiles"

        If Directory.Exists(ffBase) Then
            Dim profileDir = Directory.GetDirectories(ffBase).FirstOrDefault()

            If profileDir IsNot Nothing Then
                Dim ffHistory As String = Path.Combine(profileDir, "places.sqlite")

                If File.Exists(ffHistory) Then
                    Dim dest As String = Path.Combine(folderPath, "Firefox_History_" & timestamp & ".sqlite")
                    File.Copy(ffHistory, dest, True)

                    VolatileMod.AppendToCsv(folderPath, dest)
                End If
            End If
        End If
    End Sub

End Module