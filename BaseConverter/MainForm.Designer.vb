<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rad16 = New System.Windows.Forms.RadioButton()
        Me.Rad10 = New System.Windows.Forms.RadioButton()
        Me.Rad8 = New System.Windows.Forms.RadioButton()
        Me.Rad4 = New System.Windows.Forms.RadioButton()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rad16)
        Me.GroupBox1.Controls.Add(Me.Rad10)
        Me.GroupBox1.Controls.Add(Me.Rad8)
        Me.GroupBox1.Controls.Add(Me.Rad4)
        Me.GroupBox1.Location = New System.Drawing.Point(192, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert to"
        '
        'Rad16
        '
        Me.Rad16.AutoSize = True
        Me.Rad16.Location = New System.Drawing.Point(6, 88)
        Me.Rad16.Name = "Rad16"
        Me.Rad16.Size = New System.Drawing.Size(86, 17)
        Me.Rad16.TabIndex = 3
        Me.Rad16.TabStop = True
        Me.Rad16.Text = "Hexadecimal"
        Me.Rad16.UseVisualStyleBackColor = True
        '
        'Rad10
        '
        Me.Rad10.AutoSize = True
        Me.Rad10.Location = New System.Drawing.Point(6, 65)
        Me.Rad10.Name = "Rad10"
        Me.Rad10.Size = New System.Drawing.Size(63, 17)
        Me.Rad10.TabIndex = 2
        Me.Rad10.TabStop = True
        Me.Rad10.Text = "Decimal"
        Me.Rad10.UseVisualStyleBackColor = True
        '
        'Rad8
        '
        Me.Rad8.AutoSize = True
        Me.Rad8.Location = New System.Drawing.Point(6, 42)
        Me.Rad8.Name = "Rad8"
        Me.Rad8.Size = New System.Drawing.Size(50, 17)
        Me.Rad8.TabIndex = 1
        Me.Rad8.TabStop = True
        Me.Rad8.Text = "Octal"
        Me.Rad8.UseVisualStyleBackColor = True
        '
        'Rad4
        '
        Me.Rad4.AutoSize = True
        Me.Rad4.Location = New System.Drawing.Point(6, 19)
        Me.Rad4.Name = "Rad4"
        Me.Rad4.Size = New System.Drawing.Size(77, 17)
        Me.Rad4.TabIndex = 0
        Me.Rad4.TabStop = True
        Me.Rad4.Text = "Quaternary"
        Me.Rad4.UseVisualStyleBackColor = True
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(12, 46)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(174, 20)
        Me.Txt2.TabIndex = 0
        '
        'TxtOut
        '
        Me.TxtOut.Location = New System.Drawing.Point(12, 158)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ReadOnly = True
        Me.TxtOut.Size = New System.Drawing.Size(280, 41)
        Me.TxtOut.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Binary"
        '
        'BtnReset
        '
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnReset.Location = New System.Drawing.Point(30, 129)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 4
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(111, 129)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(75, 23)
        Me.BtnConvert.TabIndex = 2
        Me.BtnConvert.Text = "&Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.BtnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BtnReset
        Me.ClientSize = New System.Drawing.Size(304, 211)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base Converter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents TxtOut As TextBox
    Friend WithEvents Rad16 As RadioButton
    Friend WithEvents Rad10 As RadioButton
    Friend WithEvents Rad8 As RadioButton
    Friend WithEvents Rad4 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnConvert As Button
End Class
