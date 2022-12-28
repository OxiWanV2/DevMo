Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.TextBox1.ForeColor = Color.Red
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.TextBox1.ForeColor = Color.Blue
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.TextBox1.ForeColor = Color.Lime
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.TextBox1.ForeColor = Color.Fuchsia
        Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form1.TextBox1.ForeColor = Color.DarkRed
        Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form1.TextBox1.ForeColor = Color.Maroon
        Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form1.TextBox1.ForeColor = Color.LightCoral
        Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form1.TextBox1.ForeColor = Color.Firebrick
        Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form1.TextBox1.ForeColor = Color.Brown
        Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form1.TextBox1.ForeColor = Color.IndianRed
        Close()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form1.TextBox1.ForeColor = Color.RosyBrown
        Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Form1.TextBox1.ForeColor = Color.MediumBlue
        Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form1.TextBox1.ForeColor = Color.DarkBlue
        Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form1.TextBox1.ForeColor = Color.Navy
        Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form1.TextBox1.ForeColor = Color.SkyBlue
        Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form1.TextBox1.ForeColor = Color.MidnightBlue
        Close()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Form1.TextBox1.ForeColor = Color.RoyalBlue
        Close()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form1.TextBox1.ForeColor = Color.CornflowerBlue
        Close()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Form1.TextBox1.ForeColor = Color.Green
        Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Form1.TextBox1.ForeColor = Color.DarkGreen
        Close()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Form1.TextBox1.ForeColor = Color.PaleGreen
        Close()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Form1.TextBox1.ForeColor = Color.LightGreen
        Close()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Form1.TextBox1.ForeColor = Color.LimeGreen
        Close()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Form1.TextBox1.ForeColor = Color.ForestGreen
        Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Form1.TextBox1.ForeColor = Color.DarkSeaGreen
        Close()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Form1.TextBox1.ForeColor = Color.DarkMagenta
        Close()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Form1.TextBox1.ForeColor = Color.Purple
        Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Form1.TextBox1.ForeColor = Color.Violet
        Close()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Form1.TextBox1.ForeColor = Color.Plum
        Close()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Form1.TextBox1.ForeColor = Color.MediumSlateBlue
        Close()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Form1.TextBox1.ForeColor = Color.MediumOrchid
        Close()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Form1.TextBox1.ForeColor = Color.DarkViolet
        Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.TextBox1.ForeColor = Color.Black
        Close()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Form1.TextBox1.ForeColor = Color.DimGray
        Close()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Form1.TextBox1.ForeColor = Color.Gray
        Close()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Form1.TextBox1.ForeColor = Color.DarkGray
        Close()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Form1.TextBox1.ForeColor = Color.Silver
        Close()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Form1.TextBox1.ForeColor = Color.LightGray
        Close()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Form1.TextBox1.ForeColor = Color.Gainsboro
        Close()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Try
            If ColorDialog1.ShowDialog = DialogResult.OK Then
                Form1.TextBox1.ForeColor = ColorDialog1.Color
                Close()
            Else

            End If

        Catch ex As Exception : End Try
    End Sub
End Class