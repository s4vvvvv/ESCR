﻿Public Class Form4
    Public mymain As New Form5
    Public myachievements As New Form6
    Public mysponsors As New Form7
    Public myteamsnplayers As New Form8
    Public myfinance As New Form9
    Public myemployees As New Form10
    Public myexecutives As New Form11



    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Panel1.Controls.Clear()

        myachievements.TopLevel = False
        myachievements.Parent = Panel1
        myachievements.Dock = DockStyle.Fill
        myachievements.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Panel1.Controls.Clear()

        mymain.TopLevel = False
        mymain.Parent = Panel1
        mymain.Dock = DockStyle.Fill
        mymain.Show()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Panel1.Controls.Clear()

        mysponsors.TopLevel = False
        mysponsors.Parent = Panel1
        mysponsors.Dock = DockStyle.Fill
        mysponsors.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Panel1.Controls.Clear()

        myteamsnplayers.TopLevel = False
        myteamsnplayers.Parent = Panel1
        myteamsnplayers.Dock = DockStyle.Fill
        myteamsnplayers.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Panel1.Controls.Clear()

        myfinance.TopLevel = False
        myfinance.Parent = Panel1
        myfinance.Dock = DockStyle.Fill
        myfinance.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Panel1.Controls.Clear()

        myemployees.TopLevel = False
        myemployees.Parent = Panel1
        myemployees.Dock = DockStyle.Fill
        myemployees.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Panel1.Controls.Clear()

        myexecutives.TopLevel = False
        myexecutives.Parent = Panel1
        myexecutives.Dock = DockStyle.Fill
        myexecutives.Show()
    End Sub
End Class