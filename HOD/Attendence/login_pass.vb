Public Class login_pass

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()

        Me.Close()
    End Sub



    Private Sub login_pass_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Dim pass As String

        pass = My.Settings.pass_it_is.ToString

        'TextBox1.Text = pass



        If TextBox1.Text = pass Then

            Form3.Show()
            Form3.Label6.Text = pass
        Else


            MessageBox.Show("Password Incorrect !")

            Form1.Show()



        End If


    End Sub
End Class