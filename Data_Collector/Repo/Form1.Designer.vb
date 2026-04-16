Imports System.IO
Imports System.Diagnostics
Imports System.Security.Principal
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    '-----------------------------------------------------------------------------------
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.btnSelectPath = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUnCheckAll = New System.Windows.Forms.Button()
        Me.btnCheckAll = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chk_EmailActivity = New System.Windows.Forms.CheckBox()
        Me.chk_USB_History = New System.Windows.Forms.CheckBox()
        Me.chk_FileDownloads = New System.Windows.Forms.CheckBox()
        Me.chk_HostFile = New System.Windows.Forms.CheckBox()
        Me.chk_FilePrefetch = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chk_BOpera = New System.Windows.Forms.CheckBox()
        Me.chk_BBrave = New System.Windows.Forms.CheckBox()
        Me.chk_BFirefox = New System.Windows.Forms.CheckBox()
        Me.chk_BChrome = New System.Windows.Forms.CheckBox()
        Me.chk_BEdge = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_VSystemEvent = New System.Windows.Forms.CheckBox()
        Me.chk_VAppEvent = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chk_E4648 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_E1102 = New System.Windows.Forms.CheckBox()
        Me.txt_ECount = New System.Windows.Forms.TextBox()
        Me.chk_E4688 = New System.Windows.Forms.CheckBox()
        Me.chk_E4625 = New System.Windows.Forms.CheckBox()
        Me.chk_E4672 = New System.Windows.Forms.CheckBox()
        Me.chk_E4624 = New System.Windows.Forms.CheckBox()
        Me.chk_VSecurityEvent = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_VRegistry = New System.Windows.Forms.CheckBox()
        Me.chk_VCommandHistory = New System.Windows.Forms.CheckBox()
        Me.chk_VServices = New System.Windows.Forms.CheckBox()
        Me.chk_VSchedTask = New System.Windows.Forms.CheckBox()
        Me.chk_VOpenFile = New System.Windows.Forms.CheckBox()
        Me.chk_VSystemInfo = New System.Windows.Forms.CheckBox()
        Me.chk_VLoginUser = New System.Windows.Forms.CheckBox()
        Me.chk_VActNetCon = New System.Windows.Forms.CheckBox()
        Me.chk_VRunProcess = New System.Windows.Forms.CheckBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbLog
        '
        Me.rtbLog.BackColor = System.Drawing.SystemColors.InfoText
        Me.rtbLog.ForeColor = System.Drawing.Color.Lime
        Me.rtbLog.Location = New System.Drawing.Point(795, 116)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(371, 644)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(21, 781)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(1145, 21)
        Me.pbStatus.TabIndex = 1
        Me.pbStatus.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Output Path :"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPath.Location = New System.Drawing.Point(197, 23)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(153, 25)
        Me.lblPath.TabIndex = 3
        Me.lblPath.Text = "D:\DataCollect"
        '
        'btnSelectPath
        '
        Me.btnSelectPath.BackColor = System.Drawing.Color.Blue
        Me.btnSelectPath.Font = New System.Drawing.Font("Snap ITC", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPath.ForeColor = System.Drawing.Color.White
        Me.btnSelectPath.Location = New System.Drawing.Point(956, 13)
        Me.btnSelectPath.Name = "btnSelectPath"
        Me.btnSelectPath.Size = New System.Drawing.Size(192, 45)
        Me.btnSelectPath.TabIndex = 4
        Me.btnSelectPath.Text = "Select Path"
        Me.btnSelectPath.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.lblPath)
        Me.GroupBox1.Controls.Add(Me.btnSelectPath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1154, 72)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1020, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Version : 2026.4.15"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.btnUnCheckAll)
        Me.GroupBox2.Controls.Add(Me.btnCheckAll)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 644)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data to Collect"
        '
        'btnUnCheckAll
        '
        Me.btnUnCheckAll.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnUnCheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnCheckAll.Location = New System.Drawing.Point(28, 533)
        Me.btnUnCheckAll.Name = "btnUnCheckAll"
        Me.btnUnCheckAll.Size = New System.Drawing.Size(120, 34)
        Me.btnUnCheckAll.TabIndex = 5
        Me.btnUnCheckAll.Text = "Uncheck All"
        Me.btnUnCheckAll.UseVisualStyleBackColor = False
        '
        'btnCheckAll
        '
        Me.btnCheckAll.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAll.Location = New System.Drawing.Point(154, 533)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(96, 34)
        Me.btnCheckAll.TabIndex = 4
        Me.btnCheckAll.Text = "Check All"
        Me.btnCheckAll.UseVisualStyleBackColor = False
        '
        'GroupBox7
        Me.GroupBox7.Controls.Add(Me.chk_EmailActivity)
        Me.GroupBox7.Controls.Add(Me.chk_USB_History)
        Me.GroupBox7.Controls.Add(Me.chk_FileDownloads)
        Me.GroupBox7.Controls.Add(Me.chk_HostFile)
        Me.GroupBox7.Controls.Add(Me.chk_FilePrefetch)
        Me.GroupBox7.Location = New System.Drawing.Point(336, 479)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(410, 142)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Others"
        '
        'chk_EmailActivity
        '
        Me.chk_EmailActivity.AutoSize = True
        Me.chk_EmailActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_EmailActivity.Location = New System.Drawing.Point(195, 72)
        Me.chk_EmailActivity.Name = "chk_EmailActivity"
        Me.chk_EmailActivity.Size = New System.Drawing.Size(175, 26)
        Me.chk_EmailActivity.TabIndex = 15
        Me.chk_EmailActivity.Text = "Email List Activity"
        Me.chk_EmailActivity.UseVisualStyleBackColor = True
        '
        'chk_USB_History
        '
        Me.chk_USB_History.AutoSize = True
        Me.chk_USB_History.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_USB_History.Location = New System.Drawing.Point(195, 40)
        Me.chk_USB_History.Name = "chk_USB_History"
        Me.chk_USB_History.Size = New System.Drawing.Size(134, 26)
        Me.chk_USB_History.TabIndex = 14
        Me.chk_USB_History.Text = "USB History"
        Me.chk_USB_History.UseVisualStyleBackColor = True
        '
        'chk_FileDownloads
        '
        Me.chk_FileDownloads.AutoSize = True
        Me.chk_FileDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_FileDownloads.Location = New System.Drawing.Point(19, 72)
        Me.chk_FileDownloads.Name = "chk_FileDownloads"
        Me.chk_FileDownloads.Size = New System.Drawing.Size(150, 26)
        Me.chk_FileDownloads.TabIndex = 13
        Me.chk_FileDownloads.Text = "Download File"
        Me.chk_FileDownloads.UseVisualStyleBackColor = True
        '
        'chk_HostFile
        '
        Me.chk_HostFile.AutoSize = True
        Me.chk_HostFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_HostFile.Location = New System.Drawing.Point(19, 40)
        Me.chk_HostFile.Name = "chk_HostFile"
        Me.chk_HostFile.Size = New System.Drawing.Size(102, 26)
        Me.chk_HostFile.TabIndex = 12
        Me.chk_HostFile.Text = "HostFile"
        Me.chk_HostFile.UseVisualStyleBackColor = True
        '
        'chk_FilePrefetch
        '
        Me.chk_FilePrefetch.AutoSize = True
        Me.chk_FilePrefetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_FilePrefetch.Location = New System.Drawing.Point(18, 104)
        Me.chk_FilePrefetch.Name = "chk_FilePrefetch"
        Me.chk_FilePrefetch.Size = New System.Drawing.Size(103, 26)
        Me.chk_FilePrefetch.TabIndex = 11
        Me.chk_FilePrefetch.Text = "Prefetch"
        Me.chk_FilePrefetch.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chk_BOpera)
        Me.GroupBox5.Controls.Add(Me.chk_BBrave)
        Me.GroupBox5.Controls.Add(Me.chk_BFirefox)
        Me.GroupBox5.Controls.Add(Me.chk_BChrome)
        Me.GroupBox5.Controls.Add(Me.chk_BEdge)
        Me.GroupBox5.Location = New System.Drawing.Point(28, 385)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(285, 142)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Browser History"
        '
        'chk_BOpera
        '
        Me.chk_BOpera.AutoSize = True
        Me.chk_BOpera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BOpera.Location = New System.Drawing.Point(165, 68)
        Me.chk_BOpera.Name = "chk_BOpera"
        Me.chk_BOpera.Size = New System.Drawing.Size(86, 26)
        Me.chk_BOpera.TabIndex = 13
        Me.chk_BOpera.Text = "Opera"
        Me.chk_BOpera.UseVisualStyleBackColor = True
        '
        'chk_BBrave
        '
        Me.chk_BBrave.AutoSize = True
        Me.chk_BBrave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BBrave.Location = New System.Drawing.Point(165, 36)
        Me.chk_BBrave.Name = "chk_BBrave"
        Me.chk_BBrave.Size = New System.Drawing.Size(83, 26)
        Me.chk_BBrave.TabIndex = 12
        Me.chk_BBrave.Text = "Brave"
        Me.chk_BBrave.UseVisualStyleBackColor = True
        '
        'chk_BFirefox
        '
        Me.chk_BFirefox.AutoSize = True
        Me.chk_BFirefox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BFirefox.Location = New System.Drawing.Point(21, 100)
        Me.chk_BFirefox.Name = "chk_BFirefox"
        Me.chk_BFirefox.Size = New System.Drawing.Size(91, 26)
        Me.chk_BFirefox.TabIndex = 11
        Me.chk_BFirefox.Text = "Firefox"
        Me.chk_BFirefox.UseVisualStyleBackColor = True
        '
        'chk_BChrome
        '
        Me.chk_BChrome.AutoSize = True
        Me.chk_BChrome.Checked = True
        Me.chk_BChrome.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_BChrome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BChrome.Location = New System.Drawing.Point(21, 68)
        Me.chk_BChrome.Name = "chk_BChrome"
        Me.chk_BChrome.Size = New System.Drawing.Size(99, 26)
        Me.chk_BChrome.TabIndex = 10
        Me.chk_BChrome.Text = "Chrome"
        Me.chk_BChrome.UseVisualStyleBackColor = True
        '
        'chk_BEdge
        '
        Me.chk_BEdge.AutoSize = True
        Me.chk_BEdge.Checked = True
        Me.chk_BEdge.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_BEdge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BEdge.Location = New System.Drawing.Point(21, 36)
        Me.chk_BEdge.Name = "chk_BEdge"
        Me.chk_BEdge.Size = New System.Drawing.Size(78, 26)
        Me.chk_BEdge.TabIndex = 9
        Me.chk_BEdge.Text = "Edge"
        Me.chk_BEdge.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk_VSystemEvent)
        Me.GroupBox4.Controls.Add(Me.chk_VAppEvent)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.chk_VSecurityEvent)
        Me.GroupBox4.Location = New System.Drawing.Point(336, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(410, 432)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Security Event Log"
        '
        'chk_VSystemEvent
        '
        Me.chk_VSystemEvent.AutoSize = True
        Me.chk_VSystemEvent.Checked = True
        Me.chk_VSystemEvent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VSystemEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VSystemEvent.Location = New System.Drawing.Point(19, 393)
        Me.chk_VSystemEvent.Name = "chk_VSystemEvent"
        Me.chk_VSystemEvent.Size = New System.Drawing.Size(224, 26)
        Me.chk_VSystemEvent.TabIndex = 4
        Me.chk_VSystemEvent.Text = "Windows System Event"
        Me.chk_VSystemEvent.UseVisualStyleBackColor = True
        '
        'chk_VAppEvent
        '
        Me.chk_VAppEvent.AutoSize = True
        Me.chk_VAppEvent.Checked = True
        Me.chk_VAppEvent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VAppEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VAppEvent.Location = New System.Drawing.Point(19, 361)
        Me.chk_VAppEvent.Name = "chk_VAppEvent"
        Me.chk_VAppEvent.Size = New System.Drawing.Size(253, 26)
        Me.chk_VAppEvent.TabIndex = 3
        Me.chk_VAppEvent.Text = "Windows Application Event"
        Me.chk_VAppEvent.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chk_E4648)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.chk_E1102)
        Me.GroupBox6.Controls.Add(Me.txt_ECount)
        Me.GroupBox6.Controls.Add(Me.chk_E4688)
        Me.GroupBox6.Controls.Add(Me.chk_E4625)
        Me.GroupBox6.Controls.Add(Me.chk_E4672)
        Me.GroupBox6.Controls.Add(Me.chk_E4624)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox6.Location = New System.Drawing.Point(19, 64)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(297, 281)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Filtered Event"
        '
        'chk_E4648
        '
        Me.chk_E4648.AutoSize = True
        Me.chk_E4648.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_E4648.Location = New System.Drawing.Point(22, 167)
        Me.chk_E4648.Name = "chk_E4648"
        Me.chk_E4648.Size = New System.Drawing.Size(266, 26)
        Me.chk_E4648.TabIndex = 14
        Me.chk_E4648.Text = "4648 - Explicit credential use"
        Me.chk_E4648.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Last Event Log:"
        '
        'chk_E1102
        '
        Me.chk_E1102.AutoSize = True
        Me.chk_E1102.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_E1102.Location = New System.Drawing.Point(22, 199)
        Me.chk_E1102.Name = "chk_E1102"
        Me.chk_E1102.Size = New System.Drawing.Size(186, 26)
        Me.chk_E1102.TabIndex = 11
        Me.chk_E1102.Text = "1102 - Log cleared"
        Me.chk_E1102.UseVisualStyleBackColor = True
        '
        'txt_ECount
        '
        Me.txt_ECount.Location = New System.Drawing.Point(164, 237)
        Me.txt_ECount.MaxLength = 4
        Me.txt_ECount.Name = "txt_ECount"
        Me.txt_ECount.Size = New System.Drawing.Size(70, 28)
        Me.txt_ECount.TabIndex = 12
        Me.txt_ECount.Text = "300"
        '
        'chk_E4688
        '
        Me.chk_E4688.AutoSize = True
        Me.chk_E4688.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_E4688.Location = New System.Drawing.Point(22, 135)
        Me.chk_E4688.Name = "chk_E4688"
        Me.chk_E4688.Size = New System.Drawing.Size(226, 26)
        Me.chk_E4688.TabIndex = 10
        Me.chk_E4688.Text = "4688 - Process creation"
        Me.chk_E4688.UseVisualStyleBackColor = True
        '
        'chk_E4625
        '
        Me.chk_E4625.AutoSize = True
        Me.chk_E4625.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_E4625.Location = New System.Drawing.Point(22, 71)
        Me.chk_E4625.Name = "chk_E4625"
        Me.chk_E4625.Size = New System.Drawing.Size(190, 26)
        Me.chk_E4625.TabIndex = 9
        Me.chk_E4625.Text = "4625 - Logon failed"
        Me.chk_E4625.UseVisualStyleBackColor = True
        '
        'chk_E4672
        '
        Me.chk_E4672.AutoSize = True
        Me.chk_E4672.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_E4672.Location = New System.Drawing.Point(22, 103)
        Me.chk_E4672.Name = "chk_E4672"
        Me.chk_E4672.Size = New System.Drawing.Size(223, 26)
        Me.chk_E4672.TabIndex = 8
        Me.chk_E4672.Text = "4672 - Admin privileges"
        Me.chk_E4672.UseVisualStyleBackColor = True
        '
        'chk_E4624
        '
        Me.chk_E4624.AutoSize = True
        Me.chk_E4624.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_E4624.Location = New System.Drawing.Point(22, 38)
        Me.chk_E4624.Name = "chk_E4624"
        Me.chk_E4624.Size = New System.Drawing.Size(212, 26)
        Me.chk_E4624.TabIndex = 7
        Me.chk_E4624.Text = "4624 - Logon success"
        Me.chk_E4624.UseVisualStyleBackColor = True
        '
        'chk_VSecurityEvent
        '
        Me.chk_VSecurityEvent.AutoSize = True
        Me.chk_VSecurityEvent.Checked = True
        Me.chk_VSecurityEvent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VSecurityEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VSecurityEvent.Location = New System.Drawing.Point(19, 32)
        Me.chk_VSecurityEvent.Name = "chk_VSecurityEvent"
        Me.chk_VSecurityEvent.Size = New System.Drawing.Size(270, 26)
        Me.chk_VSecurityEvent.TabIndex = 1
        Me.chk_VSecurityEvent.Text = "Windows Security Event (full)"
        Me.chk_VSecurityEvent.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_VRegistry)
        Me.GroupBox3.Controls.Add(Me.chk_VCommandHistory)
        Me.GroupBox3.Controls.Add(Me.chk_VServices)
        Me.GroupBox3.Controls.Add(Me.chk_VSchedTask)
        Me.GroupBox3.Controls.Add(Me.chk_VOpenFile)
        Me.GroupBox3.Controls.Add(Me.chk_VSystemInfo)
        Me.GroupBox3.Controls.Add(Me.chk_VLoginUser)
        Me.GroupBox3.Controls.Add(Me.chk_VActNetCon)
        Me.GroupBox3.Controls.Add(Me.chk_VRunProcess)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 329)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Volatile"
        '
        'chk_VRegistry
        '
        Me.chk_VRegistry.AutoSize = True
        Me.chk_VRegistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VRegistry.Location = New System.Drawing.Point(21, 289)
        Me.chk_VRegistry.Name = "chk_VRegistry"
        Me.chk_VRegistry.Size = New System.Drawing.Size(102, 26)
        Me.chk_VRegistry.TabIndex = 8
        Me.chk_VRegistry.Text = "Registry"
        Me.chk_VRegistry.UseVisualStyleBackColor = True
        '
        'chk_VCommandHistory
        '
        Me.chk_VCommandHistory.AutoSize = True
        Me.chk_VCommandHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VCommandHistory.Location = New System.Drawing.Point(21, 257)
        Me.chk_VCommandHistory.Name = "chk_VCommandHistory"
        Me.chk_VCommandHistory.Size = New System.Drawing.Size(178, 26)
        Me.chk_VCommandHistory.TabIndex = 7
        Me.chk_VCommandHistory.Text = "Command History"
        Me.chk_VCommandHistory.UseVisualStyleBackColor = True
        '
        'chk_VServices
        '
        Me.chk_VServices.AutoSize = True
        Me.chk_VServices.Checked = True
        Me.chk_VServices.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VServices.Location = New System.Drawing.Point(21, 225)
        Me.chk_VServices.Name = "chk_VServices"
        Me.chk_VServices.Size = New System.Drawing.Size(105, 26)
        Me.chk_VServices.TabIndex = 6
        Me.chk_VServices.Text = "Services"
        Me.chk_VServices.UseVisualStyleBackColor = True
        '
        'chk_VSchedTask
        '
        Me.chk_VSchedTask.AutoSize = True
        Me.chk_VSchedTask.Checked = True
        Me.chk_VSchedTask.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VSchedTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VSchedTask.Location = New System.Drawing.Point(21, 193)
        Me.chk_VSchedTask.Name = "chk_VSchedTask"
        Me.chk_VSchedTask.Size = New System.Drawing.Size(175, 26)
        Me.chk_VSchedTask.TabIndex = 5
        Me.chk_VSchedTask.Text = "Scheduled Tasks"
        Me.chk_VSchedTask.UseVisualStyleBackColor = True
        '
        'chk_VOpenFile
        '
        Me.chk_VOpenFile.AutoSize = True
        Me.chk_VOpenFile.Checked = True
        Me.chk_VOpenFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VOpenFile.Location = New System.Drawing.Point(21, 129)
        Me.chk_VOpenFile.Name = "chk_VOpenFile"
        Me.chk_VOpenFile.Size = New System.Drawing.Size(185, 26)
        Me.chk_VOpenFile.TabIndex = 4
        Me.chk_VOpenFile.Text = "Open Files/Shares"
        Me.chk_VOpenFile.UseVisualStyleBackColor = True
        '
        'chk_VSystemInfo
        '
        Me.chk_VSystemInfo.AutoSize = True
        Me.chk_VSystemInfo.Checked = True
        Me.chk_VSystemInfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VSystemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VSystemInfo.Location = New System.Drawing.Point(21, 161)
        Me.chk_VSystemInfo.Name = "chk_VSystemInfo"
        Me.chk_VSystemInfo.Size = New System.Drawing.Size(188, 26)
        Me.chk_VSystemInfo.TabIndex = 3
        Me.chk_VSystemInfo.Text = "System Information"
        Me.chk_VSystemInfo.UseVisualStyleBackColor = True
        '
        'chk_VLoginUser
        '
        Me.chk_VLoginUser.AutoSize = True
        Me.chk_VLoginUser.Checked = True
        Me.chk_VLoginUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VLoginUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VLoginUser.Location = New System.Drawing.Point(21, 96)
        Me.chk_VLoginUser.Name = "chk_VLoginUser"
        Me.chk_VLoginUser.Size = New System.Drawing.Size(168, 26)
        Me.chk_VLoginUser.TabIndex = 2
        Me.chk_VLoginUser.Text = "Logged-in Users"
        Me.chk_VLoginUser.UseVisualStyleBackColor = True
        '
        'chk_VActNetCon
        '
        Me.chk_VActNetCon.AutoSize = True
        Me.chk_VActNetCon.Checked = True
        Me.chk_VActNetCon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VActNetCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VActNetCon.Location = New System.Drawing.Point(21, 64)
        Me.chk_VActNetCon.Name = "chk_VActNetCon"
        Me.chk_VActNetCon.Size = New System.Drawing.Size(164, 26)
        Me.chk_VActNetCon.TabIndex = 1
        Me.chk_VActNetCon.Text = "Network Activity"
        Me.chk_VActNetCon.UseVisualStyleBackColor = True
        '
        'chk_VRunProcess
        '
        Me.chk_VRunProcess.AutoSize = True
        Me.chk_VRunProcess.Checked = True
        Me.chk_VRunProcess.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_VRunProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VRunProcess.Location = New System.Drawing.Point(21, 32)
        Me.chk_VRunProcess.Name = "chk_VRunProcess"
        Me.chk_VRunProcess.Size = New System.Drawing.Size(173, 26)
        Me.chk_VRunProcess.TabIndex = 0
        Me.chk_VRunProcess.Text = "Running Process"
        Me.chk_VRunProcess.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.Font = New System.Drawing.Font("Snap ITC", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(239, 818)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(683, 103)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "S T A R T    C O L L E C T I O N"
        Me.btnStart.UseVisualStyleBackColor = False

        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1178, 929)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.rtbLog)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Data Collector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents pbStatus As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents btnSelectPath As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnStart As Button

    Dim targetPath As String = ""
    '-----------------------------------------------------------------------------------
    Private Sub RestartAsAdmin()
        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = Application.ExecutablePath
        startInfo.Verb = "runas"
        startInfo.UseShellExecute = True
        Try
            Process.Start(startInfo)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("Admin permission required.")
        End Try
    End Sub
    Private Function IsAdmin() As Boolean
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    '-----------------------------------------------------------------------------------
    Private Sub btnSelectPath_Click(sender As Object, e As EventArgs) Handles btnSelectPath.Click
        Using fbd As New FolderBrowserDialog()
            If fbd.ShowDialog() = DialogResult.OK Then
                targetPath = fbd.SelectedPath
                lblPath.Text = targetPath
            End If
        End Using
    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chk_VActNetCon As CheckBox
    Friend WithEvents chk_VRunProcess As CheckBox
    Friend WithEvents chk_VRegistry As CheckBox
    Friend WithEvents chk_VCommandHistory As CheckBox
    Friend WithEvents chk_VServices As CheckBox
    Friend WithEvents chk_VSchedTask As CheckBox
    Friend WithEvents chk_VOpenFile As CheckBox
    Friend WithEvents chk_VSystemInfo As CheckBox
    Friend WithEvents chk_VLoginUser As CheckBox

    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Force admin first
        If Not IsAdmin() Then
            RestartAsAdmin()
            Exit Sub
        End If
        '-----------------------------------------------
        Dim folderPath As String = lblPath.Text
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        If String.IsNullOrWhiteSpace(folderPath) Then
            MessageBox.Show("Please select an output folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            ' Count selected tasks for progress bar ---------------------------------------
            Dim totalTasks As Integer = 0
            If chk_VRunProcess.Checked Then totalTasks += 1
            If chk_VActNetCon.Checked Then totalTasks += 1
            If chk_VLoginUser.Checked Then totalTasks += 1
            If chk_VOpenFile.Checked Then totalTasks += 1
            If chk_VSystemInfo.Checked Then totalTasks += 1
            If chk_VSchedTask.Checked Then totalTasks += 1
            If chk_VServices.Checked Then totalTasks += 1
            If chk_VCommandHistory.Checked Then totalTasks += 1
            If chk_VRegistry.Checked Then totalTasks += 1
            If chk_BEdge.Checked Then totalTasks += 1
            If chk_BChrome.Checked Then totalTasks += 1
            If chk_BFirefox.Checked Then totalTasks += 1
            If chk_BBrave.Checked Then totalTasks += 1
            If chk_BOpera.Checked Then totalTasks += 1
            If chk_VSecurityEvent.Checked Then totalTasks += 1
            If chk_VAppEvent.Checked Then totalTasks += 1
            If chk_VSystemEvent.Checked Then totalTasks += 1
            If chk_HostFile.Checked Then totalTasks += 1
            If chk_FileDownloads.Checked Then totalTasks += 1
            If chk_FilePrefetch.Checked Then totalTasks += 1
            If chk_USB_History.Checked Then totalTasks += 1
            If chk_EmailActivity.Checked Then totalTasks += 1
            pbStatus.Minimum = 0
            pbStatus.Maximum = totalTasks
            pbStatus.Value = 0
            pbStatus.Visible = True
            '------------------------------------------------------------------------------
            Dim progress As Integer = 0
            btnStart.Enabled = False
            '----------VOLATILE------------------------------------------------------------
            ' Processes
            If chk_VRunProcess.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting..." & Environment.NewLine)
                Dim output = Await VolatileMod.RunCommandAsync("tasklist")
                Dim filePath = Path.Combine(folderPath, "Running_Processes_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                ' ================= ANALYZE =================
                Dim alerts = ProcessAnalyzer.Analyze(output)
                If alerts.Count > 0 Then
                    Dim alertFile = Path.Combine(folderPath, "Running_Process_Alerts_" & timestamp & ".txt")
                    File.WriteAllLines(alertFile, alerts)
                    VolatileMod.AppendToCsv(folderPath, alertFile)
                    rtbLog.AppendText("⚠ Suspicious processes detected!" & Environment.NewLine)
                Else
                    rtbLog.AppendText("✔ No suspicious processes" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Processes saved" & Environment.NewLine)
            End If
            ' Network Activity
            If chk_VActNetCon.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Network Activity..." & Environment.NewLine)
                ' ================= NETSTAT =================
                Dim netstatOutput = Await VolatileMod.RunCommandAsync("netstat -ano")
                ' ================= DNS CACHE =================
                Dim dnsOutput = Await VolatileMod.RunCommandAsync("ipconfig /displaydns")
                ' ================= POWERSHELL TCP CONNECTIONS =================
                Dim tcpOutput = Await VolatileMod.RunCommandAsync("powershell Get-NetTCPConnection")
                ' ================= COMBINE OUTPUT =================
                Dim output As String =
                "================ NETSTAT -ANO ================" & Environment.NewLine &
                netstatOutput & Environment.NewLine &
                Environment.NewLine &
                "================ DNS CACHE ====================" & Environment.NewLine &
                dnsOutput & Environment.NewLine &
                Environment.NewLine &
                "================ GET-NETTCPCONNECTION =========" & Environment.NewLine &
                tcpOutput
                ' ================= SAVE FILE =================
                Dim filePath = Path.Combine(folderPath, "Network_Activity_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Network activity saved" & Environment.NewLine)
                ' ================= ANALYZE =================
                Dim alerts = NetworkAnalyzer.Analyze(netstatOutput, dnsOutput, tcpOutput)
                If alerts.Count > 0 Then
                    Dim alertFile = Path.Combine(folderPath, "Network_Alerts_" & timestamp & ".txt")
                    File.WriteAllLines(alertFile, alerts)
                    VolatileMod.AppendToCsv(folderPath, alertFile)
                    rtbLog.AppendText("⚠ Suspicious network activity detected!" & Environment.NewLine)
                Else
                    rtbLog.AppendText("✔ No obvious suspicious activity" & Environment.NewLine)
                End If
            End If
            ' User
            If chk_VLoginUser.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting User Session Info..." & Environment.NewLine)
                ' ================= BASIC IDENTITY =================
                Dim whoami = Await VolatileMod.RunCommandAsync("whoami")
                ' ================= FULL IDENTITY =================
                Dim whoamiAll = Await VolatileMod.RunCommandAsync("whoami /all")
                ' ================= ACTIVE SESSIONS =================
                Dim sessions = Await VolatileMod.RunCommandAsync("query user")
                ' ================= ENVIRONMENT VARIABLES =================
                Dim env = Await VolatileMod.RunCommandAsync("set")
                ' ================= USER ACCOUNT INFO =================
                Dim userInfo = Await VolatileMod.RunCommandAsync("wmic useraccount where name='%username%' get sid,status")
                ' ================= COMBINE OUTPUT =================
                Dim output As String =
                "================ WHOAMI ================" & Environment.NewLine &
                whoami & Environment.NewLine &
                Environment.NewLine &
                "================ WHOAMI /ALL ================" & Environment.NewLine &
                whoamiAll & Environment.NewLine &
                Environment.NewLine &
                "================ ACTIVE SESSIONS ================" & Environment.NewLine &
                sessions & Environment.NewLine &
                Environment.NewLine &
                "================ ENVIRONMENT VARIABLES ================" & Environment.NewLine &
                env & Environment.NewLine &
                Environment.NewLine &
                "================ USER ACCOUNT INFO ================" & Environment.NewLine &
                userInfo
                ' ================= SAVE =================
                Dim filePath = Path.Combine(folderPath, "User_Session_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Login User details saved" & Environment.NewLine)
            End If
            ' Open File and Shared
            If chk_VOpenFile.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Open Files & Shares..." & Environment.NewLine)
                ' Get shared folders
                Dim shareOutput = Await VolatileMod.RunCommandAsync("net share")
                ' Get open shared files
                Dim fileOutput = Await VolatileMod.RunCommandAsync("net file")
                ' Combine output
                Dim output As String =
                "=== NET SHARE (Shared Folders) ===" & Environment.NewLine &
                shareOutput & Environment.NewLine &
                "=== NET FILE (Open Network Files) ===" & Environment.NewLine &
                fileOutput

                Dim filePath = Path.Combine(folderPath, "OpenFiles_Shared_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Open Files & Shares saved" & Environment.NewLine)
            End If
            ' System Info
            If chk_VSystemInfo.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting System Information..." & Environment.NewLine)
                ' ================= SYSTEM INFO =================
                Dim sysInfo = Await VolatileMod.RunCommandAsync("systeminfo")
                ' ================= BIOS SERIAL =================
                Dim biosSerial = Await VolatileMod.RunCommandAsync("wmic bios get serialnumber")
                ' ================= COMPUTER MODEL =================
                Dim csProduct = Await VolatileMod.RunCommandAsync("wmic csproduct get name")
                ' ================= PATCH / HOTFIX LIST =================
                Dim hotfixList = Await VolatileMod.RunCommandAsync("wmic qfe list full")
                ' ================= COMBINE OUTPUT =================
                Dim output As String =
                "================ SYSTEM INFO ================" & Environment.NewLine &
                sysInfo & Environment.NewLine &
                Environment.NewLine &
                "================ BIOS SERIAL ================" & Environment.NewLine &
                biosSerial & Environment.NewLine &
                Environment.NewLine &
                "================ COMPUTER MODEL ==============" & Environment.NewLine &
                csProduct & Environment.NewLine &
                Environment.NewLine &
                "================ HOTFIX / PATCHES ============" & Environment.NewLine &
                hotfixList
                ' ================= SAVE FILE =================
                Dim filePath = Path.Combine(folderPath, "System_Information_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ System Information saved" & Environment.NewLine)
            End If
            ' Scheduled Tasks (Persistence Check)
            If chk_VSchedTask.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting..." & Environment.NewLine)
                Dim output = Await VolatileMod.RunCommandAsync("schtasks /query /fo LIST /v")
                Dim filePath = Path.Combine(folderPath, "Schedule_Task_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                ' ================= ANALYZE ================
                Dim alerts = TaskAnalyzer.Analyze(output)
                If alerts.Count > 0 Then
                    Dim alertFile = Path.Combine(folderPath, "Schedule_Task_Alerts_" & timestamp & ".txt")
                    File.WriteAllLines(alertFile, alerts)
                    VolatileMod.AppendToCsv(folderPath, alertFile)
                    rtbLog.AppendText("⚠ Suspicious scheduled tasks detected!" & Environment.NewLine)
                Else
                    rtbLog.AppendText("✔ No suspicious scheduled tasks" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Scheduled Tasks saved" & Environment.NewLine)
            End If
            ' Services (Possible Malware Persistence)
            If chk_VServices.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting..." & Environment.NewLine)
                Dim output = Await VolatileMod.RunCommandAsync("tasklist /svc")
                Dim filePath = Path.Combine(folderPath, "Services_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                ' ================= ANALYZE =================
                Dim alerts = ServiceAnalyzer.Analyze(output)
                If alerts.Count > 0 Then
                    Dim alertFile = Path.Combine(folderPath, "Service_Alerts_" & timestamp & ".txt")
                    File.WriteAllLines(alertFile, alerts)
                    VolatileMod.AppendToCsv(folderPath, alertFile)
                    rtbLog.AppendText("⚠ Suspicious services detected!" & Environment.NewLine)
                Else
                    rtbLog.AppendText("✔ No suspicious services found" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Services saved" & Environment.NewLine)
            End If
            ' Command History
            If chk_VCommandHistory.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Command History..." & Environment.NewLine)
                ' CMD History
                Dim cmdOutput = Await VolatileMod.RunCommandAsync("doskey /history")
                ' PowerShell History File (BEST SOURCE)
                Dim psHistoryPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                "\Microsoft\Windows\PowerShell\PSReadLine\ConsoleHost_history.txt"
                Dim psOutput As String = ""
                If File.Exists(psHistoryPath) Then
                    psOutput = File.ReadAllText(psHistoryPath)
                Else
                    psOutput = "PowerShell history file not found"
                End If
                ' Combine both
                Dim output As String =
                "=== CMD HISTORY ===" & Environment.NewLine &
                cmdOutput & Environment.NewLine &
                "=== POWERSHELL HISTORY ===" & Environment.NewLine &
                psOutput
                Dim filePath = Path.Combine(folderPath, "CommandHistory_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Command History collected" & Environment.NewLine)
            End If
            ' Registry
            If chk_VRegistry.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Registry Startup Keys..." & Environment.NewLine)
                ' System-wide startup
                Dim hklmRun = Await VolatileMod.RunCommandAsync(
        "reg query HKLM\Software\Microsoft\Windows\CurrentVersion\Run"
    )
                ' User startup
                Dim hkcuRun = Await VolatileMod.RunCommandAsync(
        "reg query HKCU\Software\Microsoft\Windows\CurrentVersion\Run"
    )
                ' 32-bit system startup
                Dim wowRun = Await VolatileMod.RunCommandAsync(
        "reg query HKLM\Software\WOW6432Node\Microsoft\Windows\CurrentVersion\Run"
    )
                ' Combine results
                Dim output As String =
        "=== HKLM RUN ===" & Environment.NewLine &
        hklmRun & Environment.NewLine &
        "=== HKCU RUN ===" & Environment.NewLine &
        hkcuRun & Environment.NewLine &
        "=== WOW6432Node RUN ===" & Environment.NewLine &
        wowRun
                Dim filePath = Path.Combine(folderPath, "Registry_RunKeys_" & timestamp & ".txt")
                File.WriteAllText(filePath, output)
                VolatileMod.AppendToCsv(folderPath, filePath)
                ' ================= ANALYZE =================
                Dim alerts = RegistryAnalyzer.Analyze(output)
                If alerts.Count > 0 Then
                    Dim alertFile = Path.Combine(folderPath, "Registry_RunKeys_Alerts_" & timestamp & ".txt")
                    File.WriteAllLines(alertFile, alerts)
                    VolatileMod.AppendToCsv(folderPath, alertFile)
                    rtbLog.AppendText("⚠ Suspicious registry persistence detected!" & Environment.NewLine)
                Else
                    rtbLog.AppendText("✔ Registry startup keys clean" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Registry startup keys saved" & Environment.NewLine)
            End If
            '----------BROWSER HISTORY------------------------------------------------------------
            If chk_BEdge.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Edge history..." & Environment.NewLine)
                BrowserMod.CollectEdge(folderPath, timestamp)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Edge done" & Environment.NewLine)
            End If

            If chk_BChrome.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Chrome history..." & Environment.NewLine)
                BrowserMod.CollectChrome(folderPath, timestamp)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Chrome done" & Environment.NewLine)
            End If

            If chk_BFirefox.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Firefox history..." & Environment.NewLine)
                BrowserMod.CollectFirefox(folderPath, timestamp)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Firefox done" & Environment.NewLine)
            End If
            If chk_BBrave.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Brave history..." & Environment.NewLine)
                BrowserMod.CollectBrave(folderPath, timestamp)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Brave done" & Environment.NewLine)
            End If

            If chk_BOpera.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Opera history..." & Environment.NewLine)
                BrowserMod.CollectOpera(folderPath, timestamp)
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ Opera done" & Environment.NewLine)
            End If
            '----------SECURITY EVENTS------------------------------------------------------------
            If chk_VSecurityEvent.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Security Events..." & Environment.NewLine)
                Dim eventIds As New List(Of String)

                If chk_E4624.Checked Then eventIds.Add("4624")
                If chk_E4625.Checked Then eventIds.Add("4625")
                If chk_E4672.Checked Then eventIds.Add("4672")
                If chk_E4688.Checked Then eventIds.Add("4688")
                If chk_E4688.Checked Then eventIds.Add("4648")
                If chk_E1102.Checked Then eventIds.Add("1102")

                Dim outputFile As String
                ' ================= FILTER MODE =================
                If eventIds.Count > 0 Then
                    ' Validate textbox input
                    Dim countValue As Integer
                    If Not Integer.TryParse(txt_ECount.Text, countValue) OrElse countValue <= 0 Then
                        countValue = 300
                        txt_ECount.Text = "300"
                    End If
                    ' Build query
                    Dim condition As String = String.Join(" or ", eventIds.Select(Function(id) "EventID=" & id))
                    Dim query As String = "wevtutil qe Security /q:""*[System[(" & condition & ")]]"" /f:text /c:" & countValue
                    Dim output = Await VolatileMod.RunCommandAsync(query)
                    outputFile = Path.Combine(folderPath, "Security_Filtered_" & timestamp & ".txt")
                    File.WriteAllText(outputFile, output)
                    rtbLog.AppendText("✔ Filtered Security Events saved" & Environment.NewLine)
                Else
                    ' fallback full export
                    outputFile = Path.Combine(folderPath, "Security_Full_" & timestamp & ".evtx")
                    Dim cmd As String = "wevtutil epl Security """ & outputFile & """"
                    Await VolatileMod.RunCommandAsync(cmd)
                    rtbLog.AppendText("✔ Full Security log saved" & Environment.NewLine)
                End If
                VolatileMod.AppendToCsv(folderPath, outputFile)
                progress += 1
                pbStatus.Value = progress
            End If
            'Application Events
            If chk_VAppEvent.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Application Events..." & Environment.NewLine)
                Dim outputFile As String = Path.Combine(folderPath, "Application_" & timestamp & ".evtx")
                Try
                    Dim cmd As String = "wevtutil epl Application """ & outputFile & """"
                    Await VolatileMod.RunCommandAsync(cmd)
                    rtbLog.AppendText("✔ Application log exported" & Environment.NewLine)
                    VolatileMod.AppendToCsv(folderPath, outputFile)
                Catch ex As Exception
                    rtbLog.AppendText("❌ Failed to export Application log: " & ex.Message & Environment.NewLine)
                End Try
                progress += 1
                pbStatus.Value = progress
            End If
            'System Events
            If chk_VSystemEvent.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting System Events..." & Environment.NewLine)
                Dim outputFile As String = Path.Combine(folderPath, "System_" & timestamp & ".evtx")
                Try
                    ' Export System log
                    Dim cmd As String = "wevtutil epl System """ & outputFile & """"
                    Await VolatileMod.RunCommandAsync(cmd)
                    rtbLog.AppendText("✔ System log exported (wevtutil)" & Environment.NewLine)
                    VolatileMod.AppendToCsv(folderPath, outputFile)
                Catch ex As Exception
                    rtbLog.AppendText("❌ Failed to export System log: " & ex.Message & Environment.NewLine)
                End Try
                progress += 1
                pbStatus.Value = progress
            End If
            '------------------------OTHERS----------------------------------------------------------
            If chk_HostFile.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting hosts file..." & Environment.NewLine)
                Dim hostsPath As String = "C:\Windows\System32\drivers\etc\hosts"
                Dim destPath As String = Path.Combine(folderPath, "hosts_" & timestamp & ".txt")
                Try
                    If File.Exists(hostsPath) Then
                        ' Copy hosts file
                        File.Copy(hostsPath, destPath, True)
                        VolatileMod.AppendToCsv(folderPath, destPath)
                        ' 🔥 OPTIONAL: Analyze content
                        Dim content As String = File.ReadAllText(hostsPath)
                        Dim suspiciousLines As New List(Of String)
                        For Each line In content.Split(Environment.NewLine)
                            Dim trimmed = line.Trim()

                            ' Skip comments and empty lines
                            If trimmed <> "" AndAlso Not trimmed.StartsWith("#") Then
                                suspiciousLines.Add(trimmed)
                            End If
                        Next
                        ' Save suspicious entries (if any)
                        If suspiciousLines.Count > 0 Then
                            Dim alertFile = Path.Combine(folderPath, "hosts_suspicious_" & timestamp & ".txt")
                            File.WriteAllLines(alertFile, suspiciousLines)

                            rtbLog.AppendText("⚠ Suspicious hosts entries found!" & Environment.NewLine)

                            VolatileMod.AppendToCsv(folderPath, alertFile)
                        End If
                        rtbLog.AppendText("✔ Hosts file saved" & Environment.NewLine)
                    Else
                        rtbLog.AppendText("⚠ Hosts file not found" & Environment.NewLine)
                    End If
                Catch ex As Exception
                    rtbLog.AppendText("❌ Error copying hosts file: " & ex.Message & Environment.NewLine)
                End Try
                progress += 1
                pbStatus.Value = progress
            End If


            If chk_FileDownloads.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Downloads info..." & Environment.NewLine)
                Dim downloadsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                If Directory.Exists(downloadsPath) Then
                    Dim reportPath = Path.Combine(folderPath, "Downloads_Report_" & timestamp & ".csv")
                    Dim lines As New List(Of String)
                    lines.Add("FileName,DateCreated,DateModified,Size(Bytes),Type,FromInternet")
                    For Each f In Directory.GetFiles(downloadsPath)
                        Dim fi As New FileInfo(f)
                        Dim fileName As String = fi.Name
                        Dim dateCreated As String = fi.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")
                        Dim dateModified As String = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
                        Dim size As Long = fi.Length
                        Dim type As String = fi.Extension
                        ' 🔥 Check Zone.Identifier (downloaded from internet)
                        Dim zoneFlag As String = "No"
                        Dim zoneFile As String = f & ":Zone.Identifier"
                        If File.Exists(zoneFile) Then
                            zoneFlag = "Yes"
                        End If
                        lines.Add(fileName & "," & dateCreated & "," & dateModified & "," & size & "," & type & "," & zoneFlag)
                    Next
                    File.WriteAllLines(reportPath, lines)
                    VolatileMod.AppendToCsv(folderPath, reportPath)
                    rtbLog.AppendText("✔ Downloads report saved" & Environment.NewLine)
                Else
                    rtbLog.AppendText("⚠ Downloads folder not found" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress
            End If
            If chk_FilePrefetch.Checked Then
                Dim srcDir As String = "C:\Windows\Prefetch"
                If Directory.Exists(srcDir) Then
                    Dim destDir = Path.Combine(folderPath, "Prefetch_" & timestamp)
                    Directory.CreateDirectory(destDir)
                    Dim reportPath = Path.Combine(folderPath, "Prefetch_Report_" & timestamp & ".csv")
                    ' CSV Header
                    Dim lines As New List(Of String)
                    lines.Add("FileName,DateModified,Size(Bytes),Type")
                    For Each f In Directory.GetFiles(srcDir)
                        ' Copy file
                        Dim dest = Path.Combine(destDir, Path.GetFileName(f))
                        File.Copy(f, dest, True)
                        ' Get file info
                        Dim fi As New FileInfo(f)
                        Dim fileName As String = fi.Name
                        Dim dateModified As String = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
                        Dim size As Long = fi.Length
                        Dim type As String = fi.Extension
                        ' Add to CSV
                        lines.Add(fileName & "," & dateModified & "," & size & "," & type)
                    Next
                    ' Save CSV report
                    File.WriteAllLines(reportPath, lines)
                    VolatileMod.AppendToCsv(folderPath, reportPath)
                    rtbLog.AppendText("✔ Prefetch files + report saved" & Environment.NewLine)
                Else
                    rtbLog.AppendText("⚠ Prefetch folder not found" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress

            End If
            'USB History
            If chk_USB_History.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting USB history..." & Environment.NewLine)
                ' ================= USBSTOR =================
                Dim usbStor = Await VolatileMod.RunCommandAsync(
                "reg query ""HKLM\SYSTEM\CurrentControlSet\Enum\USBSTOR"" /s"
    )
                Dim usbStorPath = Path.Combine(folderPath, "USB_" & timestamp & ".txt")
                File.WriteAllText(usbStorPath, usbStor)
                VolatileMod.AppendToCsv(folderPath, usbStorPath)
                ' ================= MOUNTED DEVICES =================
                Dim mounted = Await VolatileMod.RunCommandAsync(
                "reg query ""HKLM\SYSTEM\MountedDevices"""
    )
                Dim mountedPath = Path.Combine(folderPath, "MountedDevices_" & timestamp & ".txt")
                File.WriteAllText(mountedPath, mounted)
                VolatileMod.AppendToCsv(folderPath, mountedPath)
                ' ================= PARSE USBSTOR =================
                Dim parsedUSB = USBAnalyzer.ParseUSBStor(usbStor)
                If parsedUSB.Count > 0 Then
                    Dim parsedFile = Path.Combine(folderPath, "USB_Parsed_" & timestamp & ".txt")
                    File.WriteAllLines(parsedFile, parsedUSB)
                    VolatileMod.AppendToCsv(folderPath, parsedFile)
                    rtbLog.AppendText("✔ USB devices parsed successfully" & Environment.NewLine)
                    ' ================= ALERTS =================
                    Dim usbAlerts = USBAnalyzer.DetectUSBAlerts(parsedUSB)
                    If usbAlerts.Count > 0 Then
                        Dim alertFile = Path.Combine(folderPath, "USB_Advanced_Alerts_" & timestamp & ".txt")
                        File.WriteAllLines(alertFile, usbAlerts)
                        VolatileMod.AppendToCsv(folderPath, alertFile)
                        rtbLog.AppendText("⚠ Suspicious USB patterns detected!" & Environment.NewLine)
                    Else
                        rtbLog.AppendText("✔ USB devices look normal" & Environment.NewLine)
                    End If
                Else
                    rtbLog.AppendText("⚠ No USB devices parsed" & Environment.NewLine)
                End If
                ' ================= SIMPLE ANALYSIS =================
                Dim alerts As New List(Of String)
                If usbStor.ToLower().Contains("vid_") AndAlso usbStor.ToLower().Contains("pid_") Then
                    alerts.Add("USB devices detected in USBSTOR registry.")
                End If
                If mounted.ToLower().Contains("\dosdevices\") Then
                    alerts.Add("Mounted drive mappings found (possible external drives).")
                End If
                If alerts.Count > 0 Then
                    Dim alertFile = Path.Combine(folderPath, "USB_Alerts_" & timestamp & ".txt")
                    File.WriteAllLines(alertFile, alerts)
                    VolatileMod.AppendToCsv(folderPath, alertFile)
                    rtbLog.AppendText("⚠ USB activity detected!" & Environment.NewLine)
                Else
                    rtbLog.AppendText("✔ No unusual USB activity" & Environment.NewLine)
                End If
                progress += 1
                pbStatus.Value = progress
                rtbLog.AppendText("✔ USB history saved" & Environment.NewLine)
            End If
            'Email Activity
            If chk_EmailActivity.Checked Then
                rtbLog.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] Collecting Email Activity..." & Environment.NewLine)
                Dim browserHistoryOutput As String = ""
                Dim filePath = Await EmailMod.CollectAllEmailActivity(browserHistoryOutput, folderPath, timestamp)
                VolatileMod.AppendToCsv(folderPath, filePath)
                rtbLog.AppendText("✔ Email activity report saved" & Environment.NewLine)
                progress += 1
                pbStatus.Value = progress
            End If
            '----------------------------------------------------------------------------------------
            rtbLog.AppendText("✅ Collection complete!" & Environment.NewLine)
            btnStart.Enabled = True
            pbStatus.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chk_BFirefox As CheckBox
    Friend WithEvents chk_BChrome As CheckBox
    Friend WithEvents chk_BEdge As CheckBox
    Friend WithEvents chk_BOpera As CheckBox
    Friend WithEvents chk_BBrave As CheckBox
    Friend WithEvents chk_VSecurityEvent As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents chk_E1102 As CheckBox
    Friend WithEvents chk_E4688 As CheckBox
    Friend WithEvents chk_E4625 As CheckBox
    Friend WithEvents chk_E4672 As CheckBox
    Friend WithEvents chk_E4624 As CheckBox
    Friend WithEvents txt_ECount As TextBox
    Friend WithEvents Label3 As Label

    Private Sub txt_ECount_TextChanged(sender As Object, e As EventArgs) Handles txt_ECount.TextChanged
        Dim value As Integer
        If Not Integer.TryParse(txt_ECount.Text, value) Then
            If txt_ECount.Text <> "" Then
                txt_ECount.Text = "300"
                txt_ECount.SelectionStart = txt_ECount.Text.Length
            End If
        End If
    End Sub

    Friend WithEvents chk_E4648 As CheckBox
    Friend WithEvents chk_VSystemEvent As CheckBox
    Friend WithEvents chk_VAppEvent As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents chk_FileDownloads As CheckBox
    Friend WithEvents chk_HostFile As CheckBox
    Friend WithEvents chk_FilePrefetch As CheckBox
    Friend WithEvents chk_USB_History As CheckBox
    Friend WithEvents chk_EmailActivity As CheckBox
    Friend WithEvents btnUnCheckAll As Button
    Friend WithEvents btnCheckAll As Button
    Private Sub CheckAllControls(parent As Control, state As Boolean)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = state
            End If
            If ctrl.HasChildren Then
                CheckAllControls(ctrl, state)
            End If
        Next
    End Sub
    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        For Each ctrl As Control In Me.Controls
            CheckAllControls(ctrl, True)
        Next
    End Sub
    Private Sub btnUnCheckAll_Click(sender As Object, e As EventArgs) Handles btnUnCheckAll.Click
        For Each ctrl As Control In Me.Controls
            CheckAllControls(ctrl, False)
        Next
    End Sub

End Class
