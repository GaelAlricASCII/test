Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "cc"
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim DialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.No) Then
            e.Cancel = True
        End If

    End Sub
End Class
