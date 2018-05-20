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
    public partial class Asiakastiedot : Form
    {
        public Asiakastiedot()
        {
            InitializeComponent();
        }

        private void Asiakastiedot_Load(object sender, EventArgs e)
        {
            //Päivittää dvgAsiakaat:n tietokannan asiakkailla
            this.asiakasTableAdapter.Fill(this.mokkivarausDataSet.Asiakas);
        }

        //Käyttäjä painaa 'Päävalikko'-painiketta, jolloin piilotetaan
        //Asiakkaat-ikkuna
        private void btnPaavalikko_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Tyhjien kenttien tarkistus
        private bool tyhjienKenttienTark()
        {
            //Käydään läpi kaikki Asiakkaan tiedot -groupissa olevat laatikot
            //ja tarkistetaan ovatko ne tyhjiä
            //Jos tyhjä palautetaan false, jos ei tyhjiä
            //palautetaan true
            foreach (Control ctrl in gbAsiakkaanTiedot.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "tbAsiakasID")
                {
                    TextBox tb = ctrl as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        //Asiakkaan tallennus tietokantaan
        private bool asiakkaanTallennus(string query, int x)
        {
            try
            {
                //Avataan yhteystietokantaan
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand(query, cn);

                    //Parametrit tallennukseen
                    cmd.Parameters.Add("@asiakas_id", SqlDbType.Int).Value = x;
                    cmd.Parameters.Add("@etunimi", SqlDbType.VarChar, 20).Value = tbEtunimi.Text;
                    cmd.Parameters.Add("@sukunimi", SqlDbType.VarChar, 40).Value = tbSukunimi.Text;
                    cmd.Parameters.Add("@lahiosoite", SqlDbType.VarChar, 40).Value = tbLahiosoite.Text;
                    cmd.Parameters.Add("@postitoimipaikka", SqlDbType.VarChar, 30).Value = tbPostitoimipaikka.Text;
                    cmd.Parameters.Add("@postinro", SqlDbType.VarChar, 5).Value = tbPostinro.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = tbEmail.Text;
                    cmd.Parameters.Add("@puhelinnro", SqlDbType.VarChar, 15).Value = tbPuhelinnro.Text;

                    //Avataan SQL connection ja ajetaan SQL-skripti
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        //Klikkaamalla rivin päästä varauksen tiedot siirtyy
        //Varauksen tiedot -osioon
        private void dgvVaraukset_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbAsiakasID.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[0].Value);
            tbEtunimi.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[1].Value);
            tbSukunimi.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[2].Value);
            tbLahiosoite.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[3].Value);
            tbPostitoimipaikka.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[4].Value);
            tbPostinro.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[5].Value);
            tbEmail.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[6].Value);
            tbPuhelinnro.Text = Convert.ToString(dgvAsiakkaat.SelectedRows[0].Cells[7].Value);
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
        private void tbKeyPressVal(object sender, KeyPressEventArgs e)
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


        //Käyttäjä painaa 'Hae'-painiketta, jolloin otetaan hakuehdot
        //tbEtunimi:stä ja tbSukunimi:stä, ja haetaan dgvAsiakkaat-taulukkoon
        //hakuehtoja vastaavat asiakkaat
        private void btnHae_Click(object sender, EventArgs e)
        {
            try
            {
                //Määritetään SQL-skripti asiakkaan hakua varten
                string query = "SELECT asiakas_id, etunimi, sukunimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro " +
                    "FROM Asiakas " +
                        "WHERE Asiakas.etunimi LIKE '%' + @etunimi + '%' " +
                        "AND Asiakas.sukunimi LIKE '%' + @sukunimi + '%'";

                //Avataan yhteys tietokantaan
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    //Luodaan uusi SqlCommand query-skriptillä ja cn-connectiolla
                    SqlCommand cmd = new SqlCommand(query, cn);

                    //Määritetään hakujen parametri
                    cmd.Parameters.Add("@etunimi", SqlDbType.VarChar, 20).Value = tbEtunimi.Text;
                    cmd.Parameters.Add("@sukunimi", SqlDbType.VarChar, 40).Value = tbSukunimi.Text;

                    //Haetaan tiedot varauksen palveluista tietokannasta 
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    //Päivitetään dgvVarauksenPalvelut
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAsiakkaat.DataSource = dt;
                }
            }
            //Näytetään viesti virheen tapahtuessa
            catch
            {
                MessageBox.Show("Haussa tapahtui virhe. Ottakaa yhteys tukeen virheen toistuessa.");
            }

        }

        //Käyttäjä painaa 'Tyhjennä' -painiketta,
        //jolloin textboxit tyjennetään
        private void bntTyhjenna_Click(object sender, EventArgs e)
        {
            //Käydään läpi kaikki Asiakkaan tiedot -groupissa olevat laatikot
            //ja tyhjennetään ne
            foreach (Control ctrl in gbAsiakkaanTiedot.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
            }
            //Haetaan tyhjillä hakuehdoilla, jolloin dgvAsiakaat
            //näyttää kaikki asiakkaat
            btnHae_Click(sender, e);
        }

        //Käyttäjä painaa 'Lisää'-painiketta, jolloin tarkistetaan ettei ole
        //tyhjiä kenttiä, minkä jälkeen (jos ei tyhjiä kenttiä) tallennetaan
        //asiakkaan tiedot tietokantaan
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //Tarkistetaan onko tyhjiä laatikoita
            if (!tyhjienKenttienTark())
            {
                MessageBox.Show("Täytä tyhjät kentät.");
            }
            //Edetään jos ei tyhjiä laatikoita
            else
            {
                if (MessageBox.Show("Haluatko lisätä asiakkaan tietokantaan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //Ei jatketa jos asiakas vastaa ei
                }
                //Edetään jos vastaus kyllä
                else
                {
                    //Määritetään SQL-skripti asiakkaan tallennusta varten
                    string query = "INSERT INTO Asiakas (etunimi, sukunimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) " +
                        "VALUES (@etunimi, @sukunimi, @lahiosoite, @postitoimipaikka, @postinro, @email, @puhelinnro)";

                    //Koitetaan tallentaa asiakkaan tietoja
                    if (asiakkaanTallennus(query, 0))
                    {
                        MessageBox.Show("Asiakas lisätty tietokantaan.");
                        //Tyhjennetään kentät ja päivitetään dgvAsiakkaat
                        bntTyhjenna_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Asiakkaan tallennuksessa tapahtui virhe. Kokeilkaa käynnistää sovellus uudelleen. " +
                            "Virheen toistuessa ottakaa yhteys tukeen.");
                    }
                }
            }
        }

        //Käyttäjä painaa 'Poista'-painiketta, jolloin tarkistetaan onko
        //tbAsiakas_id:ssa arvoa, minkä jälkeen (jos on arvo) poistetaan
        //asiakkaan tiedot tietokannasta
        private void btnPoista_Click(object sender, EventArgs e)
        {
            //Tarkistetaan, että tbAsiakasID:ssä on numero
            if (!int.TryParse(tbAsiakasID.Text, out int x))
            {
                MessageBox.Show("Valitse poistettava asiakas taulukosta.");

            }
            //Edetään jos tbAsiakasID:ssä numero
            else
            {
                if (MessageBox.Show("Haluatko poistaa asiakkaan tiedot tietokannasta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //Ei jatketa jos asiakas vastaa ei
                }
                //Edetään jos vastaus kyllä
                else
                {
                    //SQL-skripti
                    string query = "DELETE FROM asiakas " +
                        "WHERE asiakas_id = @asiakas_id";
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                        {
                            SqlCommand cmd = new SqlCommand(query, cn);

                            //Parametrit tallennukseen
                            cmd.Parameters.Add("@asiakas_id", SqlDbType.Int).Value = x;

                            //Avataan SQL connection ja ajetaan SQL-skripti
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();

                            MessageBox.Show("Asiakas poistettu tietokannasta.");
                            //Tyhjennetään kentät ja päivitetään dgvAsiakkaat
                            bntTyhjenna_Click(sender, e);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Asiakkaan poistossa tapahtui virhe.\nTarkista, ettei asiakkaalla ole varauksia tai laskuja,\nja poista ne ensimmäisenä tarvittaessa.");
                    }
                }
            }
        }

        //Käyttäjä painaa 'Muokkaa'-painiketta, jolloin tarkistetaan onko
        //tbAsiakas_id:ssa arvoa, minkä jälkeen (jos on arvo) muokataan
        //asiakkaan tietoja tietokannassa
        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            //Tarkistetaan, että tbAsiakasID:ssä on numero
            if (!int.TryParse(tbAsiakasID.Text, out int x))
            {
                MessageBox.Show("Valitse muokattava asiakas taulukosta.");
            }
            //Edetään jos tbAsiakasID:ssä numero
            else
            {
                //Tarkistetaan onko tyhjiä laatikoita
                if (!tyhjienKenttienTark())
                {
                    MessageBox.Show("Täytä tyhjät kentät.");
                }
                //Edetään jos ei tyhjiä laatikoita
                else
                {
                    if (MessageBox.Show("Haluatko muokata asiakkaan tiedoja?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        //Ei jatketa jos asiakas vastaa ei
                    }
                    //Edetään jos vastaus kyllä
                    else
                    {
                        //Määritetään SQL-skripti asiakkaan tallennusta varten
                        string query = "UPDATE Asiakas " +
                            "SET etunimi = @etunimi, sukunimi = @sukunimi, lahiosoite =  @lahiosoite, postitoimipaikka = @postitoimipaikka, postinro =  @postinro, email = @email, puhelinnro = @puhelinnro " +
                            "WHERE asiakas_id = @asiakas_id";

                        //Koitetaan muokata asiakkaan tietoja
                        if (asiakkaanTallennus(query, x))
                        {
                            MessageBox.Show("Asiakkaan tiedot muokattu.");
                            //Tyhjennetään kentät ja päivitetään dgvAsiakkaat
                            bntTyhjenna_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Asiakkaan tallennuksessa tapahtui virhe. Kokeilkaa käynnistää sovellus uudelleen. " +
                                "Virheen toistuessa ottakaa yhteys tukeen.");
                        }
                    }
                }
            }
        }


        //Käyttäjä painaa 'Tarkastele asiakkaan varauksia' -painiketta,
        //jolloin siirrytään varaukset-ikkunaan tarkastelemaan asiakkaan varauksia
        private void btnTarkAsVar_Click(object sender, EventArgs e)
        {
            //Tarkistetaan, että tbAsiakasID:ssä on numero
            if (!int.TryParse(tbAsiakasID.Text, out int x))
            {
                MessageBox.Show("Valitse asiakas taulukosta.");
            }
            //Edetään jos tbAsiakasID:ssä numero
            else
            {
                PaaValikko pvlikko = (PaaValikko)this.Owner;
                pvlikko.asiakasIDSiirto(x);
            }
        }

        //Käyttäjä tupla klikkaa rivin päästä, jolloin toteutetaan sama kuin
        //käyttäjä painaisi 'Tarkastele asiakkaan varauksia' -painiketta eli
        //siirrytään varaukset-ikkunaan tarkastelemaan asiakkaan varauksia
        private void dgvAsiakkaat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnTarkAsVar.PerformClick();
        }
    }
}

