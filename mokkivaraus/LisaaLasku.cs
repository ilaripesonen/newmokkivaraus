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
using System.Text.RegularExpressions;

namespace mokkivaraus
{
    public partial class LisaaLasku : Form
    {
        public LisaaLasku()
        {
            InitializeComponent();
        }

        private void LisaaLasku_Load(object sender, EventArgs e)
        {
            // Haetaan asiakkaan tiedot Laskutus-ikkunasta.
            label_AsiakasNimi.Text = Laskutus.Nimi;
            label_AsiakasLahiosoite.Text = Laskutus.Lahiosoite;
            label_AsiakasPostitoimipaikka.Text = Laskutus.Postitoimipaikka;
            label_AsiakasPostinro.Text = Laskutus.Postinro.ToString();
            label_AsiakasEmail.Text = Laskutus.Email;

            // Haetaan kyseiseen varaukseen liittyvät palvelut
            // ja lasketaan yksittäisen palvelun hinta.
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                string query = "SELECT Palvelu.nimi AS 'Palvelu', Varauksen_palvelut.lkm AS 'Kpl', Palvelu.hinta AS 'á-hinta', Palvelu.alv AS 'ALV (%)', CAST(Palvelu.hinta*Varauksen_palvelut.lkm*(1+Palvelu.alv/100) AS DECIMAL(18,2)) AS 'Yhteensä' " +
                "FROM Varaus " +
                    "INNER JOIN Varauksen_palvelut ON Varaus.varaus_id = Varauksen_palvelut.varaus_id " +
                    "INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id " +
                "WHERE " +
                    "Varaus.varaus_id = @varaus_id";

                // Create a SqlCommand instance
                SqlCommand command = new SqlCommand(query, connection);

                //Määritä SQL-haun parametrit.
                command.Parameters.Add("@varaus_id", SqlDbType.Int).Value = Laskutus.Varaus_id;

                // Suorita haku tietokannasta ja vie hakutulokset
                // DataGridView-näkymään tarkasteltavaksi.
                var dataAdapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_VarauksenPalvelut.ReadOnly = true;
                dataGridView_VarauksenPalvelut.DataSource = ds.Tables[0];
            }

            // Lasketaan varauksen kokonaishinta suorittamalla
            // SQL-haku SUM-toiminnolla. Haun tulokset viedään
            // suoraan käyttäjän nähtäväksi textBoxiin.
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                string query = "SELECT SUM(CAST(Palvelu.hinta*Varauksen_palvelut.lkm*(1+Palvelu.alv/100) AS DECIMAL(18,2))) " +
                "FROM Varaus " +
                    "INNER JOIN Varauksen_palvelut ON Varaus.varaus_id = Varauksen_palvelut.varaus_id " +
                    "INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id " +
                "WHERE " +
                    "Varaus.varaus_id = @varaus_id";

                // Create a SqlCommand instance
                SqlCommand command = new SqlCommand(query, connection);

                //Määritä SQL-haun parametrit.
                command.Parameters.Add("@varaus_id", SqlDbType.Int).Value = Laskutus.Varaus_id;

