namespace mokkivaraus
{
    partial class PaaValikko
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
            this.button_Asiakastiedot = new System.Windows.Forms.Button();
            this.button_Varaukset = new System.Windows.Forms.Button();
            this.button_Toimipaikat = new System.Windows.Forms.Button();
            this.button_Laskutus = new System.Windows.Forms.Button();
            this.button_Poistu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Asiakastiedot
            // 
            this.button_Asiakastiedot.Location = new System.Drawing.Point(63, 77);
            this.button_Asiakastiedot.Name = "button_Asiakastiedot";
            this.button_Asiakastiedot.Size = new System.Drawing.Size(201, 37);
            this.button_Asiakastiedot.TabIndex = 0;
            this.button_Asiakastiedot.Text = "Asiakastiedot";
            this.button_Asiakastiedot.UseVisualStyleBackColor = true;
            this.button_Asiakastiedot.Click += new System.EventHandler(this.button_Asiakastiedot_Click);
            // 
            // button_Varaukset
            // 
            this.button_Varaukset.Location = new System.Drawing.Point(63, 123);
            this.button_Varaukset.Name = "button_Varaukset";
            this.button_Varaukset.Size = new System.Drawing.Size(201, 37);
            this.button_Varaukset.TabIndex = 1;
            this.button_Varaukset.Text = "Varaukset";
            this.button_Varaukset.UseVisualStyleBackColor = true;
            this.button_Varaukset.Click += new System.EventHandler(this.button_Varaukset_Click);
            // 
            // button_Toimipaikat
            // 
            this.button_Toimipaikat.Location = new System.Drawing.Point(63, 165);
            this.button_Toimipaikat.Name = "button_Toimipaikat";
            this.button_Toimipaikat.Size = new System.Drawing.Size(201, 37);
            this.button_Toimipaikat.TabIndex = 2;
            this.button_Toimipaikat.Text = "Toimipaikat ja palvelut";
            this.button_Toimipaikat.UseVisualStyleBackColor = true;
            this.button_Toimipaikat.Click += new System.EventHandler(this.button_Toimipaikat_Click);
            // 
            // button_Laskutus
            // 
            this.button_Laskutus.Location = new System.Drawing.Point(63, 209);
            this.button_Laskutus.Name = "button_Laskutus";
            this.button_Laskutus.Size = new System.Drawing.Size(201, 37);
            this.button_Laskutus.TabIndex = 3;
            this.button_Laskutus.Text = "Laskutus";
            this.button_Laskutus.UseVisualStyleBackColor = true;
            this.button_Laskutus.Click += new System.EventHandler(this.button_Laskutus_Click);
            // 
            // button_Poistu
            // 
            this.button_Poistu.Location = new System.Drawing.Point(63, 300);
            this.button_Poistu.Name = "button_Poistu";
            this.button_Poistu.Size = new System.Drawing.Size(201, 37);
            this.button_Poistu.TabIndex = 4;
            this.button_Poistu.Text = "Poistu";
            this.button_Poistu.UseVisualStyleBackColor = true;
            this.button_Poistu.Click += new System.EventHandler(this.button_Poistu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Raportti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaaValikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Poistu);
            this.Controls.Add(this.button_Laskutus);
            this.Controls.Add(this.button_Toimipaikat);
            this.Controls.Add(this.button_Varaukset);
            this.Controls.Add(this.button_Asiakastiedot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaaValikko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökkien varausjärjestelmä 3000";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Asiakastiedot;
        private System.Windows.Forms.Button button_Varaukset;
        private System.Windows.Forms.Button button_Toimipaikat;
        private System.Windows.Forms.Button button_Laskutus;
        private System.Windows.Forms.Button button_Poistu;
        private System.Windows.Forms.Button button1;
    }
}

