using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace mokkivaraus
{
    public partial class Raportti_V3 : Form
    {
        public Raportti_V3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection((@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"));
        

        private void Raportti_V3_Load(object sender, EventArgs e)
        {

        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }


        // Hae tiedot -painike lataa tiedot reportVieweriin huomioiden syötetyt päiväykset.

        private void btnHaeTiedot_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkivarausDataSet.Varaus' table. You can move, or remove it, as needed.
            this.VarausTableAdapter.Fill(this.mokkivarausDataSet.Varaus);
            // TODO: This line of code loads data into the 'mokkivarausDataSet.Palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.mokkivarausDataSet.Palvelu);
            // TODO: This line of code loads data into the 'mokkivarausDataSet.Toimipiste' table. You can move, or remove it, as needed.
            this.ToimipisteTableAdapter.Fill(this.mokkivarausDataSet.Toimipiste);
            this.reportViewer1.RefreshReport();
        }

        // Päävalikkoon -painike: sulkee raportti-ikkunan.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        // Tyhjennä -painike: tyhjentää tiedot report Viewistä
        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToimipisteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.VarausTableAdapter.FillByToimipiste(this.mokkivarausDataSet.Varaus, new System.Nullable<int>(((int)(System.Convert.ChangeType(toimipiste_idToolStripTextBox.Text, typeof(int))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

