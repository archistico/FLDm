<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiediPSI
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
        Me.btOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPSI = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOK.ForeColor = System.Drawing.Color.White
        Me.btOK.Location = New System.Drawing.Point(12, 87)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(337, 40)
        Me.btOK.TabIndex = 2
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INSERISCI IL VALORE DI ψ"
        '
        'tbPSI
        '
        Me.tbPSI.Location = New System.Drawing.Point(266, 40)
        Me.tbPSI.Name = "tbPSI"
        Me.tbPSI.Size = New System.Drawing.Size(83, 20)
        Me.tbPSI.TabIndex = 1
        '
        'frmChiediPSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 139)
        Me.Controls.Add(Me.tbPSI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btOK)
        Me.Name = "frmChiediPSI"
        Me.Text = "VALORE PSI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPSI As System.Windows.Forms.TextBox
End Class
