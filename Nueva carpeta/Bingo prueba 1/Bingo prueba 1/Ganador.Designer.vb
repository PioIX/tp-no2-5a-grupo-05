﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGanador
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGanador))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.picSeis = New System.Windows.Forms.PictureBox()
        Me.picCinco = New System.Windows.Forms.PictureBox()
        Me.picCuatro = New System.Windows.Forms.PictureBox()
        Me.picTres = New System.Windows.Forms.PictureBox()
        Me.picDos = New System.Windows.Forms.PictureBox()
        Me.picOriginal = New System.Windows.Forms.PictureBox()
        Me.picUno = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSeis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCinco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCuatro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(553, 505)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(221, 84)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'picSeis
        '
        Me.picSeis.Image = CType(resources.GetObject("picSeis.Image"), System.Drawing.Image)
        Me.picSeis.Location = New System.Drawing.Point(459, 505)
        Me.picSeis.Name = "picSeis"
        Me.picSeis.Size = New System.Drawing.Size(235, 123)
        Me.picSeis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSeis.TabIndex = 13
        Me.picSeis.TabStop = False
        Me.picSeis.Visible = False
        '
        'picCinco
        '
        Me.picCinco.Image = CType(resources.GetObject("picCinco.Image"), System.Drawing.Image)
        Me.picCinco.Location = New System.Drawing.Point(710, 505)
        Me.picCinco.Name = "picCinco"
        Me.picCinco.Size = New System.Drawing.Size(243, 133)
        Me.picCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCinco.TabIndex = 12
        Me.picCinco.TabStop = False
        Me.picCinco.Visible = False
        '
        'picCuatro
        '
        Me.picCuatro.Image = CType(resources.GetObject("picCuatro.Image"), System.Drawing.Image)
        Me.picCuatro.Location = New System.Drawing.Point(978, 505)
        Me.picCuatro.Name = "picCuatro"
        Me.picCuatro.Size = New System.Drawing.Size(243, 133)
        Me.picCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCuatro.TabIndex = 11
        Me.picCuatro.TabStop = False
        Me.picCuatro.Visible = False
        '
        'picTres
        '
        Me.picTres.Image = CType(resources.GetObject("picTres.Image"), System.Drawing.Image)
        Me.picTres.Location = New System.Drawing.Point(978, 353)
        Me.picTres.Name = "picTres"
        Me.picTres.Size = New System.Drawing.Size(243, 133)
        Me.picTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTres.TabIndex = 10
        Me.picTres.TabStop = False
        Me.picTres.Visible = False
        '
        'picDos
        '
        Me.picDos.Image = CType(resources.GetObject("picDos.Image"), System.Drawing.Image)
        Me.picDos.Location = New System.Drawing.Point(978, 202)
        Me.picDos.Name = "picDos"
        Me.picDos.Size = New System.Drawing.Size(243, 133)
        Me.picDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDos.TabIndex = 9
        Me.picDos.TabStop = False
        Me.picDos.Visible = False
        '
        'picOriginal
        '
        Me.picOriginal.Image = CType(resources.GetObject("picOriginal.Image"), System.Drawing.Image)
        Me.picOriginal.Location = New System.Drawing.Point(32, 50)
        Me.picOriginal.Name = "picOriginal"
        Me.picOriginal.Size = New System.Drawing.Size(1303, 502)
        Me.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOriginal.TabIndex = 8
        Me.picOriginal.TabStop = False
        '
        'picUno
        '
        Me.picUno.Image = CType(resources.GetObject("picUno.Image"), System.Drawing.Image)
        Me.picUno.Location = New System.Drawing.Point(978, 50)
        Me.picUno.Name = "picUno"
        Me.picUno.Size = New System.Drawing.Size(243, 133)
        Me.picUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUno.TabIndex = 15
        Me.picUno.TabStop = False
        Me.picUno.Visible = False
        '
        'Timer1
        '
        '
        'frmGanador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1375, 596)
        Me.Controls.Add(Me.picUno)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.picSeis)
        Me.Controls.Add(Me.picCinco)
        Me.Controls.Add(Me.picCuatro)
        Me.Controls.Add(Me.picTres)
        Me.Controls.Add(Me.picDos)
        Me.Controls.Add(Me.picOriginal)
        Me.Name = "frmGanador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bingo!!"
        CType(Me.picSeis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCinco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCuatro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents picSeis As PictureBox
    Friend WithEvents picCinco As PictureBox
    Friend WithEvents picCuatro As PictureBox
    Friend WithEvents picTres As PictureBox
    Friend WithEvents picDos As PictureBox
    Friend WithEvents picOriginal As PictureBox
    Friend WithEvents picUno As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
