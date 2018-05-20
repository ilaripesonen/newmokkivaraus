namespace mokkivaraus
{
    partial class MuokkaaPalvelua
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
            this.btn_Peruuta = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.tb_ALV = new System.Windows.Forms.TextBox();
            this.tb_Hinta = new System.Windows.Forms.TextBox();
            this.tb_Tyyppi = new System.Windows.Forms.TextBox();
            this.tb_Kuvaus = new System.Windows.Forms.TextBox();
            this.tb_PalvelunNimi = new System.Windows.Forms.TextBox();
            this.tb_ToimipisteID = new System.Windows.Forms.TextBox();
            this.lb_Alv = new System.Windows.Forms.Label();
            this.lb_Hinta = new System.Windows.Forms.Label();
            this.lb_Kuvaus = new System.Windows.Forms.Label();
            this.lb_Tyyppi = new System.Windows.Forms.Label();
            this.lb_PalvelunNimi = new System.Windows.Forms.Label();
            this.lb_ToimipisteID = new System.Windows.Forms.Label();
            this.erProvTeksti = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Peruuta
            // 
            this.btn_Peruuta.Location = new System.Drawing.Point(208, 296);
            this.btn_Peruuta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Peruuta.Name = "btn_Peruuta";
            this.btn_Peruuta.Size = new System.Drawing.Size(114, 44);
            this.btn_Peruuta.TabIndex = 27;
            this.btn_Peruuta.Text = "Peruuta";
            this.btn_Peruuta.UseVisualStyleBackColor = true;
            this.btn_Peruuta.Click += new System.EventHandler(this.btn_Peruuta_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(56, 296);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(114, 44);
            this.btn_Ok.TabIndex = 26;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // tb_ALV
            // 
            this.tb_ALV.Location = new System.Drawing.Point(299, 224);
            this.tb_ALV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ALV.Name = "tb_ALV";
            this.tb_ALV.Size = new System.Drawing.Size(63, 26);
            this.tb_ALV.TabIndex = 25;
            this.tb_ALV.TextChanged += new System.EventHandler(this.tb_ALV_TextChanged);
            this.tb_ALV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumPis);
            // 
            // tb_Hinta
            // 
            this.tb_Hinta.Location = new System.Drawing.Point(134, 224);
            this.tb_Hinta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Hinta.Name = "tb_Hinta";
            this.tb_Hinta.Size = new System.Drawing.Size(120, 26);
            this.tb_Hinta.TabIndex = 24;
            this.tb_Hinta.TextChanged += new System.EventHandler(this.tb_Hinta_TextChanged);
            this.tb_Hinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumPis);
            // 
            // tb_Tyyppi
            // 
            this.tb_Tyyppi.Location = new System.Drawing.Point(21, 224);
            this.tb_Tyyppi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Tyyppi.Name = "tb_Tyyppi";
            this.tb_Tyyppi.Size = new System.Drawing.Size(66, 26);
            this.tb_Tyyppi.TabIndex = 23;
            this.tb_Tyyppi.TextChanged += new System.EventHandler(this.tb_Tyyppi_TextChanged);
            this.tb_Tyyppi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // tb_Kuvaus
            // 
            this.tb_Kuvaus.Location = new System.Drawing.Point(21, 97);
            this.tb_Kuvaus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Kuvaus.MaxLength = 255;
            this.tb_Kuvaus.Multiline = true;
            this.tb_Kuvaus.Name = "tb_Kuvaus";
            this.tb_Kuvaus.Size = new System.Drawing.Size(341, 76);
            this.tb_Kuvaus.TabIndex = 22;
            this.tb_Kuvaus.TextChanged += new System.EventHandler(this.tb_Kuvaus_TextChanged);
            // 
            // tb_PalvelunNimi
            // 
            this.tb_PalvelunNimi.Location = new System.Drawing.Point(156, 29);
            this.tb_PalvelunNimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_PalvelunNimi.Name = "tb_PalvelunNimi";
            this.tb_PalvelunNimi.Size = new System.Drawing.Size(206, 26);
            this.tb_PalvelunNimi.TabIndex = 21;
            this.tb_PalvelunNimi.TextChanged += new System.EventHandler(this.tb_PalvelunNimi_TextChanged);
            // 
            // tb_ToimipisteID
            // 
            this.tb_ToimipisteID.Location = new System.Drawing.Point(21, 29);
            this.tb_ToimipisteID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ToimipisteID.Name = "tb_ToimipisteID";
            this.tb_ToimipisteID.Size = new System.Drawing.Size(98, 26);
            this.tb_ToimipisteID.TabIndex = 20;
            this.tb_ToimipisteID.TextChanged += new System.EventHandler(this.tb_ToimipisteID_TextChanged);
            this.tb_ToimipisteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // lb_Alv
            // 
            this.lb_Alv.AutoSize = true;
            this.lb_Alv.Location = new System.Drawing.Point(296, 202);
            this.lb_Alv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Alv.Name = "lb_Alv";
            this.lb_Alv.Size = new System.Drawing.Size(40, 20);
            this.lb_Alv.TabIndex = 19;
            this.lb_Alv.Text = "ALV";
            // 
            // lb_Hinta
            // 
            this.lb_Hinta.AutoSize = true;
            this.lb_Hinta.Location = new System.Drawing.Point(131, 202);
            this.lb_Hinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Hinta.Name = "lb_Hinta";
            this.lb_Hinta.Size = new System.Drawing.Size(47, 20);
            this.lb_Hinta.TabIndex = 18;
            this.lb_Hinta.Text = "Hinta";
            // 
            // lb_Kuvaus
            // 
            this.lb_Kuvaus.AutoSize = true;
            this.lb_Kuvaus.Location = new System.Drawing.Point(18, 74);
            this.lb_Kuvaus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Kuvaus.Name = "lb_Kuvaus";
            this.lb_Kuvaus.Size = new System.Drawing.Size(61, 20);
            this.lb_Kuvaus.TabIndex = 17;
            this.lb_Kuvaus.Text = "Kuvaus";
            // 
            // lb_Tyyppi
            // 
            this.lb_Tyyppi.AutoSize = true;
            this.lb_Tyyppi.Location = new System.Drawing.Point(18, 202);
            this.lb_Tyyppi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tyyppi.Name = "lb_Tyyppi";
            this.lb_Tyyppi.Size = new System.Drawing.Size(53, 20);
            this.lb_Tyyppi.TabIndex = 16;
            this.lb_Tyyppi.Text = "Tyyppi";
            // 
            // lb_PalvelunNimi
            // 
            this.lb_PalvelunNimi.AutoSize = true;
            this.lb_PalvelunNimi.Location = new System.Drawing.Point(153, 7);
            this.lb_PalvelunNimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PalvelunNimi.Name = "lb_PalvelunNimi";
            this.lb_PalvelunNimi.Size = new System.Drawing.Size(100, 20);
            this.lb_PalvelunNimi.TabIndex = 15;
            this.lb_PalvelunNimi.Text = "Palvelun nimi";
            // 
            // lb_ToimipisteID
            // 
            this.lb_ToimipisteID.AutoSize = true;
            this.lb_ToimipisteID.Location = new System.Drawing.Point(18, 7);
            this.lb_ToimipisteID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ToimipisteID.Name = "lb_ToimipisteID";
            this.lb_ToimipisteID.Size = new System.Drawing.Size(101, 20);
            this.lb_ToimipisteID.TabIndex = 14;
            this.lb_ToimipisteID.Text = "Toimipiste ID";
            // 
            // erProvTeksti
            // 
            this.erProvTeksti.ContainerControl = this;
            // 
            // MuokkaaPalvelua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(391, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Peruuta);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.tb_ALV);
            this.Controls.Add(this.tb_Hinta);
            this.Controls.Add(this.tb_Tyyppi);
            this.Controls.Add(this.tb_Kuvaus);
            this.Controls.Add(this.tb_PalvelunNimi);
            this.Controls.Add(this.tb_ToimipisteID);
            this.Controls.Add(this.lb_Alv);
            this.Controls.Add(this.lb_Hinta);
            this.Controls.Add(this.lb_Kuvaus);
            this.Controls.Add(this.lb_Tyyppi);
            this.Controls.Add(this.lb_PalvelunNimi);
            this.Controls.Add(this.lb_ToimipisteID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MuokkaaPalvelua";
            this.Text = "MuokkaaPalvelua";
            this.Load += new System.EventHandler(this.MuokkaaPalvelua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Peruuta;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox tb_ALV;
        private System.Windows.Forms.TextBox tb_Hinta;
        private System.Windows.Forms.TextBox tb_Tyyppi;
        private System.Windows.Forms.TextBox tb_Kuvaus;
        private System.Windows.Forms.TextBox tb_PalvelunNimi;
        private System.Windows.Forms.TextBox tb_ToimipisteID;
        private System.Windows.Forms.Label lb_Alv;
        private System.Windows.Forms.Label lb_Hinta;
        private System.Windows.Forms.Label lb_Kuvaus;
        private System.Windows.Forms.Label lb_Tyyppi;
        private System.Windows.Forms.Label lb_PalvelunNimi;
        private System.Windows.Forms.Label lb_ToimipisteID;
        private System.Windows.Forms.ErrorProvider erProvTeksti;
    }
}