<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New DevMo.FormSkin()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlatButton7 = New DevMo.FlatButton()
        Me.FlatClose1 = New DevMo.FlatClose()
        Me.FlatMax1 = New DevMo.FlatMax()
        Me.FlatMini1 = New DevMo.FlatMini()
        Me.Button46 = New DevMo.FlatButton()
        Me.Button45 = New DevMo.FlatButton()
        Me.Button2 = New DevMo.FlatButton()
        Me.FlatButton3 = New DevMo.FlatButton()
        Me.Button44 = New DevMo.FlatButton()
        Me.FlatButton1 = New DevMo.FlatButton()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FormSkin1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2500
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Panel3)
        Me.FormSkin1.Controls.Add(Me.FlatButton7)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatMax1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.Button46)
        Me.FormSkin1.Controls.Add(Me.Button45)
        Me.FormSkin1.Controls.Add(Me.Button2)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.Button44)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.TextBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(899, 557)
        Me.FormSkin1.TabIndex = 5
        Me.FormSkin1.Text = "DevMo"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.No
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(899, 557)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.No
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(373, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DevMo"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.No
        Me.ProgressBar1.Location = New System.Drawing.Point(266, 300)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(337, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.No
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label2.Location = New System.Drawing.Point(280, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chargement en cours"
        '
        'FlatButton7
        '
        Me.FlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton7.Location = New System.Drawing.Point(369, 24)
        Me.FlatButton7.Name = "FlatButton7"
        Me.FlatButton7.Rounded = False
        Me.FlatButton7.Size = New System.Drawing.Size(87, 19)
        Me.FlatButton7.TabIndex = 18
        Me.FlatButton7.Text = "Credit"
        Me.FlatButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(875, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 17
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(851, 3)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 16
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(827, 3)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 15
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.Transparent
        Me.Button46.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button46.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button46.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button46.Location = New System.Drawing.Point(360, 2)
        Me.Button46.Name = "Button46"
        Me.Button46.Rounded = False
        Me.Button46.Size = New System.Drawing.Size(87, 19)
        Me.Button46.TabIndex = 14
        Me.Button46.Text = "Claire"
        Me.Button46.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button46.Visible = False
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.Transparent
        Me.Button45.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button45.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button45.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button45.Location = New System.Drawing.Point(361, 2)
        Me.Button45.Name = "Button45"
        Me.Button45.Rounded = False
        Me.Button45.Size = New System.Drawing.Size(87, 19)
        Me.Button45.TabIndex = 13
        Me.Button45.Text = "Sombre"
        Me.Button45.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(276, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Rounded = False
        Me.Button2.Size = New System.Drawing.Size(87, 19)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Couleur"
        Me.Button2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton3.Location = New System.Drawing.Point(268, 3)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(87, 19)
        Me.FlatButton3.TabIndex = 11
        Me.FlatButton3.Text = "Typographie"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.Transparent
        Me.Button44.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Button44.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button44.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button44.Location = New System.Drawing.Point(175, 25)
        Me.Button44.Name = "Button44"
        Me.Button44.Rounded = False
        Me.Button44.Size = New System.Drawing.Size(95, 19)
        Me.Button44.TabIndex = 10
        Me.Button44.Text = "Sauvegarde"
        Me.Button44.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(175, 3)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(87, 19)
        Me.FlatButton1.TabIndex = 9
        Me.FlatButton1.Text = "Ouvrir"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.EnableAutoDragDrop = True
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(899, 508)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Bienvenue !"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 557)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(899, 557)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DevMo"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatMax1 As FlatMax
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents Button46 As FlatButton
    Friend WithEvents Button45 As FlatButton
    Friend WithEvents Button2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents Button44 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
End Class
