Imports System.IO
Imports System.Text

Public Module EmailMod

    Public Function CollectAllEmailActivity(
        browserHistory As String,
        folderPath As String,
        timestamp As String
    ) As Task(Of String)

        Dim sb As New StringBuilder()
        Dim lower As String = browserHistory.ToLower()

        ' =====================================================
        ' OUTLOOK
        ' =====================================================
        sb.AppendLine("===== OUTLOOK =====")

        Dim outlookDir As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Microsoft\Outlook"
        )

        If Directory.Exists(outlookDir) Then
            Dim files = Directory.GetFiles(outlookDir, "*.*", SearchOption.AllDirectories)
            sb.AppendLine(String.Join(Environment.NewLine, files))
        Else
            sb.AppendLine("Outlook not found")
        End If

        sb.AppendLine()

        ' =====================================================
        ' THUNDERBIRD
        ' =====================================================
        sb.AppendLine("===== THUNDERBIRD =====")

        Dim tbDir As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Thunderbird\Profiles"
        )

        If Directory.Exists(tbDir) Then
            Dim files = Directory.GetFiles(tbDir, "*.*", SearchOption.AllDirectories)

            Dim mbox = files.Where(Function(f)
                                       Dim l = f.ToLower()
                                       Return l.EndsWith(".mbox") OrElse l.Contains("inbox") OrElse l.Contains("sent")
                                   End Function)

            sb.AppendLine(String.Join(Environment.NewLine, mbox))
        Else
            sb.AppendLine("Thunderbird not found")
        End If

        sb.AppendLine()

        ' =====================================================
        ' WINDOWS MAIL + eM CLIENT
        ' =====================================================
        sb.AppendLine("===== DESKTOP EMAIL CLIENTS =====")

        Dim winMail As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Comms\UnistoreDB"
        )

        If Directory.Exists(winMail) Then
            sb.AppendLine("Windows Mail artifacts detected")
        Else
            sb.AppendLine("Windows Mail not found")
        End If

        Dim emClient As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "eM Client"
        )

        If Directory.Exists(emClient) Then
            sb.AppendLine("eM Client data detected")
        Else
            sb.AppendLine("eM Client not found")
        End If

        sb.AppendLine()

        ' =====================================================
        ' WEBMAIL / ONLINE EMAIL SERVICES
        ' =====================================================
        sb.AppendLine("===== WEBMAIL ACTIVITY =====")

        If lower.Contains("mail.google.com") Then
            sb.AppendLine("Gmail detected")
        End If

        If lower.Contains("outlook.live.com") OrElse lower.Contains("office.com/mail") Then
            sb.AppendLine("Outlook Web detected")
        End If

        If lower.Contains("mail.yahoo.com") Then
            sb.AppendLine("Yahoo Mail detected")
        End If

        If lower.Contains("mail.proton.me") OrElse lower.Contains("protonmail.com") Then
            sb.AppendLine("ProtonMail detected")
        End If

        If lower.Contains("mail.zoho.com") Then
            sb.AppendLine("Zoho Mail detected")
        End If

        If lower.Contains("mail.aol.com") Then
            sb.AppendLine("AOL Mail detected")
        End If

        If lower.Contains("icloud.com/mail") Then
            sb.AppendLine("iCloud Mail detected")
        End If

        If lower.Contains("accounts.google.com") OrElse lower.Contains("login.microsoftonline.com") Then
            sb.AppendLine("Email login/authentication activity detected")
        End If

        sb.AppendLine()

        ' =====================================================
        ' SAVE OUTPUT FILE (SINGLE REPORT)
        ' =====================================================
        Dim filePath As String = Path.Combine(folderPath, "Email_Activity_" & timestamp & ".txt")
        File.WriteAllText(filePath, sb.ToString())

        Return Task.FromResult(filePath)

    End Function

End Module