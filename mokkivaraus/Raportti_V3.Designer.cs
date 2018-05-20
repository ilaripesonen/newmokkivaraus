namespace mokkivaraus
{
    partial class Raportti_V3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportti_V3));
            this.ToimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkivarausDataSet = new mokkivaraus.mokkivarausDataSet();
            this.VarausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToimipisteTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.ToimipisteTableAdapter();
            this.btnHaeTiedot = new System.Windows.Forms.Button();
            this.fKPalvelutoimipi2F10007BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.PalveluTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VarausTableAdapter = new mokkivaraus.mokkivarausDataSetTableAdapters.VarausTableAdapter();
            this.dateAlku = new System.Windows.Forms.DateTimePicker();
            this.dateLoppu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new mokkivaraus.mokkivarausDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fillByToimipisteToolStrip = new System.Windows.Forms.ToolStrip();
            this.toimipiste_idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toimipiste_idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToimipisteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ToimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPalvelutoimipi2F10007BBindingSource)).BeginInit();
            this.fillByToimipisteToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToimipisteBindingSource
            // 
            this.ToimipisteBindingSource.DataMember = "Toimipiste";
            this.ToimipisteBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // mokkivarausDataSet
            // 
            this.mokkivarausDataSet.DataSetName = "mokkivarausDataSet";
            this.mokkivarausDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VarausBindingSource
            // 
            this.VarausBindingSource.DataMember = "Varaus";
            this.VarausBindingSource.DataSource = this.mokkivarausDataSet;
            // 
            // ToimipisteTableAdapter
            // 
            this.ToimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // btnHaeTiedot
            // 
            this.btnHaeTiedot.Location = new System.Drawing.Point(486, 35);
            this.btnHaeTiedot.Name = "btnHaeTiedot";
            this.btnHaeTiedot.Size = new System.Drawing.Size(101, 24);
            this.btnHaeTiedot.TabIndex = 2;
            this.btnHaeTiedot.Text = "Hae tiedot";
            this.btnHaeTiedot.UseVisualStyleBackColor = true;
            this.btnHaeTiedot.Click += new System.EventHandler(this.btnHaeTiedot_Click);
            // 
            // fKPalvelutoimipi2F10007BBindingSource
            // 
            this.fKPalvelutoimipi2F10007BBindingSource.DataMember = "FK__Palvelu__toimipi__2F10007B";
            this.fKPalvelutoimipi2F10007BBindingSource.DataSource = this.ToimipisteBindingSource;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "Raportti";
            reportDataSource7.Value = this.ToimipisteBindingSource;
            reportDataSource8.Name = "Palvelu";
            reportDataSource8.Value = this.VarausBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "mokkivaraus.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 380);
            this.reportViewer1.TabIndex = 3;
            // 
            // VarausTableAdapter
            // 
            this.VarausTableAdapter.ClearBeforeFill = true;
            // 
            // dateAlku
            // 
            this.dateAlku.CustomFormat = "dd/MM/yyyy";
            this.dateAlku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAlku.Location = new System.Drawing.Point(91, 39);
            this.dateAlku.Name = "dateAlku";
            this.dateAlku.Size = new System.Drawing.Size(166, 20);
            this.dateAlku.TabIndex = 4;
            // 
            // dateLoppu
            // 
            this.dateLoppu.CustomFormat = "dd/MM/yyyy";
            this.dateLoppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLoppu.Location = new System.Drawing.Point(91, 65);
            this.dateLoppu.Name = "dateLoppu";
            this.dateLoppu.Size = new System.Drawing.Size(166, 20);
            this.dateLoppu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alkupvm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loppupvm";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AsiakasTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LaskuTableAdapter = null;
            this.tableAdapterManager1.PalveluTableAdapter = this.palveluTableAdapter;
            this.tableAdapterManager1.ToimipisteTableAdapter = this.ToimipisteTableAdapter;
            this.tableAdapterManager1.UpdateOrder = mokkivaraus.mokkivarausDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Varauksen_palvelutTableAdapter = null;
            this.tableAdapterManager1.VarausTableAdapter = this.VarausTableAdapter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Päävalikkoon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tyhjennä";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fillByToimipisteToolStrip
            // 
            this.fillByToimipisteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toimipiste_idToolStripLabel,
            this.toimipiste_idToolStripTextBox,
            this.fillByToimipisteToolStripButton,
            this.toolStripButton1});
            this.fillByToimipisteToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToimipisteToolStrip.Name = "fillByToimipisteToolStrip";
            this.fillByToimipisteToolStrip.Size = new System.Drawing.Size(812, 25);
            this.fillByToimipisteToolStrip.TabIndex = 14;
            this.fillByToimipisteToolStrip.Text = "fillByToimipisteToolStrip";
            // 
            // toimipiste_idToolStripLabel
            // 
            this.toimipiste_idToolStripLabel.Name = "toimipiste_idToolStripLabel";
            this.toimipiste_idToolStripLabel.Size = new System.Drawing.Size(79, 22);
            this.toimipiste_idToolStripLabel.Text = "Toimipiste id:";
            // 
            // toimipiste_idToolStripTextBox
            // 
            this.toimipiste_idToolStripTextBox.Name = "toimipiste_idToolStripTextBox";
            this.toimipiste_idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToimipisteToolStripButton
            // 
            this.fillByToimipisteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToimipisteToolStripButton.Name = "fillByToimipisteToolStripButton";
            this.fillByToimipisteToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByToimipisteToolStripButton.Text = "Päivitä";
            this.fillByToimipisteToolStripButton.Click += new System.EventHandler(this.fillByToimipisteToolStripButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Raportti_V3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(812, 507);
            this.ControlBox = false;
            this.Controls.Add(this.fillByToimipisteToolStrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLoppu);
            this.Controls.Add(this.dateAlku);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnHaeTiedot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Raportti_V3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raportti_V3";
            this.Load += new System.EventHandler(this.Raportti_V3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkivarausDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPalvelutoimipi2F10007BBindingSource)).EndInit();
            this.fillByToimipisteToolStrip.ResumeLayout(false);
            this.fillByToimipisteToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ToimipisteBindingSource;
        private mokkivarausDataSet mokkivarausDataSet;
        private mokkivarausDataSetTableAdapters.ToimipisteTableAdapter ToimipisteTableAdapter;
        private System.Windows.Forms.Button btnHaeTiedot;
        private System.Windows.Forms.BindingSource fKPalvelutoimipi2F10007BBindingSource;
        private mokkivarausDataSetTableAdapters.PalveluTableAdapter palveluTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VarausBindingSource;
        private mokkivarausDataSetTableAdapters.VarausTableAdapter VarausTableAdapter;
        private System.Windows.Forms.DateTimePicker dateAlku;
        private System.Windows.Forms.DateTimePicker dateLoppu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private mokkivarausDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip fillByToimipisteToolStrip;
        private System.Windows.Forms.ToolStripLabel toimipiste_idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox toimipiste_idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToimipisteToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}