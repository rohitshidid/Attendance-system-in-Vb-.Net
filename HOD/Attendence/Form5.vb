Imports System.Data.OleDb
Public Class Form5
    Dim conn As New OleDbConnection
    Dim comm As New OleDb.OleDbCommand

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"
        conn.Open()

    End Sub

    Public Sub RD()
        Dim dt As New DataTable()
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem1 where Semester ='" & ComboBox2.Text & "'", conn)
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Public Sub RD1()
        Dim dt As New DataTable()
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT  distinct [RollNO] , [Semester], [Course]  FROM BSem2 where Semester ='" & ComboBox2.Text & "'", conn)
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Public Sub RD2()
        Dim dt As New DataTable()
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT  distinct [RollNO] , [Semester], [Course]  FROM BSem3 where Semester ='" & ComboBox2.Text & "'", conn)
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Public Sub RD3()
        Dim dt As New DataTable()
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT  distinct [RollNO] , [Semester], [Course]  FROM BSem4 where Semester ='" & ComboBox2.Text & "'", conn)
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Public Sub RD4()
        Dim dt As New DataTable()
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT  distinct [RollNO] , [Semester], [Course]  FROM BSem5 where Semester ='" & ComboBox2.Text & "'", conn)
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Public Sub RD5()
        Dim dt As New DataTable()
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT  distinct [RollNO] , [Semester], [Course] FROM BSem6 where Semester ='" & ComboBox2.Text & "'", conn)
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
        conn.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox2.Text = "First Sem" Then
            comm.Connection = conn
            RD()
        End If
        If ComboBox2.Text = "Second Sem" Then
            comm.Connection = conn
            RD1()
        End If
        If ComboBox2.Text = "Third sem" Then
            comm.Connection = conn
            RD2()
        End If
        If ComboBox2.Text = "Fourth Sem" Then
            comm.Connection = conn
            RD3()
        End If
        If ComboBox2.Text = "Fifth Sem" Then
            comm.Connection = conn
            RD4()
        End If
        If ComboBox2.Text = "Sixth Sem" Then
            comm.Connection = conn
            RD5()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox2.Text = "First Sem" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"

            Dim da As New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem1 where [RollNO] Like'" + TextBox1.Text + "%' order by [RollNO] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt

        End If

        If ComboBox2.Text = "Second Sem" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"

            Dim da As New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem2 where [RollNO] Like'" + TextBox1.Text + "%' order by [RollNO] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt

        End If

        If ComboBox2.Text = "Third sem" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"

            Dim da As New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem3 where [RollNO] Like'" + TextBox1.Text + "%' order by [RollNO] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt

        End If

        If ComboBox2.Text = "Fourth Sem" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"

            Dim da As New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem4 where [RollNO] Like'" + TextBox1.Text + "%' order by [RollNO] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt

        End If


        If ComboBox2.Text = "Fifth Sem" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"

            Dim da As New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem5 where [RollNO] Like'" + TextBox1.Text + "%' order by [RollNO] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt

        End If


        If ComboBox2.Text = "Sixth Sem" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ddbase.accdb"

            Dim da As New OleDbDataAdapter("SELECT distinct [RollNO] , [Semester], [Course]  FROM BSem6 where [RollNO] Like'" + TextBox1.Text + "%' order by [RollNO] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt

        End If



    End Sub
End Class