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
    public partial class LisääPalvelu : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"); // sulkuihin tietokannan connection string

        SqlCommand cmd = new SqlCommand();

        public LisääPalvelu()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko tallentaa tiedot tietokantaan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Tarkista, ettei tyhjiä kenttiä
                //tai tekstiä yli rajojen
                //Tallenna tiedot
                this.Hide();


                try
                {
                    cn.Open();

                    cmd.CommandText = "insert into Palvelu (toimipiste_id, nimi, tyyppi, kuvaus, hinta, alv) values ('" + tb_ToimipisteID.Text + "', '" + tb_PalvelunNimi.Text + "', '" + tb_Tyyppi.Text + "', '" + tb_Kuvaus.Text + "', '" + tb_Hinta.Text + "','" + tb_ALV.Text + "')";

                    cmd.ExecuteNonQuery();
                    cn.Close();
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(Yllapito))
                        {
                            Yllapito yp = (Yllapito)f;
                            yp.Enabled = true;
                            yp.paivitaPalvelut();
                            yp.BringToFront();
                        }
                    }
                    MessageBox.Show("Palvelu lisätty tietokantaan.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tietojen lisäys tietokantaan epäonnistui : {0}", ex.Message);
                    cn.Close();

                }
            }
        }

        private void LisääPalvelu_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void btn_Peruuta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Muutokset menetetään. Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(Yllapito))
                    {
                        Yllapito yp = (Yllapito)f;
                        yp.Enabled = true;
                        yp.BringToFront();
                    }
                }
                this.Hide();
            }
        }

        private void tbKeyPressNum(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.erProvTeksti.SetError(tb, "Käytä 0-9");
            }
            else
            {
                erProvTeksti.SetError(tb, "");
            }
        }

        private void tbNumPis(object sender, KeyPressEventArgs e)
        {

            TextBox tb = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                this.erProvTeksti.SetError(tb, "Käytä 0-9 ja pistettä '.' desimaalina");
            }
            else
            {
                erProvTeksti.SetError(tb, "");
            }
        }
    }
}
