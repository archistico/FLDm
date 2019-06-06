Public Class frmChiediPSI

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        If Double.TryParse(tbPSI.Text.Replace(".", ","), GlobalePSI) Then
            'OK
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        Else
            'Errore
            MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbPSI.Focus()
            Exit Sub
        End If
        'Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class