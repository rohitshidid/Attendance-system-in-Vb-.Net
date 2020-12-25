Imports System.Data.OleDb
Public Class Form4

    Dim conn As New OleDbConnection
    Dim comm As New OleDb.OleDbCommand

    Private Sub Form4_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"
        conn.Open()
    End Sub

    Public Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim abs As Integer
        Dim pre As Integer
        Dim totabs As Integer

        If TextBox1.Text.Length = 6 Then

            If ComboBox1.Text = "" Or ComboBox4.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then

                GoTo done

            Else





                If ComboBox4.Text = "First Sem" Then
                    comm = New OleDbCommand("SELECT  count(Absent_In)  FROM Sem1 where Course='" & ComboBox1.Text & "'and RollNO =  '" & TextBox1.Text & "'", conn)
                    abs = comm.ExecuteScalar()



                End If


                If ComboBox4.Text = "Second Sem" Then

                    comm = New OleDbCommand("SELECT  count(Absent_In)  FROM Sem2 where Course='" & ComboBox1.Text & "'and RollNO =  '" & TextBox1.Text & "'", conn)
                    abs = comm.ExecuteScalar()


                End If

                If ComboBox4.Text = "Third sem" Then
                    comm = New OleDbCommand("SELECT  count(Absent_In)  FROM Sem3 where Course='" & ComboBox1.Text & "'and RollNO =  '" & TextBox1.Text & "'", conn)
                    abs = comm.ExecuteScalar()


                End If

                If ComboBox4.Text = "Fourth Sem" Then
                    comm = New OleDbCommand("SELECT  count(Absent_In)  FROM Sem4 where Course='" & ComboBox1.Text & "'and RollNO =  '" & TextBox1.Text & "'", conn)
                    abs = comm.ExecuteScalar()


                End If

                If ComboBox4.Text = "Fifth Sem" Then
                    comm = New OleDbCommand("SELECT  count(Absent_In)  FROM Sem5 where Course='" & ComboBox1.Text & "'and RollNO =  '" & TextBox1.Text & "'", conn)
                    abs = comm.ExecuteScalar()



                End If

                If ComboBox4.Text = "Sixth Sem" Then
                    comm = New OleDbCommand("SELECT  count(Absent_In)  FROM Sem6 where Course='" & ComboBox1.Text & "'and RollNO =  '" & TextBox1.Text & "'", conn)
                    abs = comm.ExecuteScalar()


                End If




                Dim C_abs As Integer
                Dim C_pre As Integer

                totabs = Me.TextBox2.Text

                C_abs = (abs * 100) / totabs


                C_pre = 100 - C_abs


                Me.Chart1.Series("Absenty").Points.AddY(C_abs)
                Me.Chart1.Series("Absenty").Points.AddY(C_pre)


                Me.Label7.Text = abs
                Me.Label8.Text = totabs - abs

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  1         ''''''''*******************************



                Dim per As Integer

                per = (totabs * 35) / 100            ' 35 % of total


                If abs >= per Then

                    If ComboBox4.Text = "First Sem" Then
                        comm.Connection = conn
                        comm.CommandText = "Insert into BSem1 (RollNo,Course,Semester) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox4.Text & "')"
                        comm.ExecuteNonQuery()
                        MessageBox.Show("Added to BlackList")


                    ElseIf ComboBox4.Text = "Second Sem" Then
                        comm.Connection = conn
                        comm.CommandText = "Insert into BSem2 (RollNo,Course,Semester) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox4.Text & "')"
                        comm.ExecuteNonQuery()
                        MessageBox.Show("Added to BlackList")


                    ElseIf ComboBox4.Text = "Third sem" Then
                        comm.Connection = conn
                        comm.CommandText = "Insert into BSem3 (RollNo,Course,Semester) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox4.Text & "')"
                        comm.ExecuteNonQuery()
                        MessageBox.Show("Added to BlackList")


                    ElseIf ComboBox4.Text = "Fourth Sem" Then

                        comm.Connection = conn
                        comm.CommandText = "Insert into BSem4 (RollNo,Course,Semester) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox4.Text & "')"
                        comm.ExecuteNonQuery()
                        MessageBox.Show("Added to BlackList")



                    ElseIf ComboBox4.Text = "Fifth Sem" Then
                        comm.Connection = conn
                        comm.CommandText = "Insert into BSem5 (RollNo,Course,Semester) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox4.Text & "')"
                        comm.ExecuteNonQuery()
                        MessageBox.Show("Added to BlackList")


                    ElseIf ComboBox4.Text = "Sixth Sem" Then
                        comm.Connection = conn
                        comm.CommandText = "Insert into BSem6 (RollNo,Course,Semester) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "','" & Me.ComboBox4.Text & "')"
                        comm.ExecuteNonQuery()
                        MessageBox.Show("Added to BlackList")
                    End If

                End If

                GoTo finish

            End If
        Else
            MessageBox.Show("Enter a valid Roll no")

        End If



done:
        MessageBox.Show("You need to fill all the boxes")


finish:



    End Sub

    Private Function From() As Object
        Throw New NotImplementedException
    End Function


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TextBox1.Clear()


        Me.Chart1.Series("Absenty").Points.Clear()
        Me.Chart1.Series("Absenty").Points.Clear()
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub



    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing

        End If
    End Sub
    Public Sub alphabet()



    End Sub

End Class