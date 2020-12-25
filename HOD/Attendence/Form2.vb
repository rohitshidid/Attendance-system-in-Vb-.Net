Imports System.Data.OleDb

Public Class form2
    Dim conn As New OleDbConnection
    Dim comm As New OleDb.OleDbCommand



    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"
        conn.Open()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 0

        If TextBox2.Text.Length <= 5 And TextBox2.Text.Length > 0 Then

            MessageBox.Show("Incorrect Roll no ")
            GoTo Check
        End If

        If TextBox3.Text.Length <= 9 And TextBox2.Text.Length > 0 Then

            MessageBox.Show("Incorrect Contact No")
            GoTo Check
        End If



        GoTo no_error

Check:  i = 1

no_error:

        If TextBox4.Text IsNot "" And TextBox3.Text IsNot "" And TextBox2.Text.Length = 6 And TextBox3.Text.Length = 10 And TextBox1.Text IsNot "" And TextBox4.Text IsNot "" And TextBox5.Text IsNot "" And ComboBox1.Text IsNot "" And i < 1 Then


            comm.Connection = conn
            comm.CommandText = "Insert into Registeration ([F_name],[Roll_no],[Semester],[Batch],[Contact_No],[Mail_id]) VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.ComboBox1.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "')"
            comm.ExecuteNonQuery()
            MessageBox.Show("Successfully Registered")


            TextBox3.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.Text = ""


        Else
            MessageBox.Show("CANNOT LEAVE THE BLOCKS INCOMPLETE")
        End If
    End Sub












    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

End Class