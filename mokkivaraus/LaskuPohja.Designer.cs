namespace mokkivaraus
{
    partial class LaskuPohja
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
            this.reportViewer_LaskuPohja = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_LaskuPohja
            // 
            this.reportViewer_LaskuPohja.LocalReport.ReportEmbeddedResource = "mokkivaraus.LaskuPohja.rdlc";
            this.reportViewer_LaskuPohja.Location = new System.Drawing.Point(13, 13);
            this.reportViewer_LaskuPohja.Name = "reportViewer_LaskuPohja";
            this.reportViewer_LaskuPohja.ServerReport.BearerToken = null;
            this.reportViewer_LaskuPohja.ShowFindControls = false;
            this.reportViewer_LaskuPohja.ShowRefreshButton = false;
            this.reportViewer_LaskuPohja.ShowStopButton = false;
            this.reportViewer_LaskuPohja.Size = new System.Drawing.Size(838, 641);
            this.reportViewer_LaskuPohja.TabIndex = 0;
            // 
            // LaskuPohja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(863, 666);
            this.Controls.Add(this.reportViewer_LaskuPohja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LaskuPohja";
            this.Text = "Lasku";
            this.Load += new System.EventHandler(this.LaskuPohja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_LaskuPohja;
    }
}