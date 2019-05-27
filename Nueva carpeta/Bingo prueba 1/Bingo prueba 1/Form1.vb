Public Class frmBingo
    Private Sub btnBut_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1050
        Me.Height = 750

        CreaBotones()
    End Sub
    Private Sub CreaBotones()
        Dim i As Integer
        Dim btn(90) As Button

        ' Creas el objeto boton
        Dim posicionX = 20, posicionY = 20
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
            End With
            posicionX = posicionX + 100
            'AddHandler btn(i).Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click

        Next
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, System.Windows.Forms.Button).Name
            Case "NombreBoton1"
                ' Accion para el boton 1
            Case "NombreBoton2"
                ' Accion para el boton 2
            Case "NombreBoton3"
                ' Accion para el boton 3
            Case Else
                ' Accion genérica
        End Select
    End Sub
End Class
