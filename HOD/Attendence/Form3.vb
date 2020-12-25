Imports System.Data.OleDb

Public Class Form3
    Dim conn As New OleDbConnection
    Dim comm As New OleDb.OleDbCommand


    Dim passchange As Integer = 0

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"
        conn.Open()


    End Sub




    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Form1.Show()

        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 0

        If TextBox1.Text.Length < 6 Or TextBox1.Text = "" Then

            MessageBox.Show("Incorrect Roll no ")
            GoTo Check
        End If

        If ComboBox4.Text = "" Then

            MessageBox.Show("Check the 'semester' block ")
            GoTo Check
        End If

        If ComboBox2.Text = "" Then

            MessageBox.Show("Check the 'Absent in' block ")
            GoTo Check
        End If

        If ComboBox1.Text = "" Then

            MessageBox.Show("Check the 'Course' block ")
            GoTo Check
        End If

        GoTo no_error

Check:  i = 1

no_error:

        If i = 0 And TextBox1.Text.Length = 6 Then






            If ComboBox4.Text = "First Sem" Then





                comm.Connection = conn
                comm.CommandText = "Insert into Sem1([Semester],[Course],[Absent_In],[D_Date],[RollNO]) VALUES ('" & Me.ComboBox4.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.TextBox1.Text & "')"
                comm.ExecuteNonQuery()
                MessageBox.Show("Marked Absent !")



            End If


            If ComboBox4.Text = "Second Sem" Then





                comm.Connection = conn
                comm.CommandText = "Insert into Sem2([Semester],[Course],[Absent_In],[D_Date],[RollNO]) VALUES ('" & Me.ComboBox4.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.TextBox1.Text & "')"
                comm.ExecuteNonQuery()
                MessageBox.Show("Marked Absent !")



            End If

            If ComboBox4.Text = "Third sem" Then





                comm.Connection = conn
                comm.CommandText = "Insert into Sem3([Semester],[Course],[Absent_In],[D_Date],[RollNO]) VALUES ('" & Me.ComboBox4.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.TextBox1.Text & "')"
                comm.ExecuteNonQuery()
                MessageBox.Show("Marked Absent !")



            End If

            If ComboBox4.Text = "Fourth Sem" Then





                comm.Connection = conn
                comm.CommandText = "Insert into Sem4([Semester],[Course],[Absent_In],[D_Date],[RollNO]) VALUES ('" & Me.ComboBox4.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.TextBox1.Text & "')"
                comm.ExecuteNonQuery()
                MessageBox.Show("Marked Absent !")



            End If

            If ComboBox4.Text = "Fifth Sem" Then





                comm.Connection = conn
                comm.CommandText = "Insert into Sem5([Semester],[Course],[Absent_In],[D_Date],[RollNO]) VALUES ('" & Me.ComboBox4.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.TextBox1.Text & "')"
                comm.ExecuteNonQuery()
                MessageBox.Show("Marked Absent !")



            End If

            If ComboBox4.Text = "Sixth Sem" Then





                comm.Connection = conn
                comm.CommandText = "Insert into Sem6([Semester],[Course],[Absent_In],[D_Date],[RollNO]) VALUES ('" & Me.ComboBox4.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.TextBox1.Text & "')"
                comm.ExecuteNonQuery()
                MessageBox.Show("Marked Absent !")



            End If














        Else
            MessageBox.Show("All the boxes need to be filled")
        End If











        TextBox1.Text = ""



        Exit Sub
    End Sub




    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        Dim pass As String

        pass = My.Settings.pass_it_is

        If TextBox2 Is pass Then





            MessageBox.Show("New Password cannot be the same !")

            TextBox2.Text = ""

        Else
            MessageBox.Show("Password changed Succesfully")
            Me.Label6.Text = TextBox2.Text


            passchange = 1
        End If

        If passchange = 1 Then



            My.Settings.pass_it_is = TextBox2.Text
            TextBox2.Text = ""

        End If

    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed







    End Sub
End Class