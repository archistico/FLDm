Public Class frmHelpPSI

    Private Sub btIndietro_Click(sender As Object, e As EventArgs) Handles btIndietro.Click
        If GlobaleCheck = True Then
            'Chiedi il fattore PSI da inserire
            Dim frm As New frmChiediPSI
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'OK
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Exit Sub
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmHelpPSI_Load(sender As Object, e As EventArgs) Handles Me.Load
        If GlobaleCheck = True Then
            'Calcola i due rapporti
            If GlobaleP > 0 Then
                lbRapportoLF.Text = (Math.Round((GlobaleLf / GlobaleP), 2)).ToString
                lbRapportoHf.Text = (Math.Round((GlobaleHf / GlobaleP), 2)).ToString
            End If
        End If
    End Sub
End Class