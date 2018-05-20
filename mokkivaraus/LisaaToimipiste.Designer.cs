namespace mokkivaraus
{
    partial class LisaaToimipiste
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
            this.button_ToimipisteOk = new System.Windows.Forms.Button();
            this.button_ToimipistePeruuta = new System.Windows.Forms.Button();
            this.textBox_Nimi = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Osoite = new System.Windows.Forms.TextBox();
            this.textBox_Postitoimipaikka = new System.Windows.Forms.TextBox();
            this.textBox_Postinumero = new System.Windows.Forms.TextBox();
            this.textBox_PuhelinNro = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Osoite = new System.Windows.Forms.Label();
            this.label_PuhelinNro = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Nimi = new System.Windows.Forms.Label();
            this.label_Postitoimipaikka = new System.Windows.Forms.Label();
            this.label_Postinumero = new System.Windows.Forms.Label();
            this.erProvTeksti = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ToimipisteOk
            // 
            this.button_ToimipisteOk.Location = new System.Drawing.Point(315, 278);
            this.button_ToimipisteOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ToimipisteOk.Name = "button_ToimipisteOk";
            this.button_ToimipisteOk.Size = new System.Drawing.Size(112, 35);
            this.button_ToimipisteOk.TabIndex = 0;
            this.button_ToimipisteOk.Text = "Ok";
            this.button_ToimipisteOk.UseVisualStyleBackColor = true;
            this.button_ToimipisteOk.Click += new System.EventHandler(this.button_ToimipisteOk_Click);
            // 
            // button_ToimipistePeruuta
            // 
            this.button_ToimipistePeruuta.Location = new System.Drawing.Point(436, 278);
            this.button_ToimipistePeruuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ToimipistePeruuta.Name = "button_ToimipistePeruuta";
            this.button_ToimipistePeruuta.Size = new System.Drawing.Size(112, 35);
            this.button_ToimipistePeruuta.TabIndex = 1;
            this.button_ToimipistePeruuta.Text = "Peruuta";
            this.button_ToimipistePeruuta.UseVisualStyleBackColor = true;
            this.button_ToimipistePeruuta.Click += new System.EventHandler(this.button_ToimipistePeruuta_Click);
            // 
            // textBox_Nimi
            // 
            this.textBox_Nimi.Location = new System.Drawing.Point(315, 43);
            this.textBox_Nimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Nimi.MaxLength = 40;
            this.textBox_Nimi.Name = "textBox_Nimi";
            this.textBox_Nimi.Size = new System.Drawing.Size(232, 26);
            this.textBox_Nimi.TabIndex = 2;
            this.textBox_Nimi.TextChanged += new System.EventHandler(this.textBox_Nimi_TextChanged);
            this.textBox_Nimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirNumViiVal);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(18, 43);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(232, 26);
            this.textBox_Id.TabIndex = 3;
            this.textBox_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // textBox_Osoite
            // 
            this.textBox_Osoite.Location = new System.Drawing.Point(18, 123);
            this.textBox_Osoite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Osoite.MaxLength = 40;
            this.textBox_Osoite.Name = "textBox_Osoite";
            this.textBox_Osoite.Size = new System.Drawing.Size(232, 26);
            this.textBox_Osoite.TabIndex = 4;
            this.textBox_Osoite.TextChanged += new System.EventHandler(this.textBox_Osoite_TextChanged);
            this.textBox_Osoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirNumViiVal);
            // 
            // textBox_Postitoimipaikka
            // 
            this.textBox_Postitoimipaikka.Location = new System.Drawing.Point(315, 123);
            this.textBox_Postitoimipaikka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Postitoimipaikka.MaxLength = 30;
            this.textBox_Postitoimipaikka.Name = "textBox_Postitoimipaikka";
            this.textBox_Postitoimipaikka.Size = new System.Drawing.Size(232, 26);
            this.textBox_Postitoimipaikka.TabIndex = 5;
            this.textBox_Postitoimipaikka.TextChanged += new System.EventHandler(this.textBox_Postitoimipaikka_TextChanged);
            this.textBox_Postitoimipaikka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressKirVii);
            // 
            // textBox_Postinumero
            // 
            this.textBox_Postinumero.Location = new System.Drawing.Point(315, 203);
            this.textBox_Postinumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Postinumero.MaxLength = 5;
            this.textBox_Postinumero.Name = "textBox_Postinumero";
            this.textBox_Postinumero.Size = new System.Drawing.Size(232, 26);
            this.textBox_Postinumero.TabIndex = 6;
            this.textBox_Postinumero.TextChanged += new System.EventHandler(this.textBox_Postinumero_TextChanged);
            this.textBox_Postinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // textBox_PuhelinNro
            // 
            this.textBox_PuhelinNro.Location = new System.Drawing.Point(18, 203);
            this.textBox_PuhelinNro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_PuhelinNro.MaxLength = 15;
            this.textBox_PuhelinNro.Name = "textBox_PuhelinNro";
            this.textBox_PuhelinNro.Size = new System.Drawing.Size(232, 26);
            this.textBox_PuhelinNro.TabIndex = 7;
            this.textBox_PuhelinNro.TextChanged += new System.EventHandler(this.textBox_PuhelinNro_TextChanged);
            this.textBox_PuhelinNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressNum);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(18, 283);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Email.MaxLength = 50;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(232, 26);
            this.textBox_Email.TabIndex = 8;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            this.textBox_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPressEiVal);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(18, 14);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(26, 20);
            this.label_Id.TabIndex = 9;
            this.label_Id.Text = "ID";
            // 
            // label_Osoite
            // 
            this.label_Osoite.AutoSize = true;
            this.label_Osoite.Location = new System.Drawing.Point(18, 98);
            this.label_Osoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Osoite.Name = "label_Osoite";
            this.label_Osoite.Size = new System.Drawing.Size(82, 20);
            this.label_Osoite.TabIndex = 10;
            this.label_Osoite.Text = "Lähiosoite";
            // 
            // label_PuhelinNro
            // 
            this.label_PuhelinNro.AutoSize = true;
            this.label_PuhelinNro.Location = new System.Drawing.Point(18, 178);
            this.label_PuhelinNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PuhelinNro.Name = "label_PuhelinNro";
            this.label_PuhelinNro.Size = new System.Drawing.Size(115, 20);
            this.label_PuhelinNro.TabIndex = 11;
            this.label_PuhelinNro.Text = "Puhelinnumero";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(18, 258);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(132, 20);
            this.label_Email.TabIndex = 12;
            this.label_Email.Text = "Sähköpostiosoite";
            // 
            // label_Nimi
            // 
            this.label_Nimi.AutoSize = true;
            this.label_Nimi.Location = new System.Drawing.Point(310, 18);
            this.label_Nimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nimi.Name = "label_Nimi";
            this.label_Nimi.Size = new System.Drawing.Size(126, 20);
            this.label_Nimi.TabIndex = 13;
            this.label_Nimi.Text = "Toimipisteet nimi";
            // 
            // label_Postitoimipaikka
            // 
            this.label_Postitoimipaikka.AutoSize = true;
            this.label_Postitoimipaikka.Location = new System.Drawing.Point(310, 98);
            this.label_Postitoimipaikka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Postitoimipaikka.Name = "label_Postitoimipaikka";
            this.label_Postitoimipaikka.Size = new System.Drawing.Size(123, 20);
            this.label_Postitoimipaikka.TabIndex = 14;
            this.label_Postitoimipaikka.Text = "Postitoimipaikka";
            // 
            // label_Postinumero
            // 
            this.label_Postinumero.AutoSize = true;
            this.label_Postinumero.Location = new System.Drawing.Point(310, 178);
            this.label_Postinumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Postinumero.Name = "label_Postinumero";
            this.label_Postinumero.Size = new System.Drawing.Size(98, 20);
            this.label_Postinumero.TabIndex = 15;
            this.label_Postinumero.Text = "Postinumero";
            // 
            // erProvTeksti
            // 
            this.erProvTeksti.ContainerControl = this;
            // 
            // LisaaToimipiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(574, 338);
            this.ControlBox = false;
            this.Controls.Add(this.label_Postinumero);
            this.Controls.Add(this.label_Postitoimipaikka);
            this.Controls.Add(this.label_Nimi);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_PuhelinNro);
            this.Controls.Add(this.label_Osoite);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PuhelinNro);
            this.Controls.Add(this.textBox_Postinumero);
            this.Controls.Add(this.textBox_Postitoimipaikka);
            this.Controls.Add(this.textBox_Osoite);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.textBox_Nimi);
            this.Controls.Add(this.button_ToimipistePeruuta);
            this.Controls.Add(this.button_ToimipisteOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LisaaToimipiste";
            this.Text = "Lisää toimipiste";
            this.Load += new System.EventHandler(this.LisaaToimipiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erProvTeksti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ToimipisteOk;
        private System.Windows.Forms.Button button_ToimipistePeruuta;
        private System.Windows.Forms.TextBox textBox_Nimi;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Osoite;
        private System.Windows.Forms.TextBox textBox_Postitoimipaikka;
        private System.Windows.Forms.TextBox textBox_Postinumero;
        private System.Windows.Forms.TextBox textBox_PuhelinNro;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Osoite;
        private System.Windows.Forms.Label label_PuhelinNro;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Nimi;
        private System.Windows.Forms.Label label_Postitoimipaikka;
        private System.Windows.Forms.Label label_Postinumero;
        private System.Windows.Forms.ErrorProvider erProvTeksti;
    }
}