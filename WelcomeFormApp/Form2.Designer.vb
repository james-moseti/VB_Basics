<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSampleText = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTahoma = New System.Windows.Forms.RadioButton()
        Me.rbMagneto = New System.Windows.Forms.RadioButton()
        Me.rbGaramond = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkBoldItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.loadPictureTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.exitAppTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(766, 616)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 67)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadImage
        '
        Me.btnLoadImage.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadImage.Location = New System.Drawing.Point(58, 616)
        Me.btnLoadImage.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(265, 84)
        Me.btnLoadImage.TabIndex = 3
        Me.btnLoadImage.Text = "Load Picture"
        Me.btnLoadImage.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLoadImage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 87)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Object Demonstrations"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(36, 265)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(367, 304)
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'txtSampleText
        '
        Me.txtSampleText.Location = New System.Drawing.Point(8, 45)
        Me.txtSampleText.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSampleText.Name = "txtSampleText"
        Me.txtSampleText.Size = New System.Drawing.Size(255, 28)
        Me.txtSampleText.TabIndex = 6
        Me.txtSampleText.Text = "Sample Text"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSampleText)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(304, 109)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display Test"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTahoma)
        Me.GroupBox2.Controls.Add(Me.rbMagneto)
        Me.GroupBox2.Controls.Add(Me.rbGaramond)
        Me.GroupBox2.Location = New System.Drawing.Point(473, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 98)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font"
        '
        'rbTahoma
        '
        Me.rbTahoma.AutoSize = True
        Me.rbTahoma.Location = New System.Drawing.Point(348, 39)
        Me.rbTahoma.Name = "rbTahoma"
        Me.rbTahoma.Size = New System.Drawing.Size(97, 26)
        Me.rbTahoma.TabIndex = 2
        Me.rbTahoma.TabStop = True
        Me.rbTahoma.Text = "Tahoma"
        Me.rbTahoma.UseVisualStyleBackColor = True
        '
        'rbMagneto
        '
        Me.rbMagneto.AutoSize = True
        Me.rbMagneto.Location = New System.Drawing.Point(184, 39)
        Me.rbMagneto.Name = "rbMagneto"
        Me.rbMagneto.Size = New System.Drawing.Size(100, 26)
        Me.rbMagneto.TabIndex = 1
        Me.rbMagneto.TabStop = True
        Me.rbMagneto.Text = "Magneto"
        Me.rbMagneto.UseVisualStyleBackColor = True
        '
        'rbGaramond
        '
        Me.rbGaramond.AutoSize = True
        Me.rbGaramond.Location = New System.Drawing.Point(15, 39)
        Me.rbGaramond.Name = "rbGaramond"
        Me.rbGaramond.Size = New System.Drawing.Size(115, 26)
        Me.rbGaramond.TabIndex = 0
        Me.rbGaramond.TabStop = True
        Me.rbGaramond.Text = "Garamond"
        Me.rbGaramond.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkBoldItalic)
        Me.GroupBox3.Controls.Add(Me.chkBold)
        Me.GroupBox3.Controls.Add(Me.chkItalic)
        Me.GroupBox3.Location = New System.Drawing.Point(454, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 302)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Style"
        '
        'chkBoldItalic
        '
        Me.chkBoldItalic.AutoSize = True
        Me.chkBoldItalic.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoldItalic.Location = New System.Drawing.Point(56, 212)
        Me.chkBoldItalic.Name = "chkBoldItalic"
        Me.chkBoldItalic.Size = New System.Drawing.Size(111, 25)
        Me.chkBoldItalic.TabIndex = 2
        Me.chkBoldItalic.Text = "Bold Italic"
        Me.chkBoldItalic.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.Location = New System.Drawing.Point(56, 142)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(68, 24)
        Me.chkBold.TabIndex = 1
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalic.Location = New System.Drawing.Point(56, 70)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(68, 26)
        Me.chkItalic.TabIndex = 0
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbRed)
        Me.GroupBox4.Controls.Add(Me.rbBlue)
        Me.GroupBox4.Controls.Add(Me.rbGreen)
        Me.GroupBox4.Location = New System.Drawing.Point(766, 275)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 293)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Font Color"
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(55, 203)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(64, 26)
        Me.rbRed.TabIndex = 2
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(55, 133)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(67, 26)
        Me.rbBlue.TabIndex = 1
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(51, 60)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(81, 26)
        Me.rbGreen.TabIndex = 0
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 758)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLoadImage)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnLoadImage As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pictureBox1 As PictureBox
    Friend WithEvents txtSampleText As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbGaramond As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbTahoma As RadioButton
    Friend WithEvents rbMagneto As RadioButton
    Friend WithEvents chkBoldItalic As CheckBox
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents loadPictureTooltip As ToolTip
    Friend WithEvents exitAppTooltip As ToolTip
End Class
