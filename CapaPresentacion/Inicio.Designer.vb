<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnp2 = New System.Windows.Forms.Button()
        Me.btnp3 = New System.Windows.Forms.Button()
        Me.btnp4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnp2
        '
        Me.btnp2.BackColor = System.Drawing.Color.Orange
        Me.btnp2.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnp2.ForeColor = System.Drawing.Color.White
        Me.btnp2.Location = New System.Drawing.Point(83, 130)
        Me.btnp2.Name = "btnp2"
        Me.btnp2.Size = New System.Drawing.Size(530, 60)
        Me.btnp2.TabIndex = 0
        Me.btnp2.Text = "Mostrar Telefono de un cliente"
        Me.btnp2.UseVisualStyleBackColor = False
        '
        'btnp3
        '
        Me.btnp3.BackColor = System.Drawing.Color.Orange
        Me.btnp3.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnp3.ForeColor = System.Drawing.Color.White
        Me.btnp3.Location = New System.Drawing.Point(81, 215)
        Me.btnp3.Name = "btnp3"
        Me.btnp3.Size = New System.Drawing.Size(530, 60)
        Me.btnp3.TabIndex = 1
        Me.btnp3.Text = "Mostrar Saldo de un cliente"
        Me.btnp3.UseVisualStyleBackColor = False
        '
        'btnp4
        '
        Me.btnp4.BackColor = System.Drawing.Color.Orange
        Me.btnp4.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnp4.ForeColor = System.Drawing.Color.White
        Me.btnp4.Location = New System.Drawing.Point(81, 311)
        Me.btnp4.Name = "btnp4"
        Me.btnp4.Size = New System.Drawing.Size(530, 60)
        Me.btnp4.TabIndex = 2
        Me.btnp4.Text = "Mostrar  Clientes por distrito"
        Me.btnp4.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(692, 491)
        Me.Controls.Add(Me.btnp4)
        Me.Controls.Add(Me.btnp3)
        Me.Controls.Add(Me.btnp2)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnp2 As System.Windows.Forms.Button
    Friend WithEvents btnp3 As System.Windows.Forms.Button
    Friend WithEvents btnp4 As System.Windows.Forms.Button
End Class
