Public Class frmBingo
    Dim Estado As Single
    Dim btn(90) As Button
    Dim i, a As Integer
    Private Delete As Boolean
    Dim posicionX = 20, posicionY = 120
    Dim varError As String

    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1050
        Me.Height = 850
        lblTitulo.Left = Me.Width / 2
        lblTitulo.Left = lblTitulo.Left - lblTitulo.Width / 2
        lblTitulo.Top = 20
        Delete = False
        lblBorrar.Visible = False
        a = 1
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
                .BackColor = Color.White
                .Font = New Font("Verdana", 18)
            End With
            If i < 10 Then
                btn(i).Text = "0" & i
                btn(i).Tag = "0" & i
            End If
            posicionX = posicionX + 100
            AddHandler btn(i).Click, AddressOf Button_Click
            AddHandler btn(i).KeyPress, AddressOf Button_KeyPress
        Next
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        For Y = 1 To 90
            If btn(Y).BackColor = Color.Yellow Then
                btn(Y).BackColor = Color.White
                Label2.Text = varError
            End If
        Next
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Numero = Integer.Parse(sender.tag)

        If Delete = False Then
            frmExposición.Show()
            btn(Numero).BackColor = Color.Yellow
            With Label2
                .Visible = True
                .Top = 150
                .Left = 20
            End With
            varError = Label2.Text
            Label2.Text = Convert.ToString(Numero) + ", " + Label2.Text
            Me.Hide()
        Else
            btn(Numero).BackColor = Color.White
        End If
    End Sub
    Private Sub Button_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar

            Case "l", "L"
                Me.Hide()
                frmLínea.ShowDialog()
            Case "b", "B"
                Me.Hide()
                frmGanador.Show()
            Case "D", "d"
                a = 1 - a
                If a = 0 Then
                    Delete = True
                    lblBorrar.Visible = True
                Else
                    Delete = False
                    lblBorrar.Visible = False
                End If
        End Select
    End Sub
End Class
