Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Enabled = True
        TextBox2.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Enabled = True
        TextBox3.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox4.Enabled = True
        TextBox4.Focus()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox5.Enabled = True
        TextBox5.Focus()
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = (Keys.Enter) Then
            TextBox6.Text = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = (Keys.Enter) Then
            TextBox7.Text = Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox3.Text)
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = (Keys.Enter) Then
            TextBox8.Text = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox4.Text)
        End If
    End Sub

    
    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = (Keys.Enter) Then
            TextBox9.Text = Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox5.Text)
        End If
    End Sub
End Class
