namespace mokkivaraus
{
    partial class Varaukset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpVarattuAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpVarattuLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.tbAsiakasID = new System.Windows.Forms.TextBox();
            this.lblAsiakasID = new System.Windows.Forms.Label();
            this.lblToimipisteID = new System.Windows.Forms.Label();
            this.lblVarattuAlkupvm = new System.Windows.Forms.Label();
            this.lblVarattuLoppupvm = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPaavalikko = new System.Windows.Forms.Button();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkivarausDataSet = new mokkivaraus.mokkivarausDataSet();
            this.varausTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.VarausTableAdapter();
            this.lblVaraukset = new System.Windows.Forms.Label();
            this.lblVarausID = new System.Windows.Forms.Label();
            this.tbVarausID = new System.Windows.Forms.TextBox();
            this.dgvVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varauksenpalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksen_palvelutTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.Varauksen_palvelutTableAdapter();
            this.lblVarauksenPalvelut = new System.Windows.Forms.Label();
            this.lblVahvistuspvm = new System.Windows.Forms.Label();
            this.dtpVahvistuspvm = new System.Windows.Forms.DateTimePicker();
            this.dgvToimipisteenPalvelut = new System.Windows.Forms.DataGridView();
            this.palveluidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimipisteidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVarauksenToimipisteenPalvelut = new System.Windows.Forms.Label();
            this.palveluTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.PalveluTableAdapter();
            this.tcVaraukset = new System.Windows.Forms.TabControl();
            this.tpVaraukset = new System.Windows.Forms.TabPage();
            this.btnValAsiakas = new System.Windows.Forms.Button();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.gbVarauksenTiedot = new System.Windows.Forms.GroupBox();
            this.cbToimipiste = new System.Windows.Forms.ComboBox();
            this.dtpVarattupvm = new System.Windows.Forms.DateTimePicker();
            this.lblVarattupvm = new System.Windows.Forms.Label();
            this.tpVarauksenPalvelut = new System.Windows.Forms.TabPage();
            this.cb_NaytaVaratut = new System.Windows.Forms.CheckBox();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
            this.tb_palvLkmPaivitys = new System.Windows.Forms.TextBox();
            this.lb_palvelunlkm = new System.Windows.Forms.Label();
            this.tb_PalvLkm = new System.Windows.Forms.TextBox();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnHaeVaraus = new System.Windows.Forms.Button();
            this.lblVarausIDpg2 = new System.Windows.Forms.Label();
            this.tbVarausIDpg2 = new System.Windows.Forms.TextBox();
            this.erProvTeksti = new System.Windows.Forms.ErrorProvider(this.components);
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimipisteTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.ToimipisteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimipisteenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.tcVaraukset.SuspendLayout();
            this.tpVaraukset.SuspendLayout();
            this.gbVarauksenTiedot.SuspendLayout();
            this.tpVarauksenPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVarattuAlkupvm
            // 
            this.dtpVarattuAlkupvm.Location = new System.Drawing.Point(374, 42);
            this.dtpVarattuAlkupvm.Name = "dtpVarattuAlkupvm";
            this.dtpVarattuAlkupvm.Size = new System.Drawing.Size(200, 20);
            this.dtpVarattuAlkupvm.TabIndex = 4;
            // 
            // dtpVarattuLoppupvm
            // 
            this.dtpVarattuLoppupvm.Location = new System.Drawing.Point(374, 68);
            this.dtpVarattuLoppupvm.Name = "dtpVarattuLoppupvm";
            this.dtpVarattuLoppupvm.Size = new System.Drawing.Size(200, 20);
            this.dtpVarattuLoppupvm.TabIndex = 5;
            // 
            // tbAsiakasID
            // 
            this.tbAsiakasID.Location = new System.Drawing.Point(88, 45);
            this.tbAsiakasID.Name = "tbAsiakasID";
            this.tbAsiakasID.Size = new System.Drawing.Size(100, 20);
            this.tbAsiakasID.TabIndex = 1;
            this.tbAsiakasID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // lblAsiakasID
            // 
            this.lblAsiakasID.AutoSize = true;
            this.lblAsiakasID.Location = new System.Drawing.Point(7, 48);
            this.lblAsiakasID.Name = "lblAsiakasID";
            this.lblAsiakasID.Size = new System.Drawing.Size(74, 13);
            this.lblAsiakasID.TabIndex = 8;
            this.lblAsiakasID.Text = "Asiakkaan ID:";
            // 
            // lblToimipisteID
            // 
            this.lblToimipisteID.AutoSize = true;
            this.lblToimipisteID.Location = new System.Drawing.Point(7, 74);
            this.lblToimipisteID.Name = "lblToimipisteID";
            this.lblToimipisteID.Size = new System.Drawing.Size(57, 13);
            this.lblToimipisteID.TabIndex = 9;
            this.lblToimipisteID.Text = "Toimipiste:";
            // 
            // lblVarattuAlkupvm
            // 
            this.lblVarattuAlkupvm.AutoSize = true;
            this.lblVarattuAlkupvm.Location = new System.Drawing.Point(222, 48);
            this.lblVarattuAlkupvm.Name = "lblVarattuAlkupvm";
            this.lblVarattuAlkupvm.Size = new System.Drawing.Size(139, 13);
            this.lblVarattuAlkupvm.TabIndex = 11;
            this.lblVarattuAlkupvm.Text = "Varauksen alkupäivämäärä:";
            // 
            // lblVarattuLoppupvm
            // 
            this.lblVarattuLoppupvm.AutoSize = true;
            this.lblVarattuLoppupvm.Location = new System.Drawing.Point(222, 74);
            this.lblVarattuLoppupvm.Name = "lblVarattuLoppupvm";
            this.lblVarattuLoppupvm.Size = new System.Drawing.Size(145, 13);
            this.lblVarattuLoppupvm.TabIndex = 12;
            this.lblVarattuLoppupvm.Text = "Varauksen loppupäivämäärä:";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(610, 72);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 3;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(610, 94);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(610, 116);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 5;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPaavalikko
            // 
            this.btnPaavalikko.Location = new System.Drawing.Point(657, 547);
            this.btnPaavalikko.Name = "btnPaavalikko";
            this.btnPaavalikko.Size = new System.Drawing.Size(133, 23);
            this.btnPaavalikko.TabIndex = 0;
            this.btnPaavalikko.Text = "Päävalikkoon";
            this.btnPaavalikko.UseVisualStyleBackColor = true;
            this.btnPaavalikko.Click += new System.EventHandler(this.btnPaavalikko_Click);
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.AllowUserToAddRows = false;
            this.dgvVaraukset.AllowUserToDeleteRows = false;
            this.dgvVaraukset.AllowUserToResizeColumns = false;
            this.dgvVaraukset.AllowUserToResizeRows = false;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVaraukset.Location = new System.Drawing.Point(12, 175);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.ReadOnly = true;
            this.dgvVaraukset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVaraukset.Size = new System.Drawing.Size(743, 313);
            this.dgvVaraukset.TabIndex = 6;
            this.dgvVaraukset.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVaraukset_RowHeaderMouseClick);
            this.dgvVaraukset.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVaraukset_RowHeaderMouseDoubleClick);
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "Varaus";
            this.varausBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // mokkivarausDataSet
            // 
            this.mokkivarausDataSet.DataSetName = "mokkivarausDataSet";
            this.mokkivarausDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // lblVaraukset
            // 
            this.lblVaraukset.AutoSize = true;
            this.lblVaraukset.Location = new System.Drawing.Point(9, 159);
            this.lblVaraukset.Name = "lblVaraukset";
            this.lblVaraukset.Size = new System.Drawing.Size(58, 13);
            this.lblVaraukset.TabIndex = 7;
            this.lblVaraukset.Text = "Varaukset:";
            // 
            // lblVarausID
            // 
            this.lblVarausID.AutoSize = true;
            this.lblVarausID.Location = new System.Drawing.Point(7, 22);
            this.lblVarausID.Name = "lblVarausID";
            this.lblVarausID.Size = new System.Drawing.Size(75, 13);
            this.lblVarausID.TabIndex = 7;
            this.lblVarausID.Text = "Varauksen ID:";
            // 
            // tbVarausID
            // 
            this.tbVarausID.Location = new System.Drawing.Point(88, 19);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.Size = new System.Drawing.Size(100, 20);
            this.tbVarausID.TabIndex = 0;
            this.tbVarausID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // dgvVarauksenPalvelut
            // 
            this.dgvVarauksenPalvelut.AllowUserToAddRows = false;
            this.dgvVarauksenPalvelut.AllowUserToDeleteRows = false;
            this.dgvVarauksenPalvelut.AllowUserToResizeColumns = false;
            this.dgvVarauksenPalvelut.AllowUserToResizeRows = false;
            this.dgvVarauksenPalvelut.AutoGenerateColumns = false;
            this.dgvVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn1,
            this.palveluidDataGridViewTextBoxColumn,
            this.lkmDataGridViewTextBoxColumn});
            this.dgvVarauksenPalvelut.DataSource = this.varauksenpalvelutBindingSource;
            this.dgvVarauksenPalvelut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVarauksenPalvelut.Location = new System.Drawing.Point(9, 74);
            this.dgvVarauksenPalvelut.Name = "dgvVarauksenPalvelut";
            this.dgvVarauksenPalvelut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVarauksenPalvelut.Size = new System.Drawing.Size(344, 150);
            this.dgvVarauksenPalvelut.TabIndex = 16;
            // 
            // varausidDataGridViewTextBoxColumn1
            // 
            this.varausidDataGridViewTextBoxColumn1.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn1.HeaderText = "Varauksen ID";
            this.varausidDataGridViewTextBoxColumn1.Name = "varausidDataGridViewTextBoxColumn1";
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "Palvelun ID";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            // 
            // lkmDataGridViewTextBoxColumn
            // 
            this.lkmDataGridViewTextBoxColumn.DataPropertyName = "lkm";
            this.lkmDataGridViewTextBoxColumn.HeaderText = "Lukumäärä";
            this.lkmDataGridViewTextBoxColumn.Name = "lkmDataGridViewTextBoxColumn";
            // 
            // varauksenpalvelutBindingSource
            // 
            this.varauksenpalvelutBindingSource.DataMember = "Varauksen_palvelut";
            this.varauksenpalvelutBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // varauksen_palvelutTableAdapter
            // 
            this.varauksen_palvelutTableAdapter.ClearBeforeFill = true;
            // 
            // lblVarauksenPalvelut
            // 
            this.lblVarauksenPalvelut.AutoSize = true;
            this.lblVarauksenPalvelut.Location = new System.Drawing.Point(5, 58);
            this.lblVarauksenPalvelut.Name = "lblVarauksenPalvelut";
            this.lblVarauksenPalvelut.Size = new System.Drawing.Size(101, 13);
            this.lblVarauksenPalvelut.TabIndex = 17;
            this.lblVarauksenPalvelut.Text = "Varauksen palvelut:";
            // 
            // lblVahvistuspvm
            // 
            this.lblVahvistuspvm.AutoSize = true;
            this.lblVahvistuspvm.Location = new System.Drawing.Point(222, 100);
            this.lblVahvistuspvm.Name = "lblVahvistuspvm";
            this.lblVahvistuspvm.Size = new System.Drawing.Size(111, 13);
            this.lblVahvistuspvm.TabIndex = 13;
            this.lblVahvistuspvm.Text = "Vahvistuspäivämäärä:";
            // 
            // dtpVahvistuspvm
            // 
            this.dtpVahvistuspvm.Location = new System.Drawing.Point(374, 94);
            this.dtpVahvistuspvm.Name = "dtpVahvistuspvm";
            this.dtpVahvistuspvm.Size = new System.Drawing.Size(200, 20);
            this.dtpVahvistuspvm.TabIndex = 6;
            // 
            // dgvToimipisteenPalvelut
            // 
            this.dgvToimipisteenPalvelut.AllowUserToAddRows = false;
            this.dgvToimipisteenPalvelut.AllowUserToDeleteRows = false;
            this.dgvToimipisteenPalvelut.AllowUserToResizeColumns = false;
            this.dgvToimipisteenPalvelut.AllowUserToResizeRows = false;
            this.dgvToimipisteenPalvelut.AutoGenerateColumns = false;
            this.dgvToimipisteenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimipisteenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn1,
            this.toimipisteidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dgvToimipisteenPalvelut.DataSource = this.palveluBindingSource;
            this.dgvToimipisteenPalvelut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvToimipisteenPalvelut.Location = new System.Drawing.Point(9, 273);
            this.dgvToimipisteenPalvelut.Name = "dgvToimipisteenPalvelut";
            this.dgvToimipisteenPalvelut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvToimipisteenPalvelut.Size = new System.Drawing.Size(743, 195);
            this.dgvToimipisteenPalvelut.TabIndex = 20;
            this.dgvToimipisteenPalvelut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToimipisteenPalvelut_CellContentClick);
            this.dgvToimipisteenPalvelut.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvToimipisteenPalvelut_RowHeaderMouseClick);
            this.dgvToimipisteenPalvelut.SelectionChanged += new System.EventHandler(this.dgvToimipisteenPalvelut_SelectionChanged);
            this.dgvToimipisteenPalvelut.Click += new System.EventHandler(this.dgvToimipisteenPalvelut_Click);
            // 
            // palveluidDataGridViewTextBoxColumn1
            // 
            this.palveluidDataGridViewTextBoxColumn1.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn1.HeaderText = "Palvelun ID";
            this.palveluidDataGridViewTextBoxColumn1.Name = "palveluidDataGridViewTextBoxColumn1";
            // 
            // toimipisteidDataGridViewTextBoxColumn1
            // 
            this.toimipisteidDataGridViewTextBoxColumn1.DataPropertyName = "toimipiste_id";
            this.toimipisteidDataGridViewTextBoxColumn1.HeaderText = "Toimipisteen ID";
            this.toimipisteidDataGridViewTextBoxColumn1.Name = "toimipisteidDataGridViewTextBoxColumn1";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Palvelun nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "Tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "ALV";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "Palvelu";
            this.palveluBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // lblVarauksenToimipisteenPalvelut
            // 
            this.lblVarauksenToimipisteenPalvelut.AutoSize = true;
            this.lblVarauksenToimipisteenPalvelut.Location = new System.Drawing.Point(5, 257);
            this.lblVarauksenToimipisteenPalvelut.Name = "lblVarauksenToimipisteenPalvelut";
            this.lblVarauksenToimipisteenPalvelut.Size = new System.Drawing.Size(259, 13);
            this.lblVarauksenToimipisteenPalvelut.TabIndex = 21;
            this.lblVarauksenToimipisteenPalvelut.Text = "Varauksen toimipisteen vapaat majoitukset ja palvelut";
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // tcVaraukset
            // 
            this.tcVaraukset.Controls.Add(this.tpVaraukset);
            this.tcVaraukset.Controls.Add(this.tpVarauksenPalvelut);
            this.tcVaraukset.Location = new System.Drawing.Point(12, 12);
            this.tcVaraukset.Name = "tcVaraukset";
            this.tcVaraukset.SelectedIndex = 0;
            this.tcVaraukset.Size = new System.Drawing.Size(778, 529);
            this.tcVaraukset.TabIndex = 1;
            // 
            // tpVaraukset
            // 
            this.tpVaraukset.Controls.Add(this.btnValAsiakas);
            this.tpVaraukset.Controls.Add(this.btnTyhjenna);
            this.tpVaraukset.Controls.Add(this.btnHae);
            this.tpVaraukset.Controls.Add(this.gbVarauksenTiedot);
            this.tpVaraukset.Controls.Add(this.lblVaraukset);
            this.tpVaraukset.Controls.Add(this.btnPoista);
            this.tpVaraukset.Controls.Add(this.dgvVaraukset);
            this.tpVaraukset.Controls.Add(this.btnLisaa);
            this.tpVaraukset.Controls.Add(this.btnMuokkaa);
            this.tpVaraukset.Location = new System.Drawing.Point(4, 22);
            this.tpVaraukset.Name = "tpVaraukset";
            this.tpVaraukset.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpVaraukset.Size = new System.Drawing.Size(770, 503);
            this.tpVaraukset.TabIndex = 0;
            this.tpVaraukset.Text = "Varaukset";
            this.tpVaraukset.UseVisualStyleBackColor = true;
            // 
            // btnValAsiakas
            // 
            this.btnValAsiakas.Location = new System.Drawing.Point(689, 10);
            this.btnValAsiakas.Name = "btnValAsiakas";
            this.btnValAsiakas.Size = new System.Drawing.Size(75, 36);
            this.btnValAsiakas.TabIndex = 8;
            this.btnValAsiakas.Text = "Valitse asiakas";
            this.btnValAsiakas.UseVisualStyleBackColor = true;
            this.btnValAsiakas.Click += new System.EventHandler(this.btnValAsiakas_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(610, 32);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(75, 23);
            this.btnTyhjenna.TabIndex = 2;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(610, 10);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 1;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // gbVarauksenTiedot
            // 
            this.gbVarauksenTiedot.Controls.Add(this.cbToimipiste);
            this.gbVarauksenTiedot.Controls.Add(this.dtpVarattupvm);
            this.gbVarauksenTiedot.Controls.Add(this.lblVarattupvm);
            this.gbVarauksenTiedot.Controls.Add(this.dtpVarattuAlkupvm);
            this.gbVarauksenTiedot.Controls.Add(this.lblVarausID);
            this.gbVarauksenTiedot.Controls.Add(this.dtpVarattuLoppupvm);
            this.gbVarauksenTiedot.Controls.Add(this.tbVarausID);
            this.gbVarauksenTiedot.Controls.Add(this.lblToimipisteID);
            this.gbVarauksenTiedot.Controls.Add(this.lblVahvistuspvm);
            this.gbVarauksenTiedot.Controls.Add(this.lblAsiakasID);
            this.gbVarauksenTiedot.Controls.Add(this.lblVarattuLoppupvm);
            this.gbVarauksenTiedot.Controls.Add(this.dtpVahvistuspvm);
            this.gbVarauksenTiedot.Controls.Add(this.tbAsiakasID);
            this.gbVarauksenTiedot.Controls.Add(this.lblVarattuAlkupvm);
            this.gbVarauksenTiedot.Location = new System.Drawing.Point(9, 10);
            this.gbVarauksenTiedot.Name = "gbVarauksenTiedot";
            this.gbVarauksenTiedot.Size = new System.Drawing.Size(595, 126);
            this.gbVarauksenTiedot.TabIndex = 0;
            this.gbVarauksenTiedot.TabStop = false;
            this.gbVarauksenTiedot.Text = "Varauksen tiedot";
            // 
            // cbToimipiste
            // 
            this.cbToimipiste.FormattingEnabled = true;
            this.cbToimipiste.Location = new System.Drawing.Point(88, 71);
            this.cbToimipiste.Name = "cbToimipiste";
            this.cbToimipiste.Size = new System.Drawing.Size(113, 21);
            this.cbToimipiste.TabIndex = 2;
            // 
            // dtpVarattupvm
            // 
            this.dtpVarattupvm.Enabled = false;
            this.dtpVarattupvm.Location = new System.Drawing.Point(374, 16);
            this.dtpVarattupvm.Name = "dtpVarattupvm";
            this.dtpVarattupvm.Size = new System.Drawing.Size(200, 20);
            this.dtpVarattupvm.TabIndex = 3;
            // 
            // lblVarattupvm
            // 
            this.lblVarattupvm.AutoSize = true;
            this.lblVarattupvm.Location = new System.Drawing.Point(222, 22);
            this.lblVarattupvm.Name = "lblVarattupvm";
            this.lblVarattupvm.Size = new System.Drawing.Size(69, 13);
            this.lblVarattupvm.TabIndex = 10;
            this.lblVarattupvm.Text = "Varauspäivä:";
            // 
            // tpVarauksenPalvelut
            // 
            this.tpVarauksenPalvelut.Controls.Add(this.cb_NaytaVaratut);
            this.tpVarauksenPalvelut.Controls.Add(this.btnLisaaPalvelu);
            this.tpVarauksenPalvelut.Controls.Add(this.tb_palvLkmPaivitys);
            this.tpVarauksenPalvelut.Controls.Add(this.lb_palvelunlkm);
            this.tpVarauksenPalvelut.Controls.Add(this.tb_PalvLkm);
            this.tpVarauksenPalvelut.Controls.Add(this.btnPoistaPalvelu);
            this.tpVarauksenPalvelut.Controls.Add(this.btn);
            this.tpVarauksenPalvelut.Controls.Add(this.btnHaeVaraus);
            this.tpVarauksenPalvelut.Controls.Add(this.lblVarausIDpg2);
            this.tpVarauksenPalvelut.Controls.Add(this.tbVarausIDpg2);
            this.tpVarauksenPalvelut.Controls.Add(this.dgvToimipisteenPalvelut);
            this.tpVarauksenPalvelut.Controls.Add(this.lblVarauksenToimipisteenPalvelut);
            this.tpVarauksenPalvelut.Controls.Add(this.lblVarauksenPalvelut);
            this.tpVarauksenPalvelut.Controls.Add(this.dgvVarauksenPalvelut);
            this.tpVarauksenPalvelut.Location = new System.Drawing.Point(4, 22);
            this.tpVarauksenPalvelut.Name = "tpVarauksenPalvelut";
            this.tpVarauksenPalvelut.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpVarauksenPalvelut.Size = new System.Drawing.Size(770, 503);
            this.tpVarauksenPalvelut.TabIndex = 1;
            this.tpVarauksenPalvelut.Text = "Varauksen palvelut";
            this.tpVarauksenPalvelut.UseVisualStyleBackColor = true;
            // 
            // cb_NaytaVaratut
            // 
            this.cb_NaytaVaratut.AutoSize = true;
            this.cb_NaytaVaratut.Location = new System.Drawing.Point(279, 255);
            this.cb_NaytaVaratut.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cb_NaytaVaratut.Name = "cb_NaytaVaratut";
            this.cb_NaytaVaratut.Size = new System.Drawing.Size(130, 17);
            this.cb_NaytaVaratut.TabIndex = 33;
            this.cb_NaytaVaratut.Text = "Näytä varatut palvelut";
            this.cb_NaytaVaratut.UseVisualStyleBackColor = true;
            this.cb_NaytaVaratut.CheckedChanged += new System.EventHandler(this.cb_NaytaVaratut_CheckedChanged);
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(601, 468);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(151, 35);
            this.btnLisaaPalvelu.TabIndex = 27;
            this.btnLisaaPalvelu.Text = "Lisää palvelu tai majoitus varaukseen";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelu.Click += new System.EventHandler(this.btnLisaaPalvelu_Click);
            // 
            // tb_palvLkmPaivitys
            // 
            this.tb_palvLkmPaivitys.Enabled = false;
            this.tb_palvLkmPaivitys.Location = new System.Drawing.Point(514, 175);
            this.tb_palvLkmPaivitys.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tb_palvLkmPaivitys.Name = "tb_palvLkmPaivitys";
            this.tb_palvLkmPaivitys.Size = new System.Drawing.Size(100, 20);
            this.tb_palvLkmPaivitys.TabIndex = 31;
            this.tb_palvLkmPaivitys.Visible = false;
            // 
            // lb_palvelunlkm
            // 
            this.lb_palvelunlkm.AutoSize = true;
            this.lb_palvelunlkm.Location = new System.Drawing.Point(388, 480);
            this.lb_palvelunlkm.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lb_palvelunlkm.Name = "lb_palvelunlkm";
            this.lb_palvelunlkm.Size = new System.Drawing.Size(106, 13);
            this.lb_palvelunlkm.TabIndex = 30;
            this.lb_palvelunlkm.Text = "Palvelun lukumäärä :";
            // 
            // tb_PalvLkm
            // 
            this.tb_PalvLkm.Location = new System.Drawing.Point(497, 478);
            this.tb_PalvLkm.MaxLength = 3;
            this.tb_PalvLkm.Name = "tb_PalvLkm";
            this.tb_PalvLkm.Size = new System.Drawing.Size(100, 20);
            this.tb_PalvLkm.TabIndex = 29;
            this.tb_PalvLkm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(359, 201);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(151, 23);
            this.btnPoistaPalvelu.TabIndex = 28;
            this.btnPoistaPalvelu.Text = "Poista varauksen palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // btn
            // 
            this.btn.Enabled = false;
            this.btn.Location = new System.Drawing.Point(359, 172);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(151, 23);
            this.btn.TabIndex = 23;
            this.btn.Text = "Päivitä palvelun lukumäärä";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnHaeVaraus
            // 
            this.btnHaeVaraus.Location = new System.Drawing.Point(220, 13);
            this.btnHaeVaraus.Name = "btnHaeVaraus";
            this.btnHaeVaraus.Size = new System.Drawing.Size(133, 23);
            this.btnHaeVaraus.TabIndex = 25;
            this.btnHaeVaraus.Text = "Hae varauksen palvelut";
            this.btnHaeVaraus.UseVisualStyleBackColor = true;
            this.btnHaeVaraus.Click += new System.EventHandler(this.btnHaeVaraus_Click);
            // 
            // lblVarausIDpg2
            // 
            this.lblVarausIDpg2.AutoSize = true;
            this.lblVarausIDpg2.Location = new System.Drawing.Point(17, 18);
            this.lblVarausIDpg2.Name = "lblVarausIDpg2";
            this.lblVarausIDpg2.Size = new System.Drawing.Size(75, 13);
            this.lblVarausIDpg2.TabIndex = 23;
            this.lblVarausIDpg2.Text = "Varauksen ID:";
            // 
            // tbVarausIDpg2
            // 
            this.tbVarausIDpg2.Location = new System.Drawing.Point(98, 15);
            this.tbVarausIDpg2.Name = "tbVarausIDpg2";
            this.tbVarausIDpg2.Size = new System.Drawing.Size(100, 20);
            this.tbVarausIDpg2.TabIndex = 24;
            this.tbVarausIDpg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // erProvTeksti
            // 
            this.erProvTeksti.ContainerControl = this;
            // 
            // toimipisteBindingSource
            // 
            this.toimipisteBindingSource.DataMember = "Toimipiste";
            this.toimipisteBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.ControlBox = false;
            this.Controls.Add(this.tcVaraukset);
            this.Controls.Add(this.btnPaavalikko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Varaukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimipisteenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.tcVaraukset.ResumeLayout(false);
            this.tpVaraukset.ResumeLayout(false);
            this.tpVaraukset.PerformLayout();
            this.gbVarauksenTiedot.ResumeLayout(false);
            this.gbVarauksenTiedot.PerformLayout();
            this.tpVarauksenPalvelut.ResumeLayout(false);
            this.tpVarauksenPalvelut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpVarattuAlkupvm;
        private System.Windows.Forms.DateTimePicker dtpVarattuLoppupvm;
        private System.Windows.Forms.TextBox tbAsiakasID;
        private System.Windows.Forms.Label lblAsiakasID;
        private System.Windows.Forms.Label lblToimipisteID;
        private System.Windows.Forms.Label lblVarattuAlkupvm;
        private System.Windows.Forms.Label lblVarattuLoppupvm;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPaavalikko;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private mokkivarausDataSet mokkivarausDataSet;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private mokkivarausDataSetTableAdapters.VarausTableAdapter varausTableAdapter;
        private System.Windows.Forms.Label lblVaraukset;
        private System.Windows.Forms.Label lblVarausID;
        private System.Windows.Forms.TextBox tbVarausID;
        private System.Windows.Forms.DataGridView dgvVarauksenPalvelut;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource;
        private mokkivarausDataSetTableAdapters.Varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.Label lblVarauksenPalvelut;
        private System.Windows.Forms.Label lblVahvistuspvm;
        private System.Windows.Forms.DateTimePicker dtpVahvistuspvm;
        private System.Windows.Forms.DataGridView dgvToimipisteenPalvelut;
        private System.Windows.Forms.Label lblVarauksenToimipisteenPalvelut;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private mokkivarausDataSetTableAdapters.PalveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.TabControl tcVaraukset;
        private System.Windows.Forms.TabPage tpVaraukset;
        private System.Windows.Forms.TabPage tpVarauksenPalvelut;
        private System.Windows.Forms.GroupBox gbVarauksenTiedot;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lkmDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHaeVaraus;
        private System.Windows.Forms.Label lblVarausIDpg2;
        private System.Windows.Forms.TextBox tbVarausIDpg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimipisteidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.TextBox tb_PalvLkm;
        private System.Windows.Forms.ErrorProvider erProvTeksti;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.DateTimePicker dtpVarattupvm;
        private System.Windows.Forms.Label lblVarattupvm;
        private System.Windows.Forms.Label lb_palvelunlkm;
        private System.Windows.Forms.TextBox tb_palvLkmPaivitys;
        private System.Windows.Forms.ComboBox cbToimipiste;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private mokkivarausDataSetTableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        private System.Windows.Forms.Button btnValAsiakas;
        private System.Windows.Forms.CheckBox cb_NaytaVaratut;
    }
}