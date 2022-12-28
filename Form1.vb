Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Show()
        Timer1.Start()
    End Sub
    Private Sub EventTick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = 30
        ProgressBar1.Value = 50
        ProgressBar1.Value = 100
        Label2.Text = "Chargement terminé"
        Timer1.Stop()
        Me.ShowInTaskbar = True
        MsgBox("Chargement des assets terminé !")
        Panel3.Visible = False
        Timer1.Enabled = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Try
            If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                TextBox1.Font = FontDialog1.Font
            Else

            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Try
            SaveFileDialog1.Title = "Enregistré"
            SaveFileDialog1.Filter = "Fichier Text (*.txt)|*.txt"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                TextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.TextTextOleObjs)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try
            OpenFileDialog1.Title = "Ouvrir"
            OpenFileDialog1.Filter = "Fichier Text (*.txt)|*.txt"
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                TextBox1.LoadFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        TextBox1.ForeColor = Color.White
        TextBox1.BackColor = Color.Black
        Button45.Show()
        Button46.Hide()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        TextBox1.ForeColor = Color.Black
        TextBox1.BackColor = Color.White
        Button45.Hide()
        Button46.Show()
    End Sub

    Private Sub ClickPanel1(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        MsgBox("Par OxiWan 2023-2024", MsgBoxStyle.Information, Title:="Information sur le créateur")
    End Sub
End Class
