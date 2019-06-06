Public Class frmHome

    Private Sub btCalcolaFLDm_Click(sender As Object, e As EventArgs) Handles btCalcolaFLDm.Click
        Me.Hide()
        Dim frm As New frmCalcolaFLDm
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'OK
            Me.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btCalcolaAf_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frm As New frmCalcolaAf
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'OK
            Me.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btEsci_Click(sender As Object, e As EventArgs) Handles btEsci.Click
        Me.Close()

    End Sub
End Class
