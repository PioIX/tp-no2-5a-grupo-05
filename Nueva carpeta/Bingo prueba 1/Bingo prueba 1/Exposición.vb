Public Class frmExposición
    Private Sub frmExposición_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = Numero
    End Sub

    Private Sub frmVolver_Click(sender As Object, e As EventArgs) Handles frmVolver.Click
        frmBingo.Show()
        Me.Close()
    End Sub

    Private Sub frmVolver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles frmVolver.KeyPress
        MsgBox("Entraste mas que entrin")
    End Sub
End Class