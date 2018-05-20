namespace mokkivaraus
{
    partial class Asiakastiedot
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
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPuhelinnro = new System.Windows.Forms.Label();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.tbPuhelinnro = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postitoimipaikkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkivarausDataSet = new mokkivaraus.mokkivarausDataSet();
            this.asiakasTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.AsiakasTableAdapter();
            this.lblAsiakasID = new System.Windows.Forms.Label();
            this.tbAsiakasID = new System.Windows.Forms.TextBox();
            this.gbAsiakkaanTiedot = new System.Windows.Forms.GroupBox();
            this.btnPaavalikko = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.erProvTeksti = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnTarkAsVar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).BeginInit();
            this.gbAsiakkaanTiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(6, 19);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(44, 13);
            this.lblEtunimi.TabIndex = 8;
            this.lblEtunimi.Text = "Etunimi:";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(209, 19);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(53, 13);
            this.lblSukunimi.TabIndex = 9;
            this.lblSukunimi.Text = "Sukunimi:";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(6, 67);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(58, 13);
            this.lblLahiosoite.TabIndex = 11;
            this.lblLahiosoite.Text = "Lähiosoite:";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(408, 67);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(86, 13);
            this.lblPostitoimipaikka.TabIndex = 13;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka:";
            // 
            // lblPostinro
            // 
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Location = new System.Drawing.Point(209, 67);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(68, 13);
            this.lblPostinro.TabIndex = 12;
            this.lblPostinro.Text = "Postinumero:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Sähköposti:";
            // 
            // lblPuhelinnro
            // 
            this.lblPuhelinnro.AutoSize = true;
            this.lblPuhelinnro.Location = new System.Drawing.Point(209, 115);
            this.lblPuhelinnro.Name = "lblPuhelinnro";
            this.lblPuhelinnro.Size = new System.Drawing.Size(80, 13);
            this.lblPuhelinnro.TabIndex = 15;
            this.lblPuhelinnro.Text = "Puhelinnumero:";
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(9, 35);
            this.tbEtunimi.MaxLength = 20;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(172, 20);
            this.tbEtunimi.TabIndex = 0;
            this.tbEtunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirVii);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(212, 35);
            this.tbSukunimi.MaxLength = 40;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(172, 20);
            this.tbSukunimi.TabIndex = 1;
            this.tbSukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirVii);
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(9, 83);
            this.tbLahiosoite.MaxLength = 40;
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(172, 20);
            this.tbLahiosoite.TabIndex = 3;
            this.tbLahiosoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirNumViiVal);
            // 
            // tbPostinro
            // 
            this.tbPostinro.Location = new System.Drawing.Point(212, 83);
            this.tbPostinro.MaxLength = 5;
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(172, 20);
            this.tbPostinro.TabIndex = 4;
            this.tbPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 131);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(172, 20);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressVal);
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(411, 83);
            this.tbPostitoimipaikka.MaxLength = 30;
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(172, 20);
            this.tbPostitoimipaikka.TabIndex = 5;
            this.tbPostitoimipaikka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirVii);
            // 
            // tbPuhelinnro
            // 
            this.tbPuhelinnro.Location = new System.Drawing.Point(212, 131);
            this.tbPuhelinnro.MaxLength = 15;
            this.tbPuhelinnro.Name = "tbPuhelinnro";
            this.tbPuhelinnro.Size = new System.Drawing.Size(172, 20);
            this.tbPuhelinnro.TabIndex = 7;
            this.tbPuhelinnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(625, 95);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 3;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(625, 118);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(625, 141);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 5;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.AllowUserToDeleteRows = false;
            this.dgvAsiakkaat.AllowUserToResizeColumns = false;
            this.dgvAsiakkaat.AllowUserToResizeRows = false;
            this.dgvAsiakkaat.AutoGenerateColumns = false;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.postitoimipaikkaDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgvAsiakkaat.DataSource = this.asiakasBindingSource;
            this.dgvAsiakkaat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(7, 178);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(843, 247);
            this.dgvAsiakkaat.TabIndex = 7;
            this.dgvAsiakkaat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVaraukset_RowHeaderMouseClick);
            this.dgvAsiakkaat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAsiakkaat_RowHeaderMouseDoubleClick);
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "Asiakkaan ID";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "Etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "Sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "Lähiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            // 
            // postitoimipaikkaDataGridViewTextBoxColumn
            // 
            this.postitoimipaikkaDataGridViewTextBoxColumn.DataPropertyName = "postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.HeaderText = "Postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.Name = "postitoimipaikkaDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinumero";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Sähköposti";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "Puhelinnumero";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "Asiakas";
            this.asiakasBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // mokkivarausDataSet
            // 
            this.mokkivarausDataSet.DataSetName = "mokkivarausDataSet";
            this.mokkivarausDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // lblAsiakasID
            // 
            this.lblAsiakasID.AutoSize = true;
            this.lblAsiakasID.Location = new System.Drawing.Point(408, 19);
            this.lblAsiakasID.Name = "lblAsiakasID";
            this.lblAsiakasID.Size = new System.Drawing.Size(74, 13);
            this.lblAsiakasID.TabIndex = 10;
            this.lblAsiakasID.Text = "Asiakkaan ID:";
            // 
            // tbAsiakasID
            // 
            this.tbAsiakasID.Location = new System.Drawing.Point(411, 35);
            this.tbAsiakasID.Name = "tbAsiakasID";
            this.tbAsiakasID.ReadOnly = true;
            this.tbAsiakasID.Size = new System.Drawing.Size(172, 20);
            this.tbAsiakasID.TabIndex = 2;
            this.tbAsiakasID.TabStop = false;
            // 
            // gbAsiakkaanTiedot
            // 
            this.gbAsiakkaanTiedot.Controls.Add(this.lblEtunimi);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbAsiakasID);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblSukunimi);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblAsiakasID);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblLahiosoite);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblPostitoimipaikka);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblPostinro);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblEmail);
            this.gbAsiakkaanTiedot.Controls.Add(this.lblPuhelinnro);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbEtunimi);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbPuhelinnro);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbSukunimi);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbPostitoimipaikka);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbLahiosoite);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbEmail);
            this.gbAsiakkaanTiedot.Controls.Add(this.tbPostinro);
            this.gbAsiakkaanTiedot.Location = new System.Drawing.Point(12, 12);
            this.gbAsiakkaanTiedot.Name = "gbAsiakkaanTiedot";
            this.gbAsiakkaanTiedot.Size = new System.Drawing.Size(607, 160);
            this.gbAsiakkaanTiedot.TabIndex = 0;
            this.gbAsiakkaanTiedot.TabStop = false;
            this.gbAsiakkaanTiedot.Text = "Asiakaan tiedot";
            // 
            // btnPaavalikko
            // 
            this.btnPaavalikko.Location = new System.Drawing.Point(744, 140);
            this.btnPaavalikko.Name = "btnPaavalikko";
            this.btnPaavalikko.Size = new System.Drawing.Size(82, 23);
            this.btnPaavalikko.TabIndex = 6;
            this.btnPaavalikko.Text = "Päävalikkoon";
            this.btnPaavalikko.UseVisualStyleBackColor = true;
            this.btnPaavalikko.Click += new System.EventHandler(this.btnPaavalikko_Click);
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(625, 26);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 1;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // erProvTeksti
            // 
            this.erProvTeksti.ContainerControl = this;
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(625, 49);
            this.btnTyhjenna.Margin = new System.Windows.Forms.Padding(1);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(75, 23);
            this.btnTyhjenna.TabIndex = 2;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.bntTyhjenna_Click);
            // 
            // btnTarkAsVar
            // 
            this.btnTarkAsVar.Location = new System.Drawing.Point(744, 26);
            this.btnTarkAsVar.Name = "btnTarkAsVar";
            this.btnTarkAsVar.Size = new System.Drawing.Size(82, 55);
            this.btnTarkAsVar.TabIndex = 8;
            this.btnTarkAsVar.Text = "Tarkastele asiakkaan varauksia";
            this.btnTarkAsVar.UseVisualStyleBackColor = true;
            this.btnTarkAsVar.Click += new System.EventHandler(this.btnTarkAsVar_Click);
            // 
            // Asiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 435);
            this.ControlBox = false;
            this.Controls.Add(this.btnTarkAsVar);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.btnPaavalikko);
            this.Controls.Add(this.gbAsiakkaanTiedot);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Asiakastiedot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asiakashallinta";
            this.Load += new System.EventHandler(this.Asiakastiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).EndInit();
            this.gbAsiakkaanTiedot.ResumeLayout(false);
            this.gbAsiakkaanTiedot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblLahiosoite;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.Label lblPostinro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPuhelinnro;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbPuhelinnro;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private mokkivarausDataSet mokkivarausDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private mokkivarausDataSetTableAdapters.AsiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.Label lblAsiakasID;
        private System.Windows.Forms.TextBox tbAsiakasID;
        private System.Windows.Forms.GroupBox gbAsiakkaanTiedot;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postitoimipaikkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPaavalikko;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.ErrorProvider erProvTeksti;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Button btnTarkAsVar;
    }
}