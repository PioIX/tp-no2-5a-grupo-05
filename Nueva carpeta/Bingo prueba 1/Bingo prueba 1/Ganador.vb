Public Class frmGanador
    Dim a As Integer
    Private Sub frmGanador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 800
        a = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 1
        Select Case a
            Case 0
                picOriginal.Image = picUno.Image
            Case 1
                picOriginal.Image = picDos.Image
            Case 2
                picOriginal.Image = picTres.Image
            Case 3
                picOriginal.Image = picCuatro.Image
            Case 4
                picOriginal.Image = picCinco.Image
            Case 5
                picOriginal.Image = picSeis.Image
        End Select
        If a = 5 Then
            a = 0
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmBingo.Show()
    End Sub
End Class