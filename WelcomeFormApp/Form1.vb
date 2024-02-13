Public Class Form1
    Private Sub btnDisplayForm_Click(sender As Object, e As EventArgs) Handles btnDisplayForm.Click
        Form2.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial background color (you can choose any color)
        Me.BackColor = Color.White
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        ' When the form is clicked, maximize it
        Me.WindowState = FormWindowState.Maximized

        ' Change the background color to red
        Me.BackColor = Color.Red
    End Sub

    Private Sub btnDisplayForm_MouseHover(sender As Object, e As EventArgs) Handles btnDisplayForm.MouseHover
        ToolTip1.SetToolTip(btnDisplayForm, "Display form 'Object Demonstrations'")
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        ToolTip2.SetToolTip(btnExit, "Exit application")
    End Sub
End Class
