Public Class frmExposición
    Private Sub frmExposición_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = Numero
    End Sub

    Private Sub frmVolver_Click(sender As Object, e As EventArgs) Handles frmVolver.Click
        frmBingo.Show()
        Me.Close()
    End Sub
End Class