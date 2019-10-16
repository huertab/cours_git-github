<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IU_main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BT_total = New System.Windows.Forms.Button()
        Me.NUD_b = New System.Windows.Forms.NumericUpDown()
        Me.NUD_a = New System.Windows.Forms.NumericUpDown()
        Me.LB_resultat = New System.Windows.Forms.Label()
        Me.LB_a = New System.Windows.Forms.Label()
        Me.LB_b = New System.Windows.Forms.Label()
        CType(Me.NUD_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_total
        '
        Me.BT_total.AutoSize = True
        Me.BT_total.Location = New System.Drawing.Point(127, 186)
        Me.BT_total.Name = "BT_total"
        Me.BT_total.Size = New System.Drawing.Size(77, 30)
        Me.BT_total.TabIndex = 0
        Me.BT_total.Text = "Somme"
        Me.BT_total.UseVisualStyleBackColor = True
        '
        'NUD_b
        '
        Me.NUD_b.BackColor = System.Drawing.Color.White
        Me.NUD_b.DecimalPlaces = 2
        Me.NUD_b.ForeColor = System.Drawing.Color.Black
        Me.NUD_b.Location = New System.Drawing.Point(171, 77)
        Me.NUD_b.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_b.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NUD_b.Name = "NUD_b"
        Me.NUD_b.Size = New System.Drawing.Size(120, 27)
        Me.NUD_b.TabIndex = 1
        Me.NUD_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NUD_a
        '
        Me.NUD_a.BackColor = System.Drawing.Color.White
        Me.NUD_a.DecimalPlaces = 2
        Me.NUD_a.ForeColor = System.Drawing.Color.Black
        Me.NUD_a.Location = New System.Drawing.Point(26, 77)
        Me.NUD_a.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_a.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NUD_a.Name = "NUD_a"
        Me.NUD_a.Size = New System.Drawing.Size(120, 27)
        Me.NUD_a.TabIndex = 1
        Me.NUD_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LB_resultat
        '
        Me.LB_resultat.AutoSize = True
        Me.LB_resultat.Location = New System.Drawing.Point(62, 137)
        Me.LB_resultat.Name = "LB_resultat"
        Me.LB_resultat.Size = New System.Drawing.Size(65, 20)
        Me.LB_resultat.TabIndex = 2
        Me.LB_resultat.Text = "resultat"
        '
        'LB_a
        '
        Me.LB_a.AutoSize = True
        Me.LB_a.Location = New System.Drawing.Point(22, 54)
        Me.LB_a.Name = "LB_a"
        Me.LB_a.Size = New System.Drawing.Size(20, 20)
        Me.LB_a.TabIndex = 2
        Me.LB_a.Text = "A"
        '
        'LB_b
        '
        Me.LB_b.AutoSize = True
        Me.LB_b.Location = New System.Drawing.Point(167, 54)
        Me.LB_b.Name = "LB_b"
        Me.LB_b.Size = New System.Drawing.Size(21, 20)
        Me.LB_b.TabIndex = 2
        Me.LB_b.Text = "B"
        '
        'IU_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(365, 243)
        Me.Controls.Add(Me.LB_b)
        Me.Controls.Add(Me.LB_a)
        Me.Controls.Add(Me.LB_resultat)
        Me.Controls.Add(Me.NUD_a)
        Me.Controls.Add(Me.NUD_b)
        Me.Controls.Add(Me.BT_total)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(383, 290)
        Me.Name = "IU_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addition"
        CType(Me.NUD_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_total As Button
    Friend WithEvents NUD_b As NumericUpDown
    Friend WithEvents NUD_a As NumericUpDown
    Friend WithEvents LB_resultat As Label
    Friend WithEvents LB_a As Label
    Friend WithEvents LB_b As Label
End Class
