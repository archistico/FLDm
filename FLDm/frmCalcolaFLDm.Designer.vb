<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcolaFLDm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalcolaFLDm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFFB_alfa1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbVetro = New System.Windows.Forms.ComboBox()
        Me.TrasparenzaVetroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FLDmDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FLDmDS = New LuxArchistico.FLDmDS()
        Me.TrasparenzaVetroTableAdapter = New LuxArchistico.FLDmDSTableAdapters.TrasparenzaVetroTableAdapter()
        Me.tbFFA_alfa2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbFFB_H = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbFFB_hh = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbFFB_La = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbFFA_L = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbFFA_H = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbPsi = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.tbSpav = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cbRifPav = New System.Windows.Forms.ComboBox()
        Me.MaterialeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FLDmDS1 = New LuxArchistico.FLDmDS()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.MaterialeTableAdapter = New LuxArchistico.FLDmDSTableAdapters.MaterialeTableAdapter()
        Me.cbPulizia = New System.Windows.Forms.ComboBox()
        Me.PuliziaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuliziaTableAdapter = New LuxArchistico.FLDmDSTableAdapters.PuliziaTableAdapter()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cbRifPar = New System.Windows.Forms.ComboBox()
        Me.MaterialeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.tbSpar = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbRifSoff = New System.Windows.Forms.ComboBox()
        Me.MaterialeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.tbSsoff = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btCalcola = New System.Windows.Forms.Button()
        Me.cbDestinazione = New System.Windows.Forms.ComboBox()
        Me.DestinazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label48 = New System.Windows.Forms.Label()
        Me.DestinazioneTableAdapter = New LuxArchistico.FLDmDSTableAdapters.DestinazioneTableAdapter()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lbFLDm = New System.Windows.Forms.Label()
        Me.lbVerifica = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.chFFB = New System.Windows.Forms.CheckBox()
        Me.chFFA = New System.Windows.Forms.CheckBox()
        Me.chFR = New System.Windows.Forms.CheckBox()
        Me.btHelpFFB = New System.Windows.Forms.Button()
        Me.btHelpFFA = New System.Windows.Forms.Button()
        Me.btHelpPSI = New System.Windows.Forms.Button()
        Me.btRegistra = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbP = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbHf = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbLF = New System.Windows.Forms.TextBox()
        Me.lbVerificaSup = New System.Windows.Forms.Label()
        CType(Me.TrasparenzaVetroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLDmDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLDmDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLDmDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuliziaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area della superficie finestrata al netto del telaio"
        '
        'tbAf
        '
        Me.tbAf.ForeColor = System.Drawing.Color.Black
        Me.tbAf.Location = New System.Drawing.Point(54, 82)
        Me.tbAf.Name = "tbAf"
        Me.tbAf.Size = New System.Drawing.Size(228, 20)
        Me.tbAf.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(288, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "[mq]"
        '
        'tbFFB_alfa1
        '
        Me.tbFFB_alfa1.ForeColor = System.Drawing.Color.Black
        Me.tbFFB_alfa1.Location = New System.Drawing.Point(54, 133)
        Me.tbFFB_alfa1.Name = "tbFFB_alfa1"
        Me.tbFFB_alfa1.Size = New System.Drawing.Size(68, 20)
        Me.tbFFB_alfa1.TabIndex = 3
        Me.tbFFB_alfa1.Text = "15"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(425, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fattore finestra - ostruzioni di occupano la parte bassa della volta celeste"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Af"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(47, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(785, 35)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CALCOLO DEL FATTORE MEDIO DI LUCE DIURNA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(372, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(450, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tipologia del vetro per determinare il fattore di trasmissione luminosa del vetro" & _
    ""
        '
        'cbVetro
        '
        Me.cbVetro.DataSource = Me.TrasparenzaVetroBindingSource
        Me.cbVetro.DisplayMember = "TipologiaVetro"
        Me.cbVetro.ForeColor = System.Drawing.Color.Black
        Me.cbVetro.FormattingEnabled = True
        Me.cbVetro.Location = New System.Drawing.Point(372, 81)
        Me.cbVetro.Name = "cbVetro"
        Me.cbVetro.Size = New System.Drawing.Size(453, 21)
        Me.cbVetro.TabIndex = 2
        Me.cbVetro.ValueMember = "Trasparenza"
        '
        'TrasparenzaVetroBindingSource
        '
        Me.TrasparenzaVetroBindingSource.DataMember = "TrasparenzaVetro"
        Me.TrasparenzaVetroBindingSource.DataSource = Me.FLDmDSBindingSource
        '
        'FLDmDSBindingSource
        '
        Me.FLDmDSBindingSource.DataSource = Me.FLDmDS
        Me.FLDmDSBindingSource.Position = 0
        '
        'FLDmDS
        '
        Me.FLDmDS.DataSetName = "FLDmDS"
        Me.FLDmDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrasparenzaVetroTableAdapter
        '
        Me.TrasparenzaVetroTableAdapter.ClearBeforeFill = True
        '
        'tbFFA_alfa2
        '
        Me.tbFFA_alfa2.ForeColor = System.Drawing.Color.Black
        Me.tbFFA_alfa2.Location = New System.Drawing.Point(54, 178)
        Me.tbFFA_alfa2.Name = "tbFFA_alfa2"
        Me.tbFFA_alfa2.Size = New System.Drawing.Size(68, 20)
        Me.tbFFA_alfa2.TabIndex = 4
        Me.tbFFA_alfa2.Text = "90"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(51, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(413, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Fattore finestra - ostruzioni di occupano la parte alta della volta celeste"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(28, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "α1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(28, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "α2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(133, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "[angolo in gradi]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(133, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "[angolo in gradi]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(478, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "H"
        '
        'tbFFB_H
        '
        Me.tbFFB_H.Enabled = False
        Me.tbFFB_H.ForeColor = System.Drawing.Color.Black
        Me.tbFFB_H.Location = New System.Drawing.Point(501, 133)
        Me.tbFFB_H.Name = "tbFFB_H"
        Me.tbFFB_H.Size = New System.Drawing.Size(50, 20)
        Me.tbFFB_H.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(557, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "[m]"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(684, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "[m]"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(607, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "h"
        '
        'tbFFB_hh
        '
        Me.tbFFB_hh.Enabled = False
        Me.tbFFB_hh.ForeColor = System.Drawing.Color.Black
        Me.tbFFB_hh.Location = New System.Drawing.Point(628, 133)
        Me.tbFFB_hh.Name = "tbFFB_hh"
        Me.tbFFB_hh.Size = New System.Drawing.Size(50, 20)
        Me.tbFFB_hh.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(801, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "[m]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(724, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "La"
        '
        'tbFFB_La
        '
        Me.tbFFB_La.Enabled = False
        Me.tbFFB_La.ForeColor = System.Drawing.Color.Black
        Me.tbFFB_La.Location = New System.Drawing.Point(745, 133)
        Me.tbFFB_La.Name = "tbFFB_La"
        Me.tbFFB_La.Size = New System.Drawing.Size(50, 20)
        Me.tbFFB_La.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(684, 181)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "[m]"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(607, 181)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "L"
        '
        'tbFFA_L
        '
        Me.tbFFA_L.Enabled = False
        Me.tbFFA_L.ForeColor = System.Drawing.Color.Black
        Me.tbFFA_L.Location = New System.Drawing.Point(628, 178)
        Me.tbFFA_L.Name = "tbFFA_L"
        Me.tbFFA_L.Size = New System.Drawing.Size(50, 20)
        Me.tbFFA_L.TabIndex = 22
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(557, 181)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "[m]"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(478, 181)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "H"
        '
        'tbFFA_H
        '
        Me.tbFFA_H.Enabled = False
        Me.tbFFA_H.ForeColor = System.Drawing.Color.Black
        Me.tbFFA_H.Location = New System.Drawing.Point(501, 178)
        Me.tbFFA_H.Name = "tbFFA_H"
        Me.tbFFA_H.Size = New System.Drawing.Size(50, 20)
        Me.tbFFA_H.TabIndex = 21
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(51, 206)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(356, 13)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Fattore riduttivo dato dalla profondità di incasso della finestra"
        '
        'tbPsi
        '
        Me.tbPsi.ForeColor = System.Drawing.Color.Black
        Me.tbPsi.Location = New System.Drawing.Point(54, 223)
        Me.tbPsi.Name = "tbPsi"
        Me.tbPsi.Size = New System.Drawing.Size(68, 20)
        Me.tbPsi.TabIndex = 5
        Me.tbPsi.Text = "0.95"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(28, 226)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(15, 13)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "ψ"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(133, 226)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 13)
        Me.Label29.TabIndex = 41
        Me.Label29.Text = "[-]"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(28, 270)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 13)
        Me.Label34.TabIndex = 50
        Me.Label34.Text = "T'"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(51, 251)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(262, 13)
        Me.Label35.TabIndex = 48
        Me.Label35.Text = "Correzione per condizione di pulizia del vetro"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(17, 327)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(32, 13)
        Me.Label36.TabIndex = 55
        Me.Label36.Text = "Spav"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(129, 327)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(27, 13)
        Me.Label37.TabIndex = 54
        Me.Label37.Text = "[mq]"
        '
        'tbSpav
        '
        Me.tbSpav.ForeColor = System.Drawing.Color.Black
        Me.tbSpav.Location = New System.Drawing.Point(54, 324)
        Me.tbSpav.Name = "tbSpav"
        Me.tbSpav.Size = New System.Drawing.Size(68, 20)
        Me.tbSpav.TabIndex = 7
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(51, 308)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(116, 13)
        Me.Label38.TabIndex = 52
        Me.Label38.Text = "Area del pavimento"
        '
        'cbRifPav
        '
        Me.cbRifPav.DataSource = Me.MaterialeBindingSource
        Me.cbRifPav.DisplayMember = "Materiale"
        Me.cbRifPav.ForeColor = System.Drawing.Color.Black
        Me.cbRifPav.FormattingEnabled = True
        Me.cbRifPav.Location = New System.Drawing.Point(184, 324)
        Me.cbRifPav.Name = "cbRifPav"
        Me.cbRifPav.Size = New System.Drawing.Size(641, 21)
        Me.cbRifPav.TabIndex = 8
        Me.cbRifPav.ValueMember = "Coefficiente"
        '
        'MaterialeBindingSource
        '
        Me.MaterialeBindingSource.DataMember = "Materiale"
        Me.MaterialeBindingSource.DataSource = Me.FLDmDS1
        '
        'FLDmDS1
        '
        Me.FLDmDS1.DataSetName = "FLDmDS"
        Me.FLDmDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(181, 308)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(233, 13)
        Me.Label39.TabIndex = 57
        Me.Label39.Text = "Coefficiente di riflessione del pavimento"
        '
        'MaterialeTableAdapter
        '
        Me.MaterialeTableAdapter.ClearBeforeFill = True
        '
        'cbPulizia
        '
        Me.cbPulizia.DataSource = Me.PuliziaBindingSource
        Me.cbPulizia.DisplayMember = "Condizione"
        Me.cbPulizia.ForeColor = System.Drawing.Color.Black
        Me.cbPulizia.FormattingEnabled = True
        Me.cbPulizia.Location = New System.Drawing.Point(54, 270)
        Me.cbPulizia.Name = "cbPulizia"
        Me.cbPulizia.Size = New System.Drawing.Size(771, 21)
        Me.cbPulizia.TabIndex = 6
        Me.cbPulizia.ValueMember = "Coefficiente"
        '
        'PuliziaBindingSource
        '
        Me.PuliziaBindingSource.DataMember = "Pulizia"
        Me.PuliziaBindingSource.DataSource = Me.FLDmDS1
        '
        'PuliziaTableAdapter
        '
        Me.PuliziaTableAdapter.ClearBeforeFill = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(181, 352)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(217, 13)
        Me.Label40.TabIndex = 64
        Me.Label40.Text = "Coefficiente di riflessione delle pareti"
        '
        'cbRifPar
        '
        Me.cbRifPar.DataSource = Me.MaterialeBindingSource1
        Me.cbRifPar.DisplayMember = "Materiale"
        Me.cbRifPar.ForeColor = System.Drawing.Color.Black
        Me.cbRifPar.FormattingEnabled = True
        Me.cbRifPar.Location = New System.Drawing.Point(184, 368)
        Me.cbRifPar.Name = "cbRifPar"
        Me.cbRifPar.Size = New System.Drawing.Size(641, 21)
        Me.cbRifPar.TabIndex = 10
        Me.cbRifPar.ValueMember = "Coefficiente"
        '
        'MaterialeBindingSource1
        '
        Me.MaterialeBindingSource1.DataMember = "Materiale"
        Me.MaterialeBindingSource1.DataSource = Me.FLDmDS1
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(17, 371)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(29, 13)
        Me.Label41.TabIndex = 62
        Me.Label41.Text = "Spar"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(129, 371)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(27, 13)
        Me.Label42.TabIndex = 61
        Me.Label42.Text = "[mq]"
        '
        'tbSpar
        '
        Me.tbSpar.ForeColor = System.Drawing.Color.Black
        Me.tbSpar.Location = New System.Drawing.Point(54, 368)
        Me.tbSpar.Name = "tbSpar"
        Me.tbSpar.Size = New System.Drawing.Size(68, 20)
        Me.tbSpar.TabIndex = 9
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(51, 352)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 13)
        Me.Label43.TabIndex = 59
        Me.Label43.Text = "Area delle pareti"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(181, 398)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(214, 13)
        Me.Label44.TabIndex = 70
        Me.Label44.Text = "Coefficiente di riflessione del soffitto"
        '
        'cbRifSoff
        '
        Me.cbRifSoff.DataSource = Me.MaterialeBindingSource2
        Me.cbRifSoff.DisplayMember = "Materiale"
        Me.cbRifSoff.ForeColor = System.Drawing.Color.Black
        Me.cbRifSoff.FormattingEnabled = True
        Me.cbRifSoff.Location = New System.Drawing.Point(184, 414)
        Me.cbRifSoff.Name = "cbRifSoff"
        Me.cbRifSoff.Size = New System.Drawing.Size(641, 21)
        Me.cbRifSoff.TabIndex = 12
        Me.cbRifSoff.ValueMember = "Coefficiente"
        '
        'MaterialeBindingSource2
        '
        Me.MaterialeBindingSource2.DataMember = "Materiale"
        Me.MaterialeBindingSource2.DataSource = Me.FLDmDS1
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(17, 417)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(31, 13)
        Me.Label45.TabIndex = 68
        Me.Label45.Text = "Ssoff"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(129, 417)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(27, 13)
        Me.Label46.TabIndex = 67
        Me.Label46.Text = "[mq]"
        '
        'tbSsoff
        '
        Me.tbSsoff.ForeColor = System.Drawing.Color.Black
        Me.tbSsoff.Location = New System.Drawing.Point(54, 414)
        Me.tbSsoff.Name = "tbSsoff"
        Me.tbSsoff.Size = New System.Drawing.Size(68, 20)
        Me.tbSsoff.TabIndex = 11
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(51, 398)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(97, 13)
        Me.Label47.TabIndex = 65
        Me.Label47.Text = "Area del soffitto"
        '
        'btCalcola
        '
        Me.btCalcola.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btCalcola.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalcola.ForeColor = System.Drawing.Color.White
        Me.btCalcola.Location = New System.Drawing.Point(54, 513)
        Me.btCalcola.Name = "btCalcola"
        Me.btCalcola.Size = New System.Drawing.Size(147, 115)
        Me.btCalcola.TabIndex = 14
        Me.btCalcola.Text = "CALCOLA"
        Me.btCalcola.UseVisualStyleBackColor = False
        '
        'cbDestinazione
        '
        Me.cbDestinazione.DataSource = Me.DestinazioneBindingSource
        Me.cbDestinazione.DisplayMember = "Destinazione"
        Me.cbDestinazione.ForeColor = System.Drawing.Color.Black
        Me.cbDestinazione.FormattingEnabled = True
        Me.cbDestinazione.Location = New System.Drawing.Point(54, 475)
        Me.cbDestinazione.Name = "cbDestinazione"
        Me.cbDestinazione.Size = New System.Drawing.Size(771, 21)
        Me.cbDestinazione.TabIndex = 13
        Me.cbDestinazione.ValueMember = "Riferimento"
        '
        'DestinazioneBindingSource
        '
        Me.DestinazioneBindingSource.DataMember = "Destinazione"
        Me.DestinazioneBindingSource.DataSource = Me.FLDmDS1
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(51, 456)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(114, 13)
        Me.Label48.TabIndex = 72
        Me.Label48.Text = "Tipologia ambiente"
        '
        'DestinazioneTableAdapter
        '
        Me.DestinazioneTableAdapter.ClearBeforeFill = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(401, 519)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(77, 13)
        Me.Label49.TabIndex = 74
        Me.Label49.Text = "RISULTATO"
        '
        'lbFLDm
        '
        Me.lbFLDm.AutoSize = True
        Me.lbFLDm.BackColor = System.Drawing.Color.Transparent
        Me.lbFLDm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFLDm.ForeColor = System.Drawing.Color.Black
        Me.lbFLDm.Location = New System.Drawing.Point(399, 539)
        Me.lbFLDm.Name = "lbFLDm"
        Me.lbFLDm.Size = New System.Drawing.Size(31, 29)
        Me.lbFLDm.TabIndex = 75
        Me.lbFLDm.Text = "--"
        '
        'lbVerifica
        '
        Me.lbVerifica.AutoSize = True
        Me.lbVerifica.BackColor = System.Drawing.Color.Transparent
        Me.lbVerifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVerifica.ForeColor = System.Drawing.Color.Black
        Me.lbVerifica.Location = New System.Drawing.Point(526, 539)
        Me.lbVerifica.Name = "lbVerifica"
        Me.lbVerifica.Size = New System.Drawing.Size(31, 29)
        Me.lbVerifica.TabIndex = 77
        Me.lbVerifica.Text = "--"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(528, 519)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(63, 13)
        Me.Label51.TabIndex = 76
        Me.Label51.Text = "VERIFICA"
        '
        'chFFB
        '
        Me.chFFB.AutoSize = True
        Me.chFFB.BackColor = System.Drawing.Color.Transparent
        Me.chFFB.ForeColor = System.Drawing.Color.Black
        Me.chFFB.Location = New System.Drawing.Point(258, 131)
        Me.chFFB.Name = "chFFB"
        Me.chFFB.Size = New System.Drawing.Size(61, 17)
        Me.chFFB.TabIndex = 15
        Me.chFFB.Text = "Calcola"
        Me.chFFB.UseVisualStyleBackColor = False
        '
        'chFFA
        '
        Me.chFFA.AutoSize = True
        Me.chFFA.BackColor = System.Drawing.Color.Transparent
        Me.chFFA.ForeColor = System.Drawing.Color.Black
        Me.chFFA.Location = New System.Drawing.Point(258, 178)
        Me.chFFA.Name = "chFFA"
        Me.chFFA.Size = New System.Drawing.Size(61, 17)
        Me.chFFA.TabIndex = 16
        Me.chFFA.Text = "Calcola"
        Me.chFFA.UseVisualStyleBackColor = False
        '
        'chFR
        '
        Me.chFR.AutoSize = True
        Me.chFR.BackColor = System.Drawing.Color.Transparent
        Me.chFR.ForeColor = System.Drawing.Color.Black
        Me.chFR.Location = New System.Drawing.Point(258, 223)
        Me.chFR.Name = "chFR"
        Me.chFR.Size = New System.Drawing.Size(102, 17)
        Me.chFR.TabIndex = 17
        Me.chFR.Text = "Valori da grafico"
        Me.chFR.UseVisualStyleBackColor = False
        '
        'btHelpFFB
        '
        Me.btHelpFFB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btHelpFFB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHelpFFB.ForeColor = System.Drawing.Color.White
        Me.btHelpFFB.Location = New System.Drawing.Point(843, 125)
        Me.btHelpFFB.Name = "btHelpFFB"
        Me.btHelpFFB.Size = New System.Drawing.Size(35, 35)
        Me.btHelpFFB.TabIndex = 81
        Me.btHelpFFB.Text = "?"
        Me.btHelpFFB.UseVisualStyleBackColor = False
        '
        'btHelpFFA
        '
        Me.btHelpFFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btHelpFFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHelpFFA.ForeColor = System.Drawing.Color.White
        Me.btHelpFFA.Location = New System.Drawing.Point(843, 170)
        Me.btHelpFFA.Name = "btHelpFFA"
        Me.btHelpFFA.Size = New System.Drawing.Size(35, 35)
        Me.btHelpFFA.TabIndex = 82
        Me.btHelpFFA.Text = "?"
        Me.btHelpFFA.UseVisualStyleBackColor = False
        '
        'btHelpPSI
        '
        Me.btHelpPSI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btHelpPSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHelpPSI.ForeColor = System.Drawing.Color.White
        Me.btHelpPSI.Location = New System.Drawing.Point(745, 215)
        Me.btHelpPSI.Name = "btHelpPSI"
        Me.btHelpPSI.Size = New System.Drawing.Size(133, 35)
        Me.btHelpPSI.TabIndex = 83
        Me.btHelpPSI.Text = "Grafico"
        Me.btHelpPSI.UseVisualStyleBackColor = False
        '
        'btRegistra
        '
        Me.btRegistra.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btRegistra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistra.ForeColor = System.Drawing.Color.White
        Me.btRegistra.Location = New System.Drawing.Point(207, 513)
        Me.btRegistra.Name = "btRegistra"
        Me.btRegistra.Size = New System.Drawing.Size(153, 115)
        Me.btRegistra.TabIndex = 84
        Me.btRegistra.Text = "ESPORTA IMMAGINE"
        Me.btRegistra.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(684, 226)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(21, 13)
        Me.Label32.TabIndex = 93
        Me.Label32.Text = "[m]"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(607, 226)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 13)
        Me.Label33.TabIndex = 92
        Me.Label33.Text = "p"
        '
        'tbP
        '
        Me.tbP.Enabled = False
        Me.tbP.ForeColor = System.Drawing.Color.Black
        Me.tbP.Location = New System.Drawing.Point(628, 223)
        Me.tbP.Name = "tbP"
        Me.tbP.Size = New System.Drawing.Size(50, 20)
        Me.tbP.TabIndex = 87
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(557, 226)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(21, 13)
        Me.Label30.TabIndex = 91
        Me.Label30.Text = "[m]"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(475, 226)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(18, 13)
        Me.Label31.TabIndex = 90
        Me.Label31.Text = "Hf"
        '
        'tbHf
        '
        Me.tbHf.Enabled = False
        Me.tbHf.ForeColor = System.Drawing.Color.Black
        Me.tbHf.Location = New System.Drawing.Point(501, 223)
        Me.tbHf.Name = "tbHf"
        Me.tbHf.Size = New System.Drawing.Size(50, 20)
        Me.tbHf.TabIndex = 86
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(440, 226)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 13)
        Me.Label25.TabIndex = 89
        Me.Label25.Text = "[m]"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(361, 226)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 13)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "Lf"
        '
        'tbLF
        '
        Me.tbLF.Enabled = False
        Me.tbLF.ForeColor = System.Drawing.Color.Black
        Me.tbLF.Location = New System.Drawing.Point(384, 223)
        Me.tbLF.Name = "tbLF"
        Me.tbLF.Size = New System.Drawing.Size(50, 20)
        Me.tbLF.TabIndex = 85
        '
        'lbVerificaSup
        '
        Me.lbVerificaSup.AutoSize = True
        Me.lbVerificaSup.BackColor = System.Drawing.Color.Transparent
        Me.lbVerificaSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVerificaSup.ForeColor = System.Drawing.Color.Black
        Me.lbVerificaSup.Location = New System.Drawing.Point(526, 573)
        Me.lbVerificaSup.Name = "lbVerificaSup"
        Me.lbVerificaSup.Size = New System.Drawing.Size(21, 20)
        Me.lbVerificaSup.TabIndex = 94
        Me.lbVerificaSup.Text = "--"
        '
        'frmCalcolaFLDm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(884, 647)
        Me.Controls.Add(Me.lbVerificaSup)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.tbP)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.tbHf)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.tbLF)
        Me.Controls.Add(Me.btRegistra)
        Me.Controls.Add(Me.btHelpPSI)
        Me.Controls.Add(Me.btHelpFFA)
        Me.Controls.Add(Me.btHelpFFB)
        Me.Controls.Add(Me.chFR)
        Me.Controls.Add(Me.chFFA)
        Me.Controls.Add(Me.chFFB)
        Me.Controls.Add(Me.lbVerifica)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.lbFLDm)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.cbDestinazione)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.btCalcola)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.cbRifSoff)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.tbSsoff)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.cbRifPar)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.tbSpar)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.cbPulizia)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cbRifPav)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.tbSpav)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.tbPsi)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbFFA_L)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.tbFFA_H)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbFFB_La)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbFFB_hh)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbFFB_H)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbFFA_alfa2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbVetro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbFFB_alfa1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAf)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCalcolaFLDm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Calcola FLDm - STUDIO ARCHISTICO DI ROLLANDIN EMILIE"
        CType(Me.TrasparenzaVetroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLDmDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLDmDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLDmDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuliziaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAf As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbFFB_alfa1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbVetro As System.Windows.Forms.ComboBox
    Friend WithEvents FLDmDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FLDmDS As LuxArchistico.FLDmDS
    Friend WithEvents TrasparenzaVetroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrasparenzaVetroTableAdapter As LuxArchistico.FLDmDSTableAdapters.TrasparenzaVetroTableAdapter
    Friend WithEvents tbFFA_alfa2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbFFB_H As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbFFB_hh As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbFFB_La As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbFFA_L As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tbFFA_H As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tbPsi As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents tbSpav As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cbRifPav As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents FLDmDS1 As LuxArchistico.FLDmDS
    Friend WithEvents MaterialeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialeTableAdapter As LuxArchistico.FLDmDSTableAdapters.MaterialeTableAdapter
    Friend WithEvents cbPulizia As System.Windows.Forms.ComboBox
    Friend WithEvents PuliziaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PuliziaTableAdapter As LuxArchistico.FLDmDSTableAdapters.PuliziaTableAdapter
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cbRifPar As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents tbSpar As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cbRifSoff As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents tbSsoff As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents btCalcola As System.Windows.Forms.Button
    Friend WithEvents MaterialeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialeBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents cbDestinazione As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents DestinazioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinazioneTableAdapter As LuxArchistico.FLDmDSTableAdapters.DestinazioneTableAdapter
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents lbFLDm As System.Windows.Forms.Label
    Friend WithEvents lbVerifica As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents chFFB As System.Windows.Forms.CheckBox
    Friend WithEvents chFFA As System.Windows.Forms.CheckBox
    Friend WithEvents chFR As System.Windows.Forms.CheckBox
    Friend WithEvents btHelpFFB As System.Windows.Forms.Button
    Friend WithEvents btHelpFFA As System.Windows.Forms.Button
    Friend WithEvents btHelpPSI As System.Windows.Forms.Button
    Friend WithEvents btRegistra As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents tbP As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tbHf As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tbLF As System.Windows.Forms.TextBox
    Friend WithEvents lbVerificaSup As System.Windows.Forms.Label
End Class
