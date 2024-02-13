Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click
        ' Create an OpenFileDialog to allow the user to select an image file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox
            pictureBox1.ImageLocation = openFileDialog.FileName
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default font and color for the sample text
        txtSampleText.Font = New Font("Times New Roman", 12, FontStyle.Regular)
        txtSampleText.ForeColor = Color.Black

        ' Ensure none of the style checkboxes are checked
        chkItalic.Checked = False
        chkBold.Checked = False
        chkBoldItalic.Checked = False
    End Sub

    Private Sub radGaramond_CheckedChanged(sender As Object, e As EventArgs) Handles rbGaramond.CheckedChanged
        txtSampleText.Font = New Font("Garamond", txtSampleText.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub radMagneto_CheckedChanged(sender As Object, e As EventArgs) Handles rbMagneto.CheckedChanged
        txtSampleText.Font = New Font("Magneto", txtSampleText.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub radTahoma_CheckedChanged(sender As Object, e As EventArgs) Handles rbTahoma.CheckedChanged
        txtSampleText.Font = New Font("Tahoma", txtSampleText.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub chkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkItalic.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub chkBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoldItalic.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged
        txtSampleText.ForeColor = Color.Green
    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlue.CheckedChanged
        txtSampleText.ForeColor = Color.Blue
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbRed.CheckedChanged
        txtSampleText.ForeColor = Color.Red
    End Sub

    Private Sub UpdateFontStyle()
        Dim style As FontStyle = FontStyle.Regular

        If chkItalic.Checked Then
            style = style Or FontStyle.Italic
        End If

        If chkBold.Checked Then
            style = style Or FontStyle.Bold
        End If

        If chkBoldItalic.Checked Then
            style = style Or FontStyle.Bold Or FontStyle.Italic
        End If

        txtSampleText.Font = New Font(txtSampleText.Font.FontFamily, txtSampleText.Font.Size, style)
    End Sub

    Private Sub btnLoadImage_MouseHover(sender As Object, e As EventArgs) Handles btnLoadImage.MouseHover
        loadPictureTooltip.SetToolTip(btnLoadImage, "Load a picture from the hard disk")
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        exitAppTooltip.SetToolTip(btnExit, "Unload the form back to the welcoming form")
    End Sub
End Class