namespace mokkivaraus
{
    partial class Laskutus
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
            this.button_Poistu1 = new System.Windows.Forms.Button();
            this.button_LuoLasku1 = new System.Windows.Forms.Button();
            this.tabControl_Laskutus = new System.Windows.Forms.TabControl();
            this.tabLaskuttamattomat = new System.Windows.Forms.TabPage();
            this.button_Hae1 = new System.Windows.Forms.Button();
            this.button_Tyhjenna1 = new System.Windows.Forms.Button();
            this.groupBox_Varaukset = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_Hakuehdot = new System.Windows.Forms.GroupBox();
            this.label_LoppuPvm1 = new System.Windows.Forms.Label();
            this.dateTimePicker_LopetusPvm1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_AloitusPvm1 = new System.Windows.Forms.DateTimePicker();
            this.label_AlkuPvm1 = new System.Windows.Forms.Label();
            this.comboBox_Toimipiste1 = new System.Windows.Forms.ComboBox();
            this.label_Toimipiste1 = new System.Windows.Forms.Label();
            this.textBox_Varaustunnus1 = new System.Windows.Forms.TextBox();
            this.label_VarausId1 = new System.Windows.Forms.Label();
            this.textBox_Sukunimi1 = new System.Windows.Forms.TextBox();
            this.label_Sukunimi1 = new System.Windows.Forms.Label();
            this.textBox_Etunimi1 = new System.Windows.Forms.TextBox();
            this.label_Etunimi1 = new System.Windows.Forms.Label();
            this.tabLaskutetut = new System.Windows.Forms.TabPage();
            this.button_Poistu2 = new System.Windows.Forms.Button();
            this.button_Tulosta2 = new System.Windows.Forms.Button();
            this.button_Tyhjenna2 = new System.Windows.Forms.Button();
            this.button_Hae2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_LoppuPvm2 = new System.Windows.Forms.Label();
            this.dateTimePicker_LoppuPvm2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_AlkuPvm2 = new System.Windows.Forms.DateTimePicker();
            this.label_AlkuPvm2 = new System.Windows.Forms.Label();
            this.comboBox_Toimipiste2 = new System.Windows.Forms.ComboBox();
            this.label_Toimipiste2 = new System.Windows.Forms.Label();
            this.textBox_Varaustunnus2 = new System.Windows.Forms.TextBox();
            this.label_VarausId2 = new System.Windows.Forms.Label();
            this.textBox_Sukunimi2 = new System.Windows.Forms.TextBox();
            this.label_Sukunimi2 = new System.Windows.Forms.Label();
            this.textBox_Etunimi2 = new System.Windows.Forms.TextBox();
            this.label_Etunimi2 = new System.Windows.Forms.Label();
            this.erProvTeksti = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl_Laskutus.SuspendLayout();
            this.tabLaskuttamattomat.SuspendLayout();
            this.groupBox_Varaukset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Hakuehdot.SuspendLayout();
            this.tabLaskutetut.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Poistu1
            // 
            this.button_Poistu1.Location = new System.Drawing.Point(934, 114);
            this.button_Poistu1.Name = "button_Poistu1";
            this.button_Poistu1.Size = new System.Drawing.Size(170, 29);
            this.button_Poistu1.TabIndex = 0;
            this.button_Poistu1.Text = "Päävalikkoon";
            this.button_Poistu1.UseVisualStyleBackColor = true;
            this.button_Poistu1.Click += new System.EventHandler(this.button_Poistu1_Click);
            // 
            // button_LuoLasku1
            // 
            this.button_LuoLasku1.Location = new System.Drawing.Point(934, 78);
            this.button_LuoLasku1.Name = "button_LuoLasku1";
            this.button_LuoLasku1.Size = new System.Drawing.Size(170, 29);
            this.button_LuoLasku1.TabIndex = 1;
            this.button_LuoLasku1.Text = "Luo uusi lasku";
            this.button_LuoLasku1.UseVisualStyleBackColor = true;
            this.button_LuoLasku1.Click += new System.EventHandler(this.button_LuoLasku1_Click);
            // 
            // tabControl_Laskutus
            // 
            this.tabControl_Laskutus.Controls.Add(this.tabLaskuttamattomat);
            this.tabControl_Laskutus.Controls.Add(this.tabLaskutetut);
            this.tabControl_Laskutus.Location = new System.Drawing.Point(14, 12);
            this.tabControl_Laskutus.Name = "tabControl_Laskutus";
            this.tabControl_Laskutus.SelectedIndex = 0;
            this.tabControl_Laskutus.Size = new System.Drawing.Size(1118, 440);
            this.tabControl_Laskutus.TabIndex = 2;
            this.tabControl_Laskutus.SelectedIndexChanged += new System.EventHandler(this.tabControl_Laskutus_SelectedIndexChanged);
            // 
            // tabLaskuttamattomat
            // 
            this.tabLaskuttamattomat.Controls.Add(this.button_Poistu1);
            this.tabLaskuttamattomat.Controls.Add(this.button_LuoLasku1);
            this.tabLaskuttamattomat.Controls.Add(this.button_Hae1);
            this.tabLaskuttamattomat.Controls.Add(this.button_Tyhjenna1);
            this.tabLaskuttamattomat.Controls.Add(this.groupBox_Varaukset);
            this.tabLaskuttamattomat.Controls.Add(this.groupBox_Hakuehdot);
            this.tabLaskuttamattomat.Location = new System.Drawing.Point(4, 29);
            this.tabLaskuttamattomat.Name = "tabLaskuttamattomat";
            this.tabLaskuttamattomat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaskuttamattomat.Size = new System.Drawing.Size(1110, 407);
            this.tabLaskuttamattomat.TabIndex = 0;
            this.tabLaskuttamattomat.Text = "Laskuttamattomat";
            this.tabLaskuttamattomat.UseVisualStyleBackColor = true;
            // 
            // button_Hae1
            // 
            this.button_Hae1.Location = new System.Drawing.Point(934, 6);
            this.button_Hae1.Name = "button_Hae1";
            this.button_Hae1.Size = new System.Drawing.Size(170, 29);
            this.button_Hae1.TabIndex = 7;
            this.button_Hae1.Text = "Hae";
            this.button_Hae1.UseVisualStyleBackColor = true;
            this.button_Hae1.Click += new System.EventHandler(this.button_Hae1_Click);
            // 
            // button_Tyhjenna1
            // 
            this.button_Tyhjenna1.Location = new System.Drawing.Point(934, 42);
            this.button_Tyhjenna1.Name = "button_Tyhjenna1";
            this.button_Tyhjenna1.Size = new System.Drawing.Size(170, 29);
            this.button_Tyhjenna1.TabIndex = 6;
            this.button_Tyhjenna1.Text = "Tyhjennä hakuehdot";
            this.button_Tyhjenna1.UseVisualStyleBackColor = true;
            this.button_Tyhjenna1.Click += new System.EventHandler(this.button_Tyhjenna1_Click);
            // 
            // groupBox_Varaukset
            // 
            this.groupBox_Varaukset.Controls.Add(this.dataGridView1);
            this.groupBox_Varaukset.Location = new System.Drawing.Point(6, 149);
            this.groupBox_Varaukset.Name = "groupBox_Varaukset";
            this.groupBox_Varaukset.Size = new System.Drawing.Size(1098, 251);
            this.groupBox_Varaukset.TabIndex = 5;
            this.groupBox_Varaukset.TabStop = false;
            this.groupBox_Varaukset.Text = "Laskuttamattomat varaukset";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_Hakuehdot
            // 
            this.groupBox_Hakuehdot.Controls.Add(this.label_LoppuPvm1);
            this.groupBox_Hakuehdot.Controls.Add(this.dateTimePicker_LopetusPvm1);
            this.groupBox_Hakuehdot.Controls.Add(this.dateTimePicker_AloitusPvm1);
            this.groupBox_Hakuehdot.Controls.Add(this.label_AlkuPvm1);
            this.groupBox_Hakuehdot.Controls.Add(this.comboBox_Toimipiste1);
            this.groupBox_Hakuehdot.Controls.Add(this.label_Toimipiste1);
            this.groupBox_Hakuehdot.Controls.Add(this.textBox_Varaustunnus1);
            this.groupBox_Hakuehdot.Controls.Add(this.label_VarausId1);
            this.groupBox_Hakuehdot.Controls.Add(this.textBox_Sukunimi1);
            this.groupBox_Hakuehdot.Controls.Add(this.label_Sukunimi1);
            this.groupBox_Hakuehdot.Controls.Add(this.textBox_Etunimi1);
            this.groupBox_Hakuehdot.Controls.Add(this.label_Etunimi1);
            this.groupBox_Hakuehdot.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Hakuehdot.Name = "groupBox_Hakuehdot";
            this.groupBox_Hakuehdot.Size = new System.Drawing.Size(922, 138);
            this.groupBox_Hakuehdot.TabIndex = 4;
            this.groupBox_Hakuehdot.TabStop = false;
            this.groupBox_Hakuehdot.Text = "Hae varauksia";
            // 
            // label_LoppuPvm1
            // 
            this.label_LoppuPvm1.AutoSize = true;
            this.label_LoppuPvm1.Location = new System.Drawing.Point(334, 102);
            this.label_LoppuPvm1.Name = "label_LoppuPvm1";
            this.label_LoppuPvm1.Size = new System.Drawing.Size(83, 20);
            this.label_LoppuPvm1.TabIndex = 13;
            this.label_LoppuPvm1.Text = "Loppupvm";
            // 
            // dateTimePicker_LopetusPvm1
            // 
            this.dateTimePicker_LopetusPvm1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_LopetusPvm1.Location = new System.Drawing.Point(434, 102);
            this.dateTimePicker_LopetusPvm1.Name = "dateTimePicker_LopetusPvm1";
            this.dateTimePicker_LopetusPvm1.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker_LopetusPvm1.TabIndex = 12;
            // 
            // dateTimePicker_AloitusPvm1
            // 
            this.dateTimePicker_AloitusPvm1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_AloitusPvm1.Location = new System.Drawing.Point(122, 102);
            this.dateTimePicker_AloitusPvm1.Name = "dateTimePicker_AloitusPvm1";
            this.dateTimePicker_AloitusPvm1.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker_AloitusPvm1.TabIndex = 11;
            // 
            // label_AlkuPvm1
            // 
            this.label_AlkuPvm1.AutoSize = true;
            this.label_AlkuPvm1.Location = new System.Drawing.Point(6, 102);
            this.label_AlkuPvm1.Name = "label_AlkuPvm1";
            this.label_AlkuPvm1.Size = new System.Drawing.Size(69, 20);
            this.label_AlkuPvm1.TabIndex = 10;
            this.label_AlkuPvm1.Text = "Alkupvm";
            // 
            // comboBox_Toimipiste1
            // 
            this.comboBox_Toimipiste1.FormattingEnabled = true;
            this.comboBox_Toimipiste1.Location = new System.Drawing.Point(122, 66);
            this.comboBox_Toimipiste1.Name = "comboBox_Toimipiste1";
            this.comboBox_Toimipiste1.Size = new System.Drawing.Size(194, 28);
            this.comboBox_Toimipiste1.TabIndex = 9;
            // 
            // label_Toimipiste1
            // 
            this.label_Toimipiste1.AutoSize = true;
            this.label_Toimipiste1.Location = new System.Drawing.Point(6, 69);
            this.label_Toimipiste1.Name = "label_Toimipiste1";
            this.label_Toimipiste1.Size = new System.Drawing.Size(80, 20);
            this.label_Toimipiste1.TabIndex = 8;
            this.label_Toimipiste1.Text = "Toimipiste";
            // 
            // textBox_Varaustunnus1
            // 
            this.textBox_Varaustunnus1.Location = new System.Drawing.Point(122, 32);
            this.textBox_Varaustunnus1.Name = "textBox_Varaustunnus1";
            this.textBox_Varaustunnus1.Size = new System.Drawing.Size(74, 26);
            this.textBox_Varaustunnus1.TabIndex = 7;
            // 
            // label_VarausId1
            // 
            this.label_VarausId1.AutoSize = true;
            this.label_VarausId1.Location = new System.Drawing.Point(6, 35);
            this.label_VarausId1.Name = "label_VarausId1";
            this.label_VarausId1.Size = new System.Drawing.Size(109, 20);
            this.label_VarausId1.TabIndex = 6;
            this.label_VarausId1.Text = "Varaustunnus";
            // 
            // textBox_Sukunimi1
            // 
            this.textBox_Sukunimi1.Location = new System.Drawing.Point(508, 32);
            this.textBox_Sukunimi1.Name = "textBox_Sukunimi1";
            this.textBox_Sukunimi1.Size = new System.Drawing.Size(148, 26);
            this.textBox_Sukunimi1.TabIndex = 5;
            // 
            // label_Sukunimi1
            // 
            this.label_Sukunimi1.AutoSize = true;
            this.label_Sukunimi1.Location = new System.Drawing.Point(429, 32);
            this.label_Sukunimi1.Name = "label_Sukunimi1";
            this.label_Sukunimi1.Size = new System.Drawing.Size(74, 20);
            this.label_Sukunimi1.TabIndex = 4;
            this.label_Sukunimi1.Text = "Sukunimi";
            // 
            // textBox_Etunimi1
            // 
            this.textBox_Etunimi1.Location = new System.Drawing.Point(284, 32);
            this.textBox_Etunimi1.Name = "textBox_Etunimi1";
            this.textBox_Etunimi1.Size = new System.Drawing.Size(122, 26);
            this.textBox_Etunimi1.TabIndex = 2;
            // 
            // label_Etunimi1
            // 
            this.label_Etunimi1.AutoSize = true;
            this.label_Etunimi1.Location = new System.Drawing.Point(216, 35);
            this.label_Etunimi1.Name = "label_Etunimi1";
            this.label_Etunimi1.Size = new System.Drawing.Size(62, 20);
            this.label_Etunimi1.TabIndex = 3;
            this.label_Etunimi1.Text = "Etunimi";
            // 
            // tabLaskutetut
            // 
            this.tabLaskutetut.Controls.Add(this.button_Poistu2);
            this.tabLaskutetut.Controls.Add(this.button_Tulosta2);
            this.tabLaskutetut.Controls.Add(this.button_Tyhjenna2);
            this.tabLaskutetut.Controls.Add(this.button_Hae2);
            this.tabLaskutetut.Controls.Add(this.groupBox2);
            this.tabLaskutetut.Controls.Add(this.groupBox1);
            this.tabLaskutetut.Location = new System.Drawing.Point(4, 29);
            this.tabLaskutetut.Name = "tabLaskutetut";
            this.tabLaskutetut.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaskutetut.Size = new System.Drawing.Size(1110, 407);
            this.tabLaskutetut.TabIndex = 1;
            this.tabLaskutetut.Text = "Laskutetut";
            this.tabLaskutetut.UseVisualStyleBackColor = true;
            // 
            // button_Poistu2
            // 
            this.button_Poistu2.Location = new System.Drawing.Point(934, 115);
            this.button_Poistu2.Name = "button_Poistu2";
            this.button_Poistu2.Size = new System.Drawing.Size(170, 29);
            this.button_Poistu2.TabIndex = 11;
            this.button_Poistu2.Text = "Päävalikkoon";
            this.button_Poistu2.UseVisualStyleBackColor = true;
            this.button_Poistu2.Click += new System.EventHandler(this.button_Poistu2_Click);
            // 
            // button_Tulosta2
            // 
            this.button_Tulosta2.Location = new System.Drawing.Point(934, 78);
            this.button_Tulosta2.Name = "button_Tulosta2";
            this.button_Tulosta2.Size = new System.Drawing.Size(170, 29);
            this.button_Tulosta2.TabIndex = 10;
            this.button_Tulosta2.Text = "Tulosta lasku";
            this.button_Tulosta2.UseVisualStyleBackColor = true;
            this.button_Tulosta2.Click += new System.EventHandler(this.button_Tulosta2_Click);
            // 
            // button_Tyhjenna2
            // 
            this.button_Tyhjenna2.Location = new System.Drawing.Point(934, 42);
            this.button_Tyhjenna2.Name = "button_Tyhjenna2";
            this.button_Tyhjenna2.Size = new System.Drawing.Size(170, 29);
            this.button_Tyhjenna2.TabIndex = 9;
            this.button_Tyhjenna2.Text = "Tyhjennä hakuehdot";
            this.button_Tyhjenna2.UseVisualStyleBackColor = true;
            this.button_Tyhjenna2.Click += new System.EventHandler(this.button_Tyhjenna2_Click);
            // 
            // button_Hae2
            // 
            this.button_Hae2.Location = new System.Drawing.Point(934, 6);
            this.button_Hae2.Name = "button_Hae2";
            this.button_Hae2.Size = new System.Drawing.Size(170, 29);
            this.button_Hae2.TabIndex = 8;
            this.button_Hae2.Text = "Hae";
            this.button_Hae2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(8, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 249);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laskutetut varaukset";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1084, 218);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_LoppuPvm2);
            this.groupBox1.Controls.Add(this.dateTimePicker_LoppuPvm2);
            this.groupBox1.Controls.Add(this.dateTimePicker_AlkuPvm2);
            this.groupBox1.Controls.Add(this.label_AlkuPvm2);
            this.groupBox1.Controls.Add(this.comboBox_Toimipiste2);
            this.groupBox1.Controls.Add(this.label_Toimipiste2);
            this.groupBox1.Controls.Add(this.textBox_Varaustunnus2);
            this.groupBox1.Controls.Add(this.label_VarausId2);
            this.groupBox1.Controls.Add(this.textBox_Sukunimi2);
            this.groupBox1.Controls.Add(this.label_Sukunimi2);
            this.groupBox1.Controls.Add(this.textBox_Etunimi2);
            this.groupBox1.Controls.Add(this.label_Etunimi2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hae varauksia";
            // 
            // label_LoppuPvm2
            // 
            this.label_LoppuPvm2.AutoSize = true;
            this.label_LoppuPvm2.Location = new System.Drawing.Point(334, 102);
            this.label_LoppuPvm2.Name = "label_LoppuPvm2";
            this.label_LoppuPvm2.Size = new System.Drawing.Size(83, 20);
            this.label_LoppuPvm2.TabIndex = 13;
            this.label_LoppuPvm2.Text = "Loppupvm";
            // 
            // dateTimePicker_LoppuPvm2
            // 
            this.dateTimePicker_LoppuPvm2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_LoppuPvm2.Location = new System.Drawing.Point(434, 102);
            this.dateTimePicker_LoppuPvm2.Name = "dateTimePicker_LoppuPvm2";
            this.dateTimePicker_LoppuPvm2.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker_LoppuPvm2.TabIndex = 12;
            // 
            // dateTimePicker_AlkuPvm2
            // 
            this.dateTimePicker_AlkuPvm2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_AlkuPvm2.Location = new System.Drawing.Point(122, 102);
            this.dateTimePicker_AlkuPvm2.Name = "dateTimePicker_AlkuPvm2";
            this.dateTimePicker_AlkuPvm2.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker_AlkuPvm2.TabIndex = 11;
            // 
            // label_AlkuPvm2
            // 
            this.label_AlkuPvm2.AutoSize = true;
            this.label_AlkuPvm2.Location = new System.Drawing.Point(6, 102);
            this.label_AlkuPvm2.Name = "label_AlkuPvm2";
            this.label_AlkuPvm2.Size = new System.Drawing.Size(69, 20);
            this.label_AlkuPvm2.TabIndex = 10;
            this.label_AlkuPvm2.Text = "Alkupvm";
            // 
            // comboBox_Toimipiste2
            // 
            this.comboBox_Toimipiste2.FormattingEnabled = true;
            this.comboBox_Toimipiste2.Location = new System.Drawing.Point(122, 66);
            this.comboBox_Toimipiste2.Name = "comboBox_Toimipiste2";
            this.comboBox_Toimipiste2.Size = new System.Drawing.Size(194, 28);
            this.comboBox_Toimipiste2.TabIndex = 9;
            // 
            // label_Toimipiste2
            // 
            this.label_Toimipiste2.AutoSize = true;
            this.label_Toimipiste2.Location = new System.Drawing.Point(6, 69);
            this.label_Toimipiste2.Name = "label_Toimipiste2";
            this.label_Toimipiste2.Size = new System.Drawing.Size(80, 20);
            this.label_Toimipiste2.TabIndex = 8;
            this.label_Toimipiste2.Text = "Toimipiste";
            // 
            // textBox_Varaustunnus2
            // 
            this.textBox_Varaustunnus2.Location = new System.Drawing.Point(122, 32);
            this.textBox_Varaustunnus2.Name = "textBox_Varaustunnus2";
            this.textBox_Varaustunnus2.Size = new System.Drawing.Size(74, 26);
            this.textBox_Varaustunnus2.TabIndex = 7;
            // 
            // label_VarausId2
            // 
            this.label_VarausId2.AutoSize = true;
            this.label_VarausId2.Location = new System.Drawing.Point(6, 35);
            this.label_VarausId2.Name = "label_VarausId2";
            this.label_VarausId2.Size = new System.Drawing.Size(109, 20);
            this.label_VarausId2.TabIndex = 6;
            this.label_VarausId2.Text = "Varaustunnus";
            // 
            // textBox_Sukunimi2
            // 
            this.textBox_Sukunimi2.Location = new System.Drawing.Point(508, 32);
            this.textBox_Sukunimi2.Name = "textBox_Sukunimi2";
            this.textBox_Sukunimi2.Size = new System.Drawing.Size(148, 26);
            this.textBox_Sukunimi2.TabIndex = 5;
            // 
            // label_Sukunimi2
            // 
            this.label_Sukunimi2.AutoSize = true;
            this.label_Sukunimi2.Location = new System.Drawing.Point(429, 32);
            this.label_Sukunimi2.Name = "label_Sukunimi2";
            this.label_Sukunimi2.Size = new System.Drawing.Size(74, 20);
            this.label_Sukunimi2.TabIndex = 4;
            this.label_Sukunimi2.Text = "Sukunimi";
            // 
            // textBox_Etunimi2
            // 
            this.textBox_Etunimi2.Location = new System.Drawing.Point(284, 32);
            this.textBox_Etunimi2.Name = "textBox_Etunimi2";
            this.textBox_Etunimi2.Size = new System.Drawing.Size(122, 26);
            this.textBox_Etunimi2.TabIndex = 2;
            // 
            // label_Etunimi2
            // 
            this.label_Etunimi2.AutoSize = true;
            this.label_Etunimi2.Location = new System.Drawing.Point(216, 35);
            this.label_Etunimi2.Name = "label_Etunimi2";
            this.label_Etunimi2.Size = new System.Drawing.Size(62, 20);
            this.label_Etunimi2.TabIndex = 3;
            this.label_Etunimi2.Text = "Etunimi";
            // 
            // erProvTeksti
            // 
            this.erProvTeksti.ContainerControl = this;
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1137, 465);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl_Laskutus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Laskutus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laskutus";
            this.Load += new System.EventHandler(this.Laskutus_Load);
            this.tabControl_Laskutus.ResumeLayout(false);
            this.tabLaskuttamattomat.ResumeLayout(false);
            this.groupBox_Varaukset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_Hakuehdot.ResumeLayout(false);
            this.groupBox_Hakuehdot.PerformLayout();
            this.tabLaskutetut.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Poistu1;
        private System.Windows.Forms.Button button_LuoLasku1;
        private System.Windows.Forms.TabControl tabControl_Laskutus;
        private System.Windows.Forms.TabPage tabLaskuttamattomat;
        private System.Windows.Forms.TabPage tabLaskutetut;
        private System.Windows.Forms.GroupBox groupBox_Hakuehdot;
        private System.Windows.Forms.Label label_LoppuPvm1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_LopetusPvm1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AloitusPvm1;
        private System.Windows.Forms.Label label_AlkuPvm1;
        private System.Windows.Forms.ComboBox comboBox_Toimipiste1;
        private System.Windows.Forms.Label label_Toimipiste1;
        private System.Windows.Forms.TextBox textBox_Varaustunnus1;
        private System.Windows.Forms.Label label_VarausId1;
        private System.Windows.Forms.TextBox textBox_Sukunimi1;
        private System.Windows.Forms.Label label_Sukunimi1;
        private System.Windows.Forms.TextBox textBox_Etunimi1;
        private System.Windows.Forms.Label label_Etunimi1;
        private System.Windows.Forms.Button button_Tyhjenna1;
        private System.Windows.Forms.GroupBox groupBox_Varaukset;
        private System.Windows.Forms.Button button_Hae1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_LoppuPvm2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_LoppuPvm2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AlkuPvm2;
        private System.Windows.Forms.Label label_AlkuPvm2;
        private System.Windows.Forms.ComboBox comboBox_Toimipiste2;
        private System.Windows.Forms.Label label_Toimipiste2;
        private System.Windows.Forms.TextBox textBox_Varaustunnus2;
        private System.Windows.Forms.Label label_VarausId2;
        private System.Windows.Forms.TextBox textBox_Sukunimi2;
        private System.Windows.Forms.Label label_Sukunimi2;
        private System.Windows.Forms.TextBox textBox_Etunimi2;
        private System.Windows.Forms.Label label_Etunimi2;
        private System.Windows.Forms.Button button_Hae2;
        private System.Windows.Forms.Button button_Poistu2;
        private System.Windows.Forms.Button button_Tulosta2;
        private System.Windows.Forms.Button button_Tyhjenna2;
        private System.Windows.Forms.ErrorProvider erProvTeksti;
    }
}