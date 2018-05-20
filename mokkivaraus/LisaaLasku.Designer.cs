namespace mokkivaraus
{
    partial class LisaaLasku
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
            this.button_Peruuta = new System.Windows.Forms.Button();
            this.button_LuoLasku = new System.Windows.Forms.Button();
            this.groupBox_Varaustiedot = new System.Windows.Forms.GroupBox();
            this.label_Yhteensa = new System.Windows.Forms.Label();
            this.label_Summa = new System.Windows.Forms.Label();
            this.dataGridView_VarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.label_AsiakasNimi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MaksajaEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaksajaPostinro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MaksajaPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MaksajaLahiosoite = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_MaksajaNimi = new System.Windows.Forms.TextBox();
            this.groupBox_Varaajantiedot = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_AsiakasEmail = new System.Windows.Forms.Label();
            this.label_AsiakasPostinro = new System.Windows.Forms.Label();
            this.label_AsiakasPostitoimipaikka = new System.Windows.Forms.Label();
            this.label_AsiakasLahiosoite = new System.Windows.Forms.Label();
            this.checkBox_LaskutusOsoite = new System.Windows.Forms.CheckBox();
            this.errorProvider_MaksajaNimi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_MaksajaLahiosoite = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_MaksajaPostitoimipaikka = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_MaksajaPostinro = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_MaksajaEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Varaustiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VarauksenPalvelut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_Varaajantiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaNimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaLahiosoite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaPostitoimipaikka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaPostinro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Peruuta
            // 
            this.button_Peruuta.Location = new System.Drawing.Point(623, 515);
            this.button_Peruuta.Name = "button_Peruuta";
            this.button_Peruuta.Size = new System.Drawing.Size(157, 32);
            this.button_Peruuta.TabIndex = 7;
            this.button_Peruuta.Text = "Peruuta";
            this.button_Peruuta.UseVisualStyleBackColor = true;
            this.button_Peruuta.Click += new System.EventHandler(this.button_Peruuta_Click);
            // 
            // button_LuoLasku
            // 
            this.button_LuoLasku.Location = new System.Drawing.Point(460, 515);
            this.button_LuoLasku.Name = "button_LuoLasku";
            this.button_LuoLasku.Size = new System.Drawing.Size(157, 32);
            this.button_LuoLasku.TabIndex = 6;
            this.button_LuoLasku.Text = "Luo lasku";
            this.button_LuoLasku.UseVisualStyleBackColor = true;
            this.button_LuoLasku.Click += new System.EventHandler(this.button_LuoLasku_Click);
            // 
            // groupBox_Varaustiedot
            // 
            this.groupBox_Varaustiedot.Controls.Add(this.label_Yhteensa);
            this.groupBox_Varaustiedot.Controls.Add(this.label_Summa);
            this.groupBox_Varaustiedot.Controls.Add(this.dataGridView_VarauksenPalvelut);
            this.groupBox_Varaustiedot.Location = new System.Drawing.Point(12, 249);
            this.groupBox_Varaustiedot.Name = "groupBox_Varaustiedot";
            this.groupBox_Varaustiedot.Size = new System.Drawing.Size(775, 249);
            this.groupBox_Varaustiedot.TabIndex = 5;
            this.groupBox_Varaustiedot.TabStop = false;
            this.groupBox_Varaustiedot.Text = "Varaukseen sisältyvät palvelut";
            // 
            // label_Yhteensa
            // 
            this.label_Yhteensa.AutoSize = true;
            this.label_Yhteensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Yhteensa.Location = new System.Drawing.Point(521, 213);
            this.label_Yhteensa.Name = "label_Yhteensa";
            this.label_Yhteensa.Size = new System.Drawing.Size(109, 20);
            this.label_Yhteensa.TabIndex = 2;
            this.label_Yhteensa.Text = "YHTEENSÄ:";
            // 
            // label_Summa
            // 
            this.label_Summa.AutoSize = true;
            this.label_Summa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Summa.Location = new System.Drawing.Point(667, 213);
            this.label_Summa.Name = "label_Summa";
            this.label_Summa.Size = new System.Drawing.Size(101, 20);
            this.label_Summa.TabIndex = 1;
            this.label_Summa.Text = "XXXX.XX €";
            // 
            // dataGridView_VarauksenPalvelut
            // 
            this.dataGridView_VarauksenPalvelut.AllowUserToAddRows = false;
            this.dataGridView_VarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VarauksenPalvelut.Location = new System.Drawing.Point(6, 30);
            this.dataGridView_VarauksenPalvelut.Name = "dataGridView_VarauksenPalvelut";
            this.dataGridView_VarauksenPalvelut.RowTemplate.Height = 28;
            this.dataGridView_VarauksenPalvelut.Size = new System.Drawing.Size(762, 159);
            this.dataGridView_VarauksenPalvelut.TabIndex = 0;
            // 
            // label_AsiakasNimi
            // 
            this.label_AsiakasNimi.AutoSize = true;
            this.label_AsiakasNimi.Location = new System.Drawing.Point(142, 42);
            this.label_AsiakasNimi.Name = "label_AsiakasNimi";
            this.label_AsiakasNimi.Size = new System.Drawing.Size(43, 20);
            this.label_AsiakasNimi.TabIndex = 1;
            this.label_AsiakasNimi.Text = "NIMI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_MaksajaEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_MaksajaPostinro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_MaksajaPostitoimipaikka);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_MaksajaLahiosoite);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_MaksajaNimi);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laskutustiedot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email:";
            // 
            // textBox_MaksajaEmail
            // 
            this.textBox_MaksajaEmail.Location = new System.Drawing.Point(139, 139);
            this.textBox_MaksajaEmail.Name = "textBox_MaksajaEmail";
            this.textBox_MaksajaEmail.Size = new System.Drawing.Size(213, 26);
            this.textBox_MaksajaEmail.TabIndex = 4;
            this.textBox_MaksajaEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaksajaEmail_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Postinumero:";
            // 
            // textBox_MaksajaPostinro
            // 
            this.textBox_MaksajaPostinro.Location = new System.Drawing.Point(139, 114);
            this.textBox_MaksajaPostinro.Name = "textBox_MaksajaPostinro";
            this.textBox_MaksajaPostinro.Size = new System.Drawing.Size(213, 26);
            this.textBox_MaksajaPostinro.TabIndex = 3;
            this.textBox_MaksajaPostinro.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaksajaPostinro_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Postitoimipaikka:";
            // 
            // textBox_MaksajaPostitoimipaikka
            // 
            this.textBox_MaksajaPostitoimipaikka.Location = new System.Drawing.Point(139, 89);
            this.textBox_MaksajaPostitoimipaikka.Name = "textBox_MaksajaPostitoimipaikka";
            this.textBox_MaksajaPostitoimipaikka.Size = new System.Drawing.Size(213, 26);
            this.textBox_MaksajaPostitoimipaikka.TabIndex = 2;
            this.textBox_MaksajaPostitoimipaikka.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaksajaPostitoimipaikka_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Lähiosoite:";
            // 
            // textBox_MaksajaLahiosoite
            // 
            this.textBox_MaksajaLahiosoite.Location = new System.Drawing.Point(139, 64);
            this.textBox_MaksajaLahiosoite.Name = "textBox_MaksajaLahiosoite";
            this.textBox_MaksajaLahiosoite.Size = new System.Drawing.Size(213, 26);
            this.textBox_MaksajaLahiosoite.TabIndex = 1;
            this.textBox_MaksajaLahiosoite.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaksajaLahiosoite_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nimi:";
            // 
            // textBox_MaksajaNimi
            // 
            this.textBox_MaksajaNimi.Location = new System.Drawing.Point(139, 39);
            this.textBox_MaksajaNimi.Name = "textBox_MaksajaNimi";
            this.textBox_MaksajaNimi.Size = new System.Drawing.Size(213, 26);
            this.textBox_MaksajaNimi.TabIndex = 0;
            this.textBox_MaksajaNimi.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaksajaNimi_Validating);
            // 
            // groupBox_Varaajantiedot
            // 
            this.groupBox_Varaajantiedot.Controls.Add(this.label5);
            this.groupBox_Varaajantiedot.Controls.Add(this.label4);
            this.groupBox_Varaajantiedot.Controls.Add(this.label3);
            this.groupBox_Varaajantiedot.Controls.Add(this.label2);
            this.groupBox_Varaajantiedot.Controls.Add(this.label1);
            this.groupBox_Varaajantiedot.Controls.Add(this.label_AsiakasEmail);
            this.groupBox_Varaajantiedot.Controls.Add(this.label_AsiakasPostinro);
            this.groupBox_Varaajantiedot.Controls.Add(this.label_AsiakasNimi);
            this.groupBox_Varaajantiedot.Controls.Add(this.label_AsiakasPostitoimipaikka);
            this.groupBox_Varaajantiedot.Controls.Add(this.label_AsiakasLahiosoite);
            this.groupBox_Varaajantiedot.Controls.Add(this.checkBox_LaskutusOsoite);
            this.groupBox_Varaajantiedot.Location = new System.Drawing.Point(18, 12);
            this.groupBox_Varaajantiedot.Name = "groupBox_Varaajantiedot";
            this.groupBox_Varaajantiedot.Size = new System.Drawing.Size(373, 219);
            this.groupBox_Varaajantiedot.TabIndex = 1;
            this.groupBox_Varaajantiedot.TabStop = false;
            this.groupBox_Varaajantiedot.Text = "Varaajan tiedot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postinumero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Postitoimipaikka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lähiosoite:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nimi:";
            // 
            // label_AsiakasEmail
            // 
            this.label_AsiakasEmail.AutoSize = true;
            this.label_AsiakasEmail.Location = new System.Drawing.Point(142, 142);
            this.label_AsiakasEmail.Name = "label_AsiakasEmail";
            this.label_AsiakasEmail.Size = new System.Drawing.Size(58, 20);
            this.label_AsiakasEmail.TabIndex = 6;
            this.label_AsiakasEmail.Text = "EMAIL";
            // 
            // label_AsiakasPostinro
            // 
            this.label_AsiakasPostinro.AutoSize = true;
            this.label_AsiakasPostinro.Location = new System.Drawing.Point(142, 117);
            this.label_AsiakasPostinro.Name = "label_AsiakasPostinro";
            this.label_AsiakasPostinro.Size = new System.Drawing.Size(91, 20);
            this.label_AsiakasPostinro.TabIndex = 5;
            this.label_AsiakasPostinro.Text = "POSTINRO";
            // 
            // label_AsiakasPostitoimipaikka
            // 
            this.label_AsiakasPostitoimipaikka.AutoSize = true;
            this.label_AsiakasPostitoimipaikka.Location = new System.Drawing.Point(142, 92);
            this.label_AsiakasPostitoimipaikka.Name = "label_AsiakasPostitoimipaikka";
            this.label_AsiakasPostitoimipaikka.Size = new System.Drawing.Size(157, 20);
            this.label_AsiakasPostitoimipaikka.TabIndex = 4;
            this.label_AsiakasPostitoimipaikka.Text = "POSTITOIMIPAIKKA";
            // 
            // label_AsiakasLahiosoite
            // 
            this.label_AsiakasLahiosoite.AutoSize = true;
            this.label_AsiakasLahiosoite.Location = new System.Drawing.Point(142, 67);
            this.label_AsiakasLahiosoite.Name = "label_AsiakasLahiosoite";
            this.label_AsiakasLahiosoite.Size = new System.Drawing.Size(106, 20);
            this.label_AsiakasLahiosoite.TabIndex = 3;
            this.label_AsiakasLahiosoite.Text = "LÄHIOSOITE";
            // 
            // checkBox_LaskutusOsoite
            // 
            this.checkBox_LaskutusOsoite.AutoSize = true;
            this.checkBox_LaskutusOsoite.Location = new System.Drawing.Point(10, 182);
            this.checkBox_LaskutusOsoite.Name = "checkBox_LaskutusOsoite";
            this.checkBox_LaskutusOsoite.Size = new System.Drawing.Size(245, 24);
            this.checkBox_LaskutusOsoite.TabIndex = 0;
            this.checkBox_LaskutusOsoite.Text = "Laskutusosoite sama kuin yllä";
            this.checkBox_LaskutusOsoite.UseVisualStyleBackColor = true;
            this.checkBox_LaskutusOsoite.CheckedChanged += new System.EventHandler(this.checkBox_LaskutusOsoite_CheckedChanged);
            // 
            // errorProvider_MaksajaNimi
            // 
            this.errorProvider_MaksajaNimi.ContainerControl = this;
            // 
            // errorProvider_MaksajaLahiosoite
            // 
            this.errorProvider_MaksajaLahiosoite.ContainerControl = this;
            // 
            // errorProvider_MaksajaPostitoimipaikka
            // 
            this.errorProvider_MaksajaPostitoimipaikka.ContainerControl = this;
            // 
            // errorProvider_MaksajaPostinro
            // 
            this.errorProvider_MaksajaPostinro.ContainerControl = this;
            // 
            // errorProvider_MaksajaEmail
            // 
            this.errorProvider_MaksajaEmail.ContainerControl = this;
            // 
            // LisaaLasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.ControlBox = false;
            this.Controls.Add(this.button_Peruuta);
            this.Controls.Add(this.groupBox_Varaajantiedot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_LuoLasku);
            this.Controls.Add(this.groupBox_Varaustiedot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LisaaLasku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LisaaLasku";
            this.Load += new System.EventHandler(this.LisaaLasku_Load);
            this.groupBox_Varaustiedot.ResumeLayout(false);
            this.groupBox_Varaustiedot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VarauksenPalvelut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Varaajantiedot.ResumeLayout(false);
            this.groupBox_Varaajantiedot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaNimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaLahiosoite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaPostitoimipaikka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaPostinro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MaksajaEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Peruuta;
        private System.Windows.Forms.Button button_LuoLasku;
        private System.Windows.Forms.GroupBox groupBox_Varaustiedot;
        private System.Windows.Forms.DataGridView dataGridView_VarauksenPalvelut;
        public System.Windows.Forms.Label label_AsiakasNimi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_MaksajaPostitoimipaikka;
        private System.Windows.Forms.TextBox textBox_MaksajaLahiosoite;
        private System.Windows.Forms.TextBox textBox_MaksajaNimi;
        private System.Windows.Forms.GroupBox groupBox_Varaajantiedot;
        public System.Windows.Forms.Label label_AsiakasPostitoimipaikka;
        public System.Windows.Forms.Label label_AsiakasLahiosoite;
        private System.Windows.Forms.CheckBox checkBox_LaskutusOsoite;
        private System.Windows.Forms.Label label_Yhteensa;
        private System.Windows.Forms.Label label_Summa;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_MaksajaEmail;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaksajaPostinro;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_AsiakasEmail;
        public System.Windows.Forms.Label label_AsiakasPostinro;
        private System.Windows.Forms.ErrorProvider errorProvider_MaksajaNimi;
        private System.Windows.Forms.ErrorProvider errorProvider_MaksajaLahiosoite;
        private System.Windows.Forms.ErrorProvider errorProvider_MaksajaPostitoimipaikka;
        private System.Windows.Forms.ErrorProvider errorProvider_MaksajaPostinro;
        private System.Windows.Forms.ErrorProvider errorProvider_MaksajaEmail;
    }
}