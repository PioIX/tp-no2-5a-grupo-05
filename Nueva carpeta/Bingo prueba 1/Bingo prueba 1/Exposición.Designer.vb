<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExposición
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.frmVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Comic Sans MS", 300.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(-29, -37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(721, 558)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "10"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVolver
        '
        Me.frmVolver.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmVolver.Location = New System.Drawing.Point(162, 437)
        Me.frmVolver.Name = "frmVolver"
        Me.frmVolver.Size = New System.Drawing.Size(276, 109)
        Me.frmVolver.TabIndex = 1
        Me.frmVolver.Text = "Volver"
        Me.frmVolver.UseVisualStyleBackColor = True
        '
        'frmExposición
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 614)
        Me.Controls.Add(Me.frmVolver)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmExposición"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exposición"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents frmVolver As Button
End Class
