Public Class frmExposición
    Private Sub frmExposición_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Numero < 10 Then
            lblName.Text = "0" & Numero
        Else
            lblName.Text = Numero
        End If

    End Sub

    Private Sub frmVolver_Click(sender As Object, e As EventArgs) Handles frmVolver.Click
        frmBingo.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmVolver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles frmVolver.KeyPress
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class