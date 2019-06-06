<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelpPSI
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbRapportoLF = New System.Windows.Forms.Label()
        Me.lbRapportoHf = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btIndietro = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LuxArchistico.My.Resources.Resources.PSI
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 500)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 529)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "CURVA Lf/p"
        '
        'lbRapportoLF
        '
        Me.lbRapportoLF.AutoSize = True
        Me.lbRapportoLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRapportoLF.Location = New System.Drawing.Point(172, 529)
        Me.lbRapportoLF.Name = "lbRapportoLF"
        Me.lbRapportoLF.Size = New System.Drawing.Size(24, 24)
        Me.lbRapportoLF.TabIndex = 59
        Me.lbRapportoLF.Text = "--"
        '
        'lbRapportoHf
        '
        Me.lbRapportoHf.AutoSize = True
        Me.lbRapportoHf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRapportoHf.Location = New System.Drawing.Point(477, 529)
        Me.lbRapportoHf.Name = "lbRapportoHf"
        Me.lbRapportoHf.Size = New System.Drawing.Size(24, 24)
        Me.lbRapportoHf.TabIndex = 61
        Me.lbRapportoHf.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 529)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 24)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "RAPPORTO Hf/p"
        '
        'btIndietro
        '
        Me.btIndietro.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btIndietro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIndietro.ForeColor = System.Drawing.Color.White
        Me.btIndietro.Location = New System.Drawing.Point(610, 503)
        Me.btIndietro.Name = "btIndietro"
        Me.btIndietro.Size = New System.Drawing.Size(190, 71)
        Me.btIndietro.TabIndex = 62
        Me.btIndietro.Text = "TORNA INDIETRO"
        Me.btIndietro.UseVisualStyleBackColor = False
        '
        'frmHelpPSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 578)
        Me.Controls.Add(Me.btIndietro)
        Me.Controls.Add(Me.lbRapportoHf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbRapportoLF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmHelpPSI"
        Me.Text = "Grafico PSI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbRapportoLF As System.Windows.Forms.Label
    Friend WithEvents lbRapportoHf As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btIndietro As System.Windows.Forms.Button
End Class
