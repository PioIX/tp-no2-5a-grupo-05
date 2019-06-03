Public Class frmBingo
    Dim Estado As Single
    Dim btn(90) As Button
    Dim i As Integer
    Dim posicionX = 20, posicionY = 120

    Private Sub btnBut_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1050
        Me.Height = 850
        Label1.Left = Me.Width / 2
        Label1.Left = Label1.Left - Label1.Width / 2
        Label1.Top = 20
        CreaBotones()
    End Sub
    Private Sub CreaBotones()

        For i = 1 To 90
            btn(i) = New Button()
            Me.Controls.Add(btn(i))
            If posicionX > 1000 Then
                posicionX = 20
                posicionY = posicionY + 75
            End If
            With btn(i)
                .Visible = True
                .Text = i
                .Height = 75
                .Width = 100
                .Top = posicionY
                .Left = posicionX
                .Tag = i
                .Font = New Font("Comic Sans MS", 30)
            End With
            posicionX = posicionX + 100
            AddHandler btn(i).Click, AddressOf Button_Click
        Next
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Numero = Integer.Parse(sender.tag)
        frmExposición.Show()
        btn(Numero).BackColor = Color.Yellow
        Me.Hide()
    End Sub


End Class
