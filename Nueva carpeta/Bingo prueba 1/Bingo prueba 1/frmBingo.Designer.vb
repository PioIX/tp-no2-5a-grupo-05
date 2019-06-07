<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBingo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblBorrar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(136, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(708, 90)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Bingo Salesiano PioIX"
        '
        'lblBorrar
        '
        Me.lblBorrar.AutoSize = True
        Me.lblBorrar.Font = New System.Drawing.Font("Calisto MT", 15.25!)
        Me.lblBorrar.ForeColor = System.Drawing.Color.Red
        Me.lblBorrar.Location = New System.Drawing.Point(7, 25)
        Me.lblBorrar.Name = "lblBorrar"
        Me.lblBorrar.Size = New System.Drawing.Size(135, 48)
        Me.lblBorrar.TabIndex = 1
        Me.lblBorrar.Text = "Modo Borrar: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ano"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(873, 34)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(83, 38)
        Me.btnAtras.TabIndex = 3
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmBingo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 712)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBorrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmBingo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bingo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblBorrar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAtras As Button
End Class