                /// Suoritetaan haku tietokannasta.
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Laskutus.Summa = Convert.ToDecimal(reader[0]);
                    label_Summa.Text = Laskutus.Summa.ToString() + " €";
                }
            }
        }

        // Käyttäjä valitsee 'Peruuta' painikkeen, ikkuna
        // suljetaan eikä tehdä muutoksia tietokantaan.
        private void button_Peruuta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti keskeyttää laskunluonnin? Tallentamattomat muutokset menetetään.", "Vahvistus tarvitaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        // Käyttäjä ruksittaa valintalaatikon, jolla voidaan
        // automaattisesti lisätä varajaan tiedot laskutuskenttään.
        private void checkBox_LaskutusOsoite_CheckedChanged(object sender, EventArgs e)
        {
            // Käyttäjä rastittaa ruudun, syötetään yhteystiedot. 
            if (checkBox_LaskutusOsoite.Checked)
            {
                textBox_MaksajaNimi.Text = label_AsiakasNimi.Text;
                textBox_MaksajaLahiosoite.Text = label_AsiakasLahiosoite.Text;
                textBox_MaksajaPostitoimipaikka.Text = label_AsiakasPostitoimipaikka.Text;
                textBox_MaksajaPostinro.Text = label_AsiakasPostinro.Text;
                textBox_MaksajaEmail.Text = label_AsiakasEmail.Text;
            }
            // Käyttäjä poistaa rastin, tyhjennetään tekstikentät.
            else
            {
                textBox_MaksajaNimi.Clear();
                textBox_MaksajaLahiosoite.Clear();
                textBox_MaksajaPostitoimipaikka.Clear();
                textBox_MaksajaEmail.Clear();
                textBox_MaksajaPostinro.Clear();
            }
        }

        private void button_LuoLasku_Click(object sender, EventArgs e)
        {
            // Haetaan ikkunan tekstikentistä ajantasaiset
            // tiedot laskunmuodostamista varten.
            Laskutus.Nimi = textBox_MaksajaNimi.Text;
            Laskutus.Lahiosoite = textBox_MaksajaLahiosoite.Text;
            Laskutus.Postitoimipaikka = textBox_MaksajaPostitoimipaikka.Text;
            Laskutus.Postinro = Convert.ToInt32(textBox_MaksajaPostinro.Text);
            Laskutus.Email = textBox_MaksajaEmail.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    string query = "INSERT INTO Lasku (Lasku.varaus_id, Lasku.asiakas_id, Lasku.nimi, Lasku.lahiosoite, Lasku.postitoimipaikka, Lasku.paivays, Lasku.email, Lasku.summa, Lasku.alv) " +
                    "VALUES (@varaus_id, @asiakas_id, @nimi, @lahiosoite, @postitoimipaikka, @paivays, @email, @summa, @alv)";

                    // Create a SqlCommand instance
                    SqlCommand command = new SqlCommand(query, connection);

                    //Määritä SQL-haun parametrit.
                    command.Parameters.Add("@varaus_id", SqlDbType.Int).Value = Laskutus.Varaus_id;
                    command.Parameters.Add("@asiakas_id", SqlDbType.Int).Value = Laskutus.Asiakas_id;
                    command.Parameters.Add("@nimi", SqlDbType.VarChar).Value = Laskutus.Nimi;
                    command.Parameters.Add("@lahiosoite", SqlDbType.VarChar).Value = Laskutus.Lahiosoite;
                    command.Parameters.Add("@postitoimipaikka", SqlDbType.VarChar).Value = Laskutus.Postitoimipaikka;
                    command.Parameters.Add("@paivays", SqlDbType.Date).Value = DateTime.Today;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = Laskutus.Email;
                    command.Parameters.Add("@summa", SqlDbType.Decimal).Value = Laskutus.Summa;
                    command.Parameters.Add("@alv", SqlDbType.Int).Value = Laskutus.Alv;

                    /// Suoritetaan haku tietokannasta.
                    connection.Open();
                    command.ExecuteReader();

                    if (MessageBox.Show("Uusi lasku on luotu. Haluatko tulostaa laskun?", "Lasku luotu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        LaskuPohja laskuPohjaWindow = new LaskuPohja();
                        laskuPohjaWindow.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Päivitetään käsitelty lasku laskutetuksi; muutetaan
            // Varaus-taulun laskutettu-kentän arvoksi 'true', jolloin
            // kyseinen varaus ei enää näy laskuttamattomissa.
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    string query = "UPDATE Varaus SET Varaus.laskutettu = 'true' WHERE Varaus.varaus_id = @varaus_id";

                    // Create a SqlCommand instance
                    SqlCommand command = new SqlCommand(query, connection);

                    //Määritä SQL-haun parametrit.
                    command.Parameters.Add("@varaus_id", SqlDbType.Int).Value = Laskutus.Varaus_id;

                    /// Suoritetaan haku tietokannasta.
                    connection.Open();
                    command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Päivitä Laskutus-ikkunan dataGridView-näkymät
            // ja sulke ikkuna.
            Laskutus laskutusWindow = new Laskutus();
            try
            {
                laskutusWindow.Refresh();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validoi tekstikentän MaksajaNimi sisältö.
        private void textBox_MaksajaNimi_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch((textBox_MaksajaNimi.Text), @"^[a-zA-ZäÄöÖåÅ -]+$"))
            {
                errorProvider_MaksajaNimi.SetError(textBox_MaksajaNimi, "Nimen tulee sisältää vain kirjaimia.");
            }
            else
            {
                errorProvider_MaksajaNimi.SetError(textBox_MaksajaNimi, "");
            }
        }

        // Validoi tekstikentän MaksajaLahiosoite sisältö.
        private void textBox_MaksajaLahiosoite_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch((textBox_MaksajaLahiosoite.Text), @"[A-Za-z0-9'\.\-\s\,]+$"))
            {
                errorProvider_MaksajaLahiosoite.SetError(textBox_MaksajaLahiosoite, "Lähiosoitteen tulee sisältää vain kirjaimia ja numeroita.");
            }
            else
            {
                errorProvider_MaksajaLahiosoite.SetError(textBox_MaksajaLahiosoite, "");
            }
        }

        // Validoi tekstikentän MaksajaPostitoimipaikka sisältö.
        private void textBox_MaksajaPostitoimipaikka_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch((textBox_MaksajaPostitoimipaikka.Text), @"^[a-zA-ZäÄöÖåÅ -]+$"))
            {
                errorProvider_MaksajaPostitoimipaikka.SetError(textBox_MaksajaPostitoimipaikka, "Postitoimipaikan tulee sisältää vain kirjaimia.");
            }
            else
            {
                errorProvider_MaksajaPostitoimipaikka.SetError(textBox_MaksajaPostitoimipaikka, "");
            }
        }

        // Validoi tekstikentän MaksajaPostinro sisältö.
        private void textBox_MaksajaPostinro_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch((textBox_MaksajaPostinro.Text), @"^[0-9]+$"))
            {
                errorProvider_MaksajaPostinro.SetError(textBox_MaksajaPostinro, "Postinumeron tulee sisältää vain numeroita.");
            }
            else
            {
                errorProvider_MaksajaPostinro.SetError(textBox_MaksajaPostinro, "");
            }
        }

        // Validoi tekstikentän MaksajaEmail sisältö. Validointiin kaivettu
        // käytetty Regex-syntaksi on löydetty Stack Overflow -sivustolta;
        // https://stackoverflow.com/questions/5342375/regex-email-validation
        private void textBox_MaksajaEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch((textBox_MaksajaEmail.Text), @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {
                errorProvider_MaksajaEmail.SetError(textBox_MaksajaEmail, "Sähköposti ei saa sisältää erikoismerkkejä (pl. @).");
            }
            else
            {
                errorProvider_MaksajaEmail.SetError(textBox_MaksajaEmail, "");
            }
        }
    }
}
