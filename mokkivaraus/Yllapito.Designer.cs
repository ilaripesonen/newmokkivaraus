namespace mokkivaraus
{
    partial class Yllapito
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
            this.button_MuokkaaToimipistetta = new System.Windows.Forms.Button();
            this.button_LisaaToimipiste = new System.Windows.Forms.Button();
            this.button_PoistaToimipiste = new System.Windows.Forms.Button();
            this.button_PoistaPalvelu = new System.Windows.Forms.Button();
            this.button_LisaaPalvelu = new System.Windows.Forms.Button();
            this.button_MuokkaaPalvelua = new System.Windows.Forms.Button();
            this.button_Poistu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toimipisteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postitoimipaikkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkivarausDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkivarausDataSet = new mokkivaraus.mokkivarausDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimipisteidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimipisteTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.ToimipisteTableAdapter();
            this.toimipisteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_paivita = new System.Windows.Forms.Button();
            this.palveluTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.PalveluTableAdapter();
            this.btn_PäivitäPalvelut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MuokkaaToimipistetta
            // 
            this.button_MuokkaaToimipistetta.Location = new System.Drawing.Point(928, 83);
            this.button_MuokkaaToimipistetta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_MuokkaaToimipistetta.Name = "button_MuokkaaToimipistetta";
            this.button_MuokkaaToimipistetta.Size = new System.Drawing.Size(186, 35);
            this.button_MuokkaaToimipistetta.TabIndex = 1;
            this.button_MuokkaaToimipistetta.Text = "Muokkaa toimipistettä";
            this.button_MuokkaaToimipistetta.UseVisualStyleBackColor = true;
            this.button_MuokkaaToimipistetta.Click += new System.EventHandler(this.button_MuokkaaToimipistetta_Click);
            // 
            // button_LisaaToimipiste
            // 
            this.button_LisaaToimipiste.Location = new System.Drawing.Point(928, 39);
            this.button_LisaaToimipiste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_LisaaToimipiste.Name = "button_LisaaToimipiste";
            this.button_LisaaToimipiste.Size = new System.Drawing.Size(186, 35);
            this.button_LisaaToimipiste.TabIndex = 2;
            this.button_LisaaToimipiste.Text = "Lisää toimipiste";
            this.button_LisaaToimipiste.UseVisualStyleBackColor = true;
            this.button_LisaaToimipiste.Click += new System.EventHandler(this.button_LisaaToimipiste_Click);
            // 
            // button_PoistaToimipiste
            // 
            this.button_PoistaToimipiste.Location = new System.Drawing.Point(928, 128);
            this.button_PoistaToimipiste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_PoistaToimipiste.Name = "button_PoistaToimipiste";
            this.button_PoistaToimipiste.Size = new System.Drawing.Size(186, 35);
            this.button_PoistaToimipiste.TabIndex = 3;
            this.button_PoistaToimipiste.Text = "Poista toimipiste";
            this.button_PoistaToimipiste.UseVisualStyleBackColor = true;
            this.button_PoistaToimipiste.Click += new System.EventHandler(this.button_PoistaToimipiste_Click);
            // 
            // button_PoistaPalvelu
            // 
            this.button_PoistaPalvelu.Location = new System.Drawing.Point(928, 517);
            this.button_PoistaPalvelu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_PoistaPalvelu.Name = "button_PoistaPalvelu";
            this.button_PoistaPalvelu.Size = new System.Drawing.Size(186, 35);
            this.button_PoistaPalvelu.TabIndex = 6;
            this.button_PoistaPalvelu.Text = "Poista palvelu";
            this.button_PoistaPalvelu.UseVisualStyleBackColor = true;
            this.button_PoistaPalvelu.Click += new System.EventHandler(this.button_PoistaPalvelu_Click);
            // 
            // button_LisaaPalvelu
            // 
            this.button_LisaaPalvelu.Location = new System.Drawing.Point(928, 428);
            this.button_LisaaPalvelu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_LisaaPalvelu.Name = "button_LisaaPalvelu";
            this.button_LisaaPalvelu.Size = new System.Drawing.Size(186, 35);
            this.button_LisaaPalvelu.TabIndex = 5;
            this.button_LisaaPalvelu.Text = "Lisää palvelu";
            this.button_LisaaPalvelu.UseVisualStyleBackColor = true;
            this.button_LisaaPalvelu.Click += new System.EventHandler(this.button_LisaaPalvelu_Click);
            // 
            // button_MuokkaaPalvelua
            // 
            this.button_MuokkaaPalvelua.Location = new System.Drawing.Point(928, 472);
            this.button_MuokkaaPalvelua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_MuokkaaPalvelua.Name = "button_MuokkaaPalvelua";
            this.button_MuokkaaPalvelua.Size = new System.Drawing.Size(186, 35);
            this.button_MuokkaaPalvelua.TabIndex = 4;
            this.button_MuokkaaPalvelua.Text = "Muokkaa palvelua";
            this.button_MuokkaaPalvelua.UseVisualStyleBackColor = true;
            this.button_MuokkaaPalvelua.Click += new System.EventHandler(this.button_MuokkaaPalvelua_Click);
            // 
            // button_Poistu
            // 
            this.button_Poistu.Location = new System.Drawing.Point(928, 636);
            this.button_Poistu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Poistu.Name = "button_Poistu";
            this.button_Poistu.Size = new System.Drawing.Size(132, 35);
            this.button_Poistu.TabIndex = 7;
            this.button_Poistu.Text = "Päävalikkoon";
            this.button_Poistu.UseVisualStyleBackColor = true;
            this.button_Poistu.Click += new System.EventHandler(this.button_Poistu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(883, 328);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toimipisteet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimipisteidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.postitoimipaikkaDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toimipisteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(871, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // toimipisteidDataGridViewTextBoxColumn
            // 
            this.toimipisteidDataGridViewTextBoxColumn.DataPropertyName = "toimipiste_id";
            this.toimipisteidDataGridViewTextBoxColumn.HeaderText = "Toimipiste ID";
            this.toimipisteidDataGridViewTextBoxColumn.Name = "toimipisteidDataGridViewTextBoxColumn";
            this.toimipisteidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "Lähiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postitoimipaikkaDataGridViewTextBoxColumn
            // 
            this.postitoimipaikkaDataGridViewTextBoxColumn.DataPropertyName = "postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.HeaderText = "Postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.Name = "postitoimipaikkaDataGridViewTextBoxColumn";
            this.postitoimipaikkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Sähköposti";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "Puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toimipisteBindingSource
            // 
            this.toimipisteBindingSource.DataMember = "Toimipiste";
            this.toimipisteBindingSource.DataSource = this.mokkivarausDataSetBindingSource;
            // 
            // mokkivarausDataSetBindingSource
            // 
            this.mokkivarausDataSetBindingSource.DataSource = this.mokkivarausDataSet;
            this.mokkivarausDataSetBindingSource.Position = 0;
            // 
            // mokkivarausDataSet
            // 
            this.mokkivarausDataSet.DataSetName = "mokkivarausDataSet";
            this.mokkivarausDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(21, 412);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(883, 301);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palvelut";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.toimipisteidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn1,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.palveluBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(4, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(871, 266);
            this.dataGridView2.TabIndex = 0;
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "Palvelu ID";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            this.palveluidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toimipisteidDataGridViewTextBoxColumn1
            // 
            this.toimipisteidDataGridViewTextBoxColumn1.DataPropertyName = "toimipiste_id";
            this.toimipisteidDataGridViewTextBoxColumn1.HeaderText = "Toimipiste ID";
            this.toimipisteidDataGridViewTextBoxColumn1.Name = "toimipisteidDataGridViewTextBoxColumn1";
            this.toimipisteidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nimiDataGridViewTextBoxColumn1
            // 
            this.nimiDataGridViewTextBoxColumn1.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn1.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn1.Name = "nimiDataGridViewTextBoxColumn1";
            this.nimiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "Tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            this.tyyppiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            this.hintaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "ALV";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            this.alvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "Palvelu";
            this.palveluBindingSource.DataSource = this.mokkivarausDataSetBindingSource;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // toimipisteBindingSource1
            // 
            this.toimipisteBindingSource1.DataMember = "Toimipiste";
            this.toimipisteBindingSource1.DataSource = this.mokkivarausDataSetBindingSource;
            // 
            // btn_paivita
            // 
            this.btn_paivita.Location = new System.Drawing.Point(928, 170);
            this.btn_paivita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_paivita.Name = "btn_paivita";
            this.btn_paivita.Size = new System.Drawing.Size(186, 39);
            this.btn_paivita.TabIndex = 13;
            this.btn_paivita.Text = "Päivitä";
            this.btn_paivita.UseVisualStyleBackColor = true;
            this.btn_paivita.Click += new System.EventHandler(this.btn_paivita_Click);
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // btn_PäivitäPalvelut
            // 
            this.btn_PäivitäPalvelut.Location = new System.Drawing.Point(928, 559);
            this.btn_PäivitäPalvelut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PäivitäPalvelut.Name = "btn_PäivitäPalvelut";
            this.btn_PäivitäPalvelut.Size = new System.Drawing.Size(186, 39);
            this.btn_PäivitäPalvelut.TabIndex = 14;
            this.btn_PäivitäPalvelut.Text = "Päivitä";
            this.btn_PäivitäPalvelut.UseVisualStyleBackColor = true;
            this.btn_PäivitäPalvelut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yllapito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1124, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_PäivitäPalvelut);
            this.Controls.Add(this.btn_paivita);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Poistu);
            this.Controls.Add(this.button_PoistaPalvelu);
            this.Controls.Add(this.button_LisaaPalvelu);
            this.Controls.Add(this.button_MuokkaaPalvelua);
            this.Controls.Add(this.button_PoistaToimipiste);
            this.Controls.Add(this.button_LisaaToimipiste);
            this.Controls.Add(this.button_MuokkaaToimipistetta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Yllapito";
            this.Text = "Ylläpito";
            this.Load += new System.EventHandler(this.Yllapito_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_MuokkaaToimipistetta;
        private System.Windows.Forms.Button button_LisaaToimipiste;
        private System.Windows.Forms.Button button_PoistaToimipiste;
        private System.Windows.Forms.Button button_PoistaPalvelu;
        private System.Windows.Forms.Button button_LisaaPalvelu;
        private System.Windows.Forms.Button button_MuokkaaPalvelua;
        private System.Windows.Forms.Button button_Poistu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mokkivarausDataSetBindingSource;
        private mokkivarausDataSet mokkivarausDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private mokkivarausDataSetTableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        private System.Windows.Forms.BindingSource toimipisteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimipisteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postitoimipaikkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_paivita;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private mokkivarausDataSetTableAdapters.PalveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimipisteidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_PäivitäPalvelut;
    }
}