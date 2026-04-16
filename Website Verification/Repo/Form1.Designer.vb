<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        dgvResults = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        btn_Checker = New Button()
        Label1 = New Label()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvResults
        ' 
        dgvResults.AllowUserToOrderColumns = True
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvResults.Location = New Point(37, 106)
        dgvResults.Name = "dgvResults"
        dgvResults.RowHeadersWidth = 62
        dgvResults.Size = New Size(1146, 435)
        dgvResults.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.HeaderText = "Domain"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 400
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Date/Time"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Status"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Remarks"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        ' 
        ' btn_Checker
        ' 
        btn_Checker.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Checker.Location = New Point(37, 26)
        btn_Checker.Name = "btn_Checker"
        btn_Checker.Size = New Size(137, 59)
        btn_Checker.TabIndex = 1
        btn_Checker.Text = "RUN"
        btn_Checker.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(985, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 25)
        Label1.TabIndex = 2
        Label1.Text = "Version : JFR-2026.4.13"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1195, 553)
        Controls.Add(Label1)
        Controls.Add(btn_Checker)
        Controls.Add(dgvResults)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Website Verification"
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents btn_Checker As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label

End Class
