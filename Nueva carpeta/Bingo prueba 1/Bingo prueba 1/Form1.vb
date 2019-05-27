Public Class frmBingo
    Private Sub btnBut_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaBotones()
    End Sub
    Private Sub CreaBotones()
        Dim i As Integer
        ' Creas el objeto boton
        Dim posicionX = 20, posicionY = 20
        For i = 0 To 100
            Dim btn As New Button()
            With btn
                .Visible = True
                .Name = "Button" + i  ' Asignas el nombre del objeto
                .Text = i     ' Asignas el texto del objeto
                .Location = New System.Drawing.Point(posicionX, posicionY) ' Asignas la posición del objeto
                .Size = New System.Drawing.Size(90, 80) ' Asignas el tamaño del objeto
            End With
            posicionX = posicionX + 80
            'pepepeppe
            If posicionX >= Me.Width Then
                posicionX = 20
                posicionY = posicionY + 100
            End If


            AddHandler btn.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click

            Me.Controls.Add(btn) ' Agregas el botón al formulario.
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
