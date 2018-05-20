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
    public partial class MuokkaaToimipistettä : Form
    {
        Toimipiste muokattava = new Toimipiste();
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"); // sulkuihin tietokannan connection string

        SqlCommand cmd = new SqlCommand();

        // välitetään uuden kaavakkeen parametriksi toimipisteen tiedot ylläpito-kaavakkeelta
        public MuokkaaToimipistettä(Toimipiste p)
        {
            InitializeComponent();
            muokattava = p;
        }

        private void MuokkaaToimipistettä_Load(object sender, EventArgs e)
        {
            // siirretään toimipiste-olion tiedot tekstibokseihin
            this.textBox_Id.Text = Convert.ToString(muokattava.GetToimipiste_id());
            this.textBox_Id.Enabled = false;
            this.textBox_Nimi.Text = muokattava.GetNimi();
            this.textBox_Osoite.Text = muokattava.GetOsoite();
            this.textBox_Postinumero.Text = muokattava.GetPostinumero();
            this.textBox_Postitoimipaikka.Text = muokattava.GetPostitoimipaikka();
            this.textBox_PuhelinNro.Text = muokattava.GetPuhelinnro();
            this.textBox_Email.Text = muokattava.GetSahkoposti();

            cmd.Connection = cn;
            

        }
        // jos käyttäjä muokkaa tekstikenttiä, se muutos tallennetaan muokattava-toimipisteeseen
        private void textBox_Nimi_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetNimi(textBox_Nimi.Text);
        }

        private void textBox_Osoite_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetOsoite(textBox_Osoite.Text);
        }

        private void textBox_Postitoimipaikka_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetPostitoimipaikka(textBox_Postitoimipaikka.Text);
        }

        private void textBox_PuhelinNro_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetPuhelinnro(textBox_PuhelinNro.Text);
        }

        private void textBox_Postinumero_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetPostinumero(textBox_Postinumero.Text);
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            muokattava.SetSahkoposti(textBox_Email.Text);
        }

        private void button_ToimipisteOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko tallentaa muutokset tietokantaan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.Hide();

                //avataan tietokanta-yhteys ja otetaan päivitettävät tiedot muokattava-toimipisteeltä
                try
                {
                    cn.Open();

                    cmd.CommandText = "update Toimipiste set nimi = '"+muokattava.GetNimi()+"', lahiosoite = '"+muokattava.GetOsoite()+"', postitoimipaikka = '"+muokattava.GetPostitoimipaikka()+"', postinro = '"+muokattava.GetPostinumero()+"', email = '"+muokattava.GetSahkoposti()+"', puhelinnro = '"+muokattava.GetPuhelinnro()+"' where toimipiste_id = "+muokattava.GetToimipiste_id();

                    cmd.ExecuteNonQuery();
                    cn.Close();
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(Yllapito))
                        {
                            Yllapito yp = (Yllapito)f;
                            yp.Enabled = true;
                            yp.paivitaToimipiste();
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

        //Textboxiin painetun näppäimen tarkistus
        //Sallitaan vain numerot
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

        //Textboxiin painetun näppäimen tarkistus
        //Sallitaan vain kirjaimet ja -
        private void tbKeyPressKirVii(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
                this.erProvTeksti.SetError(tb, "Käytä A-Z, a-z ja -");
            }
            else
            {
                erProvTeksti.SetError(tb, "");
            }
        }

        //Textboxiin painetun näppäimen tarkistus
        //Sallitaan vain numerot, kirjaimet, - ja välilyönti
        private void tbKeyPressKirNumViiVal(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                this.erProvTeksti.SetError(tb, "Käytä 0-9, A-Z, a-z, - ja välilyöntiä");
            }
            else
            {
                erProvTeksti.SetError(tb, "");
            }
        }

        //Textboxiin painetun näppäimen tarkistus
        //Sallitaan kaikki paitsi välilyönti
        private void tbKeyPressEiVal(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' '))
            {
                e.Handled = true;
                this.erProvTeksti.SetError(tb, "Välilyönti ei sallittu");
            }
            else
            {
                erProvTeksti.SetError(tb, "");
            }
        }

        private void button_ToimipistePeruuta_Click(object sender, EventArgs e)
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
    }
}
