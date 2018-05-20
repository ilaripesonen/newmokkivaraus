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
    public partial class LisaaToimipiste : Form
    {
        Toimipiste uusiToimipiste = new Toimipiste();
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"); // sulkuihin tietokannan connection string
       
        SqlCommand cmd = new SqlCommand();
        
        public LisaaToimipiste()
        {
            InitializeComponent();
                        
            
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

        //Käyttäjä klikkaa "Tallenna" -painiketta,
        //jolloin tehdyt muutokset tallennetaan tietokantaan.
        private void button_ToimipisteOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko tallentaa tiedot tietokantaan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Tarkista, ettei tyhjiä kenttiä
                //tai tekstiä yli rajojen
                //Tallenna tiedot
                


                try { 
                cn.Open();

                cmd.CommandText = "insert into Toimipiste (nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) values ('"+uusiToimipiste.GetNimi()+"', '"+uusiToimipiste.GetOsoite()+"', '"+uusiToimipiste.GetPostitoimipaikka()+"', '"+uusiToimipiste.GetPostinumero()+"', '"+uusiToimipiste.GetSahkoposti()+"','"+uusiToimipiste.GetPuhelinnro()+"')"; 

                cmd.ExecuteNonQuery();
                cn.Close();
                    textBox_Nimi.Clear();
                    textBox_Osoite.Clear();
                    textBox_Postitoimipaikka.Clear();
                    textBox_Postinumero.Clear();
                    textBox_PuhelinNro.Clear();
                    textBox_Email.Clear();
                this.Hide();

                    foreach (Form f in Application.OpenForms)
                    {
                        if(f.GetType() == typeof(Yllapito))
                        {
                            Yllapito yp = (Yllapito)f;
                            yp.Enabled = true;
                            yp.paivitaToimipiste();
                        }
                    }


                MessageBox.Show("Toimipiste lisätty tietokantaan.");
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tietojen lisäys tietokantaan epäonnistui : {0}", ex.Message);
                    cn.Close();

                }
            }
        }

        private void textBox_Nimi_TextChanged(object sender, EventArgs e)
        {
            uusiToimipiste.SetNimi(textBox_Nimi.Text);
        }

        private void LisaaToimipiste_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void textBox_Osoite_TextChanged(object sender, EventArgs e)
        {
            uusiToimipiste.SetOsoite(textBox_Osoite.Text);
        }

        private void textBox_Postitoimipaikka_TextChanged(object sender, EventArgs e)
        {
            uusiToimipiste.SetPostitoimipaikka(textBox_Postitoimipaikka.Text);
        }

        private void textBox_PuhelinNro_TextChanged(object sender, EventArgs e)
        {
            uusiToimipiste.SetPuhelinnro(textBox_PuhelinNro.Text);
        }

        private void textBox_Postinumero_TextChanged(object sender, EventArgs e)
        {
            uusiToimipiste.SetPostinumero(textBox_Postinumero.Text);
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            uusiToimipiste.SetSahkoposti(textBox_Email.Text);
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

    }
}
