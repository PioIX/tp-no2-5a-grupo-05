Public Class frmBingo
    Dim Estado As Single
    Dim btn(90) As Button
    Dim i As Integer

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



        ' Creas el objeto boton
        Dim posicionX = 20, posicionY = 120
        For i = 1 To 90
            btn(i) = New Button()
            Me.Controls.Add(btn(i))
            If posicionX > 1000 Then
                posicionX = 20
                posicionY = posicionY + 75
            End If
            With btn(i)
                .Visible = True
                .Text = i     ' Asignas el texto del objeto
                .Height = 75
                .Width = 100
                .Top = posicionY
                .Left = posicionX
                .Tag = i
            End With
            posicionX = posicionX + 100
            AddHandler btn(i).Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click

        Next
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Numero As Integer = Integer.Parse(sender.tag)
        For i = 1 To 90
            If i <> Numero Then
                btn(i).Visible = False
                Label1.Visible = False

            End If
        Next
        btn(Numero).Top = 0
        btn(Numero).Left = 0
        btn(Numero).Height = Me.Height - 100
        btn(Numero).Width = Me.Width - 300

    End Sub


End Class
