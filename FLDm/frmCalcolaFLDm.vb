Imports System.IO
'Imports iTextSharp.text.pdf
'Imports iTextSharp.text
Imports System
Imports System.Drawing.Imaging

Public Class frmCalcolaFLDm
    Public calcoloOK As Boolean = False

    Private Sub frmCalcolaFLDm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FLDmDS1.Destinazione'. È possibile spostarla o rimuoverla se necessario.
        Me.DestinazioneTableAdapter.Fill(Me.FLDmDS1.Destinazione)
        'TODO: questa riga di codice carica i dati nella tabella 'FLDmDS1.Pulizia'. È possibile spostarla o rimuoverla se necessario.
        Me.PuliziaTableAdapter.Fill(Me.FLDmDS1.Pulizia)
        'TODO: questa riga di codice carica i dati nella tabella 'FLDmDS1.Materiale'. È possibile spostarla o rimuoverla se necessario.
        Me.MaterialeTableAdapter.Fill(Me.FLDmDS1.Materiale)
        'TODO: questa riga di codice carica i dati nella tabella 'FLDmDS.TrasparenzaVetro'. È possibile spostarla o rimuoverla se necessario.
        Me.TrasparenzaVetroTableAdapter.Fill(Me.FLDmDS.TrasparenzaVetro)

    End Sub

    Private Sub calcola()

        '--------------------------------------------------------
        '-----------------PREPARO I DATI------------------------
        '--------------------------------------------------------
        calcoloOK = False

        '------ Af - Area finestrata -----------
        Dim Af As Double
        If Double.TryParse(tbAf.Text.Replace(".", ","), Af) Then
            'OK
        Else
            'Errore
            MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbAf.Focus()
            Exit Sub
        End If

        '------ FFA_alfa2 - Fattore finestra alta -----------
        Dim FFA_alfa2 As Double
        If chFFA.Checked = False Then
            If Double.TryParse(tbFFA_alfa2.Text.Replace(".", ","), FFA_alfa2) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFA_alfa2.Focus()
                Exit Sub
            End If
        Else
            'Se invece devo calcolarlo
            'carico i valori nelle rispettive variabili
            Dim FFA_H, FFA_L As Double
            If Double.TryParse(tbFFA_H.Text.Replace(".", ","), FFA_H) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFA_H.Focus()
                Exit Sub
            End If
            If Double.TryParse(tbFFA_L.Text.Replace(".", ","), FFA_L) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFA_L.Focus()
                Exit Sub
            End If
            FFA_alfa2 = Math.Atan(FFA_H / FFA_L) * 180 / Math.PI
            tbFFA_alfa2.Text = (Math.Round(FFA_alfa2, 2)).ToString
        End If

        '------ FFA_alfa1 - Fattore finestra bassa -----------
        Dim FFB_alfa1 As Double
        If chFFB.Checked = False Then
            If Double.TryParse(tbFFB_alfa1.Text.Replace(".", ","), FFB_alfa1) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFB_alfa1.Focus()
                Exit Sub
            End If
        Else
            'Se invece devo calcolarlo
            'carico i valori nelle rispettive variabili
            '------ FFA_H - Fattore finestra bassa -----------
            Dim FFB_H As Double
            If Double.TryParse(tbFFB_H.Text.Replace(".", ","), FFB_H) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFB_H.Focus()
                Exit Sub
            End If
            '------ FFA_HH - Fattore finestra bassa -----------
            Dim FFB_HH As Double
            If Double.TryParse(tbFFB_hh.Text.Replace(".", ","), FFB_HH) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFB_hh.Focus()
                Exit Sub
            End If
            'Controllo che H sia maggiore di h
            If FFB_H < FFB_HH Then
                MessageBox.Show("H non può essere minore di h", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFB_hh.Focus()
                Exit Sub
            End If
            '------ FFA_La - Fattore finestra bassa -----------
            Dim FFB_La As Double
            If Double.TryParse(tbFFB_La.Text.Replace(".", ","), FFB_La) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbFFB_La.Focus()
                Exit Sub
            End If
            FFB_alfa1 = Math.Atan((FFB_H - FFB_HH) / FFB_La) * 180 / Math.PI
            tbFFB_alfa1.Text = (Math.Round(FFB_alfa1, 2)).ToString
        End If

        '------ PSI - Fattore riduzione incasso finestra -----------
        Dim Psi As Double
        If Double.TryParse(tbPsi.Text.Replace(".", ","), Psi) Then
            'OK
        Else
            'Errore
            MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbPsi.Focus()
            Exit Sub
        End If

        '------ Superfici -----------------------------------------
        Dim Spav As Double
        If Double.TryParse(tbSpav.Text.Replace(".", ","), Spav) Then
            'OK
        Else
            'Errore
            MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbSpav.Focus()
            Exit Sub
        End If
        Dim Spar As Double
        If Double.TryParse(tbSpar.Text.Replace(".", ","), Spar) Then
            'OK
        Else
            'Errore
            MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbSpar.Focus()
            Exit Sub
        End If
        Dim Ssoff As Double
        If Double.TryParse(tbSsoff.Text.Replace(".", ","), Ssoff) Then
            'OK
        Else
            'Errore
            MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbSsoff.Focus()
            Exit Sub
        End If

        '------ Coeff. trasmissione vetro ----------------------
        Dim Tau As Double
        Double.TryParse(cbVetro.SelectedValue, Tau)

        '------ Coeff. Pulizia vetro ---------------------------
        Dim TauPulizia As Double
        Double.TryParse(cbPulizia.SelectedValue, TauPulizia)

        '------ Coeff. trasmissione superfici ------------------
        Dim RoPav As Double
        Double.TryParse(cbRifPav.SelectedValue, RoPav)

        Dim RoPar As Double
        Double.TryParse(cbRifPar.SelectedValue, RoPar)

        Dim RoSoff As Double
        Double.TryParse(cbRifSoff.SelectedValue, RoSoff)

        '--------------------------------------------------------
        '-----------------------CALCOLO -------------------------
        '--------------------------------------------------------

        'Controllo alfa2 e alfa1
        If FFA_alfa2 > FFB_alfa1 Then
            'ok
        Else
            'ERRORE
            MessageBox.Show("Alfa2 non può essere più piccolo di alfa1", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbFFA_alfa2.Focus()
            Exit Sub
        End If
        'Calcola epsilon
        Dim epsilon As Double = 0
        epsilon = (Math.Sin(FFA_alfa2 * (Math.PI / 180)) - Math.Sin(FFB_alfa1 * (Math.PI / 180))) / 2

        Dim Stot As Double = Spav + Spar + Ssoff

        Dim RoM As Double = 0
        RoM = (Spav * RoPav + Spar * RoPar + Ssoff * RoSoff) / Stot

        Dim Risultato As Double = 0
        Risultato = (Af * Tau * TauPulizia * epsilon * Psi) / ((1 - RoM) * Stot)

        lbFLDm.Text = (Math.Round(Risultato * 100, 2)).ToString & "%"
        'FINE DEL CALCOLO

        'VERIFICA
        Dim minimo As Double = cbDestinazione.SelectedValue

        If Risultato >= minimo Then
            lbVerifica.ForeColor = Color.Black
            lbVerifica.Text = "OK  " & (Math.Round(Risultato * 100, 2)).ToString & "% > " & (Math.Round(minimo * 100, 2)).ToString & "%"
        Else
            lbVerifica.ForeColor = Color.Red
            lbVerifica.Text = "NO  " & (Math.Round(Risultato * 100, 2)).ToString & "% < " & (Math.Round(minimo * 100, 2)).ToString & "%"
        End If

        'dim rapIlluminotecnico
        Dim RAI As Double = Spav / 8
        If Af >= RAI Then
            lbVerificaSup.Text = "OK  " & Af.ToString & " mq > " & RAI.ToString & " mq (Af>Spav/8)"
        Else
            lbVerificaSup.Text = "NO  " & Af.ToString & " mq < " & RAI.ToString & " mq (Af<Spav/8)"
        End If

        calcoloOK = True
    End Sub

    Private Sub chFFB_CheckedChanged(sender As Object, e As EventArgs) Handles chFFB.CheckedChanged
        If chFFB.Checked = True Then
            tbFFB_H.Enabled = True
            tbFFB_hh.Enabled = True
            tbFFB_La.Enabled = True
            tbFFB_alfa1.Enabled = False
        End If
        If chFFB.Checked = False Then
            tbFFB_H.Enabled = False
            tbFFB_hh.Enabled = False
            tbFFB_La.Enabled = False
            tbFFB_alfa1.Enabled = True
        End If
    End Sub

    Private Sub chFFA_CheckedChanged(sender As Object, e As EventArgs) Handles chFFA.CheckedChanged
        If chFFA.Checked = True Then
            tbFFA_H.Enabled = True
            tbFFA_L.Enabled = True
            tbFFA_alfa2.Enabled = False
        End If
        If chFFA.Checked = False Then
            tbFFA_H.Enabled = False
            tbFFA_L.Enabled = False
            tbFFA_alfa2.Enabled = True
        End If
    End Sub

    Private Sub chFR_CheckedChanged(sender As Object, e As EventArgs) Handles chFR.CheckedChanged
        If chFR.Checked = True Then
            tbLF.Enabled = True
            tbHf.Enabled = True
            tbP.Enabled = True
            tbPsi.Enabled = True
            GlobaleCheck = True
        End If
        If chFR.Checked = False Then
            tbLF.Enabled = False
            tbHf.Enabled = False
            tbP.Enabled = False
            tbPsi.Enabled = True
            GlobaleCheck = False
        End If
    End Sub


    Private Sub btCalcola_Click(sender As Object, e As EventArgs) Handles btCalcola.Click
        calcola()
        If (chFR.Checked = True) And (GlobalePSI = 0) Then
            MessageBox.Show("Calcolare il valore di ψ cliccando sul tasto GRAFICO", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btHelpFFB_Click(sender As Object, e As EventArgs) Handles btHelpFFB.Click
        Dim frm As New frmHelpFFB
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'OK
        End If
    End Sub

    Private Sub btHelpFFA_Click(sender As Object, e As EventArgs) Handles btHelpFFA.Click
        Dim frm As New frmHelpFFA
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'OK
        End If
    End Sub

    Private Sub btHelpPSI_Click(sender As Object, e As EventArgs) Handles btHelpPSI.Click
        'Controlla che i valori siano inseriti
        If chFR.Checked = True Then
            If Double.TryParse(tbLF.Text.Replace(".", ","), GlobaleLf) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbLF.Focus()
                Exit Sub
            End If
            If Double.TryParse(tbHf.Text.Replace(".", ","), GlobaleHf) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbHf.Focus()
                Exit Sub
            End If
            If Double.TryParse(tbP.Text.Replace(".", ","), Globalep) Then
                'OK
            Else
                'Errore
                MessageBox.Show("Devi inserire un numero", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbP.Focus()
                Exit Sub
            End If
        End If

        Dim frm As New frmHelpPSI
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'OK
            chFR.Checked = False
            tbLF.Enabled = False
            tbHf.Enabled = False
            tbP.Enabled = False
            tbPsi.Enabled = True
            tbPsi.Text = GlobalePSI.ToString
        End If
    End Sub

    Private Sub cattura(ctrl As Control)
        Dim bounds As Rectangle = ctrl.Bounds
        Dim pt As Point = ctrl.PointToScreen(bounds.Location)
        Dim larghezza As Integer = 0
        Dim altezza As Integer = 0
        larghezza = bounds.Width - (bounds.Width - Me.ClientSize.Width)
        altezza = bounds.Height - (bounds.Height - Me.ClientSize.Height)

        Dim bitmap As New Bitmap(larghezza, altezza)
        Using g As Graphics = Graphics.FromImage(bitmap)
            g.CopyFromScreen(New Point(pt.X - ctrl.Location.X, pt.Y - ctrl.Location.Y), Point.Empty, bounds.Size)
        End Using


        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Png Image|*.png"
        saveFileDialog1.Title = "Registra il file dei risultati"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
        End If

    End Sub


    Private Sub btRegistra_Click(sender As Object, e As EventArgs) Handles btRegistra.Click
        calcola()
        If (chFR.Checked = True) And (GlobalePSI = 0) Then
            MessageBox.Show("Calcolare il valore di ψ cliccando sul tasto GRAFICO", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If calcoloOK = True Then
            Me.BackColor = Color.White
            'Nascondo i bottoni prima dell export
            btCalcola.Hide()
            btRegistra.Hide()
            btHelpFFA.Hide()
            btHelpFFB.Hide()
            btHelpPSI.Hide()
            Me.Refresh()
            'Eseguo la cattura
            cattura(Me)
            Me.Refresh()
            'Riattivo i bottoni
            btCalcola.Show()
            btRegistra.Show()
            btHelpFFA.Show()
            btHelpFFB.Show()
            btHelpPSI.Show()
            Me.BackColor = Color.Gainsboro
        End If
    End Sub


End Class