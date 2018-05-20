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
    public partial class MuokkaaPalvelua : Form
    {

        Palvelu muokattava = new Palvelu();
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"); // sulkuihin tietokannan connection string

        SqlCommand cmd = new SqlCommand();

        public MuokkaaPalvelua(Palvelu p)
        {
            InitializeComponent();
            muokattava = p;
                               
        }

        private void MuokkaaPalvelua_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            tb_ToimipisteID.Text = muokattava.GetToimipisteid();
            tb_PalvelunNimi.Text = muokattava.GetNimi();
            tb_Kuvaus.Text = muokattava.GetKuvaus();
            tb_Tyyppi.Text = muokattava.GetTyyppi();
            tb_Hinta.Text = muokattava.GetHinta();
            tb_ALV.Text = muokattava.GetAlv();
        }

        private void tb_ToimipisteID_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetToimipisteid(tb_ToimipisteID.Text);
        }

        private void tb_PalvelunNimi_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetNimi(tb_PalvelunNimi.Text);
        }

        private void tb_Kuvaus_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetKuvaus(tb_Kuvaus.Text);
        }

        private void tb_Tyyppi_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetTyyppi(tb_Tyyppi.Text);
        }

        private void tb_Hinta_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetHinta(tb_Hinta.Text);
        }

        private void tb_ALV_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetAlv(tb_ALV.Text);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko tallentaa muutokset tietokantaan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();

                //avataan tietokanta-yhteys ja otetaan päivitettävät tiedot muokattava-toimipisteeltä
                try
                {
                    cn.Open();

                    cmd.CommandText = "update Palvelu set toimipiste_id = '" + muokattava.GetToimipisteid() + "', nimi = '" + muokattava.GetNimi() + "', tyyppi = '" + muokattava.GetTyyppi() + "', kuvaus = '" + muokattava.GetKuvaus() + "', hinta = '" + muokattava.GetHinta() + "', alv = '" + muokattava.GetAlv() + "' where palvelu_id = " + muokattava.GetPalveluid();

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

                    MessageBox.Show("Muutokset tallennettu tietokantaan.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tietojen lisäys tietokantaan epäonnistui : {0}", ex.Message);
                    cn.Close();

                }
            }
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
