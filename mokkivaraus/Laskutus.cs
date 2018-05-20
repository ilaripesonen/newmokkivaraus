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
    public partial class Laskutus : Form
    {
        public Laskutus()
        {
            InitializeComponent();
        }

        // Luodaan muuttujat laskutuksessa tarvittavien tietojen
        // väliaikaistallennukseen. Tällöin voidaan välttää
        // ylimääräisten SQL-hakujen suorittamista ja nopeuttaa
        // ohjelman toimintaa.
        public static int varaus_id;
        public static int asiakas_id;
        public static string toimipiste;
        public static string nimi;
        public static string lahiosoite;
        public static string postitoimipaikka;
        public static string email;
        public static int postinro;
        public static decimal summa;
        public static int alv;
        public static int lasku_id;

        public static int Varaus_id
        {
            get { return varaus_id; }
            set { varaus_id = value; }
        }

        public static int Asiakas_id
        {
            get { return asiakas_id; }
            set { asiakas_id = value; }
        }

        public static string Toimipiste
        {
            get { return toimipiste; }
            set { toimipiste = value; }
        }

        public static string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

        public static string Lahiosoite
        {
            get { return lahiosoite; }
            set { lahiosoite = value; }
        }

        public static string Postitoimipaikka
        {
            get { return postitoimipaikka; }
            set { postitoimipaikka = value; }
        }

        public static int Postinro
        {
            get { return postinro; }
            set { postinro = value; }
        }

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        public static decimal Summa
        {
            get { return summa; }
            set { summa = value; }
        }

        public static int Alv
        {
            get { return alv; }
            set { alv = value; }
        }
        
        public static int LaskuId
        {
            get { return lasku_id; }
            set { lasku_id = value; }
        }
        
        private void Laskutus_Load(object sender, EventArgs e)
        {
            // Haetaan toimipisteiden luettelo tietokannasta.
            // Viedään toimipisteiden nimet comboBoxiin.
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    // Määritellään SQL-tietokannasta tehtävä haku.
                    string query = "SELECT Toimipiste.toimipiste_id, Toimipiste.nimi FROM Toimipiste";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Suoritetaan haku tietokannasta.
                    SqlDataReader reader;
                    connection.Open();
                    reader = command.ExecuteReader();

                    // Viedään hakutulokset taulukkoon.
                    DataTable dt = new DataTable();
                    dt.Columns.Add("toimipiste_id", typeof(int));
                    dt.Columns.Add("nimi", typeof(string));
                    dt.Load(reader);

                    // Viedään hakutulokset comboBoxiin.
                    comboBox_Toimipiste1.ValueMember = "toimipiste_id";
                    comboBox_Toimipiste1.DisplayMember = "nimi";
                    comboBox_Toimipiste1.DataSource = dt;
                    comboBox_Toimipiste1.SelectedIndex = -1;

                    comboBox_Toimipiste2.DisplayMember = "nimi";
                    comboBox_Toimipiste2.ValueMember = "toimipiste_id";
                    comboBox_Toimipiste2.DataSource = dt;
                    comboBox_Toimipiste2.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: {0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Haetaan laskuttamattomat varaukset Laskutus-ikkunan
            // dataGridView1-näkymään.
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    // Määritellään SQL-tietokannasta tehtävä haku.
                    string query = "SELECT Varaus.varaus_id AS 'Varausnumero', Toimipiste.nimi AS 'Toimipiste', Asiakas.sukunimi AS 'Sukunimi',Asiakas.etunimi AS 'Etunimi',Varaus.vahvistus_pvm AS 'Vahvistettu' " +
                        "FROM Varaus " +
                            "INNER JOIN Asiakas ON Varaus.asiakas_id=Asiakas.asiakas_id " +
                            "INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id " +
                        "WHERE Varaus.vahvistus_pvm IS NOT NULL AND Varaus.laskutettu = 'false'";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Suorita haku tietokannasta ja vie hakutulokset
                    //DataGridView-näkymään tarkasteltavaksi.
                    var dataAdapter = new SqlDataAdapter(query, connection);

                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch
                {
                    // Tulosta virheilmoitus.
                    MessageBox.Show("Tietokantaan ei voitu muodostaa yhteyttä.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-------------------------------------------------------------
        // PAINIKKEIDEN TOIMINNOT
        //-------------------------------------------------------------

        // Käyttäjä valitsee 'Päävalikkoon' painikkeen, jolloin
        // laskutusjärjestelmän ikkuna suljetaan. Sama toiminto
        // suoritetaan molemmissa välilehdissä.
        private void button_Poistu1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Poistu2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Käyttäjä valitsee ¨Tyhjennä hakuvaihtoehdot' painikkeen,
        // jolloin kaikki hakukentät tyhjennetään syötetyistä arvoista.
        // Sama toiminto suoritetaan molemmissa välilehdissä.
        private void button_Tyhjenna1_Click(object sender, EventArgs e)
        {
            textBox_Varaustunnus2.Clear();
            textBox_Etunimi2.Clear();
            textBox_Sukunimi2.Clear();
            comboBox_Toimipiste2.SelectedIndex = -1;
        }

        private void button_Tyhjenna2_Click(object sender, EventArgs e)
        {
            textBox_Varaustunnus2.Clear();
            textBox_Etunimi2.Clear();
            textBox_Sukunimi2.Clear();
            comboBox_Toimipiste2.SelectedIndex = -1;
        }

        // Käyttäjä valitsee 'Haku' painikkeen, jolloin tietokannasta
        // haetaan hakuehdot täyttävät varaustiedot.
        private void button_Hae1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Varaus.varaus_id AS 'Varausnumero', Asiakas.etunimi AS 'Etunimi', Asiakas.sukunimi AS 'Sukunimi', Toimipiste.nimi AS 'Toimipiste', Varaus.vahvistus_pvm AS 'Vahvistettu'" +
                "FROM Varaus " +
                    "INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id " +
                    "INNER JOIN Toimipiste on Varaus.toimipiste_id = Toimipiste.toimipiste_id " +
                "WHERE " +
                    "(Varaus.vahvistus_pvm IS NOT NULL AND Varaus.laskutettu = 'false') " +
                    "AND ((Varaus.varaus_id = @varaus_id OR @varaus_id IS NULL) " +
                    "AND (Asiakas.etunimi LIKE '%' + @etunimi + '%' OR @etunimi IS NULL)" +
                    "AND (Asiakas.sukunimi LIKE '%' + @sukunimi + '%' OR @sukunimi IS NULL) " +
                    "AND (Toimipiste.toimipiste_id = @toimipiste_id OR @toimipiste_id = -1))";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    //Create a SqlCommand instance
                    SqlCommand command = new SqlCommand(query, connection);

                    //Määritä SQL-haun parametrit.'
                    command.Parameters.Add("@varaus_id", SqlDbType.VarChar).Value = textBox_Varaustunnus1.Text.ToString();
                    command.Parameters.Add("@etunimi", SqlDbType.VarChar).Value = textBox_Etunimi1.Text;
                    command.Parameters.Add("@sukunimi", SqlDbType.VarChar).Value = textBox_Sukunimi1.Text;
                    command.Parameters.Add("@toimipiste_id", SqlDbType.Int).Value = comboBox_Toimipiste1.SelectedValue.ToString();

                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            varaus_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Varausnumero"].Value);
        }

        LisaaLasku lisaaLaskuWindow = new LisaaLasku();
        private void button_LuoLasku1_Click(object sender, EventArgs e)
        {
            // Varmistetaan, että käyttäjä on valinnut vain yhden rivin
            // tai solun dataGridView-näkymästä. Muussa tapauksessa
            // käyttäjälle näytetään virheviesti.
            if(dataGridView1.SelectedCells.Count == 1 | dataGridView1.SelectedRows.Count == 1)
            {
                // Haetaan valittuun varaukseen liittyvät tiedot.
                // Tietoja ei näytetä käyttäjälle vaan ne tallennetaan
                // edellä luotuun TiedotLaskutukseen -luokkaan.
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    try
                    {
                        // Määritellään SQL-tietokannasta tehtävä haku.
                        string query = "SELECT Varaus.varaus_id, Asiakas.asiakas_id, Toimipiste.nimi, Asiakas.etunimi, Asiakas.sukunimi, Asiakas.lahiosoite, Asiakas.postinro, Asiakas.postitoimipaikka, Asiakas.email " +
                            " FROM Varaus " +
                                "INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id " +
                                "INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id " +
                            "WHERE Varaus.vahvistus_pvm IS NOT NULL AND Varaus.laskutettu = 'false'" +
                            "AND Varaus.varaus_id = @varaus_id";

                        SqlCommand command = new SqlCommand(query, connection);

                        // Suorita haku tietokannasta ja vie hakutulokset
                        //DataGridView-näkymään tarkasteltavaksi.
                        command.Parameters.Add("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(Laskutus.Varaus_id);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds);

                        asiakas_id = Convert.ToInt32(ds.Tables[0].Rows[0]["asiakas_id"]);
                        postinro = Convert.ToInt32(ds.Tables[0].Rows[0]["postinro"]);
                        toimipiste = ds.Tables[0].Rows[0]["nimi"].ToString();
                        nimi = ds.Tables[0].Rows[0]["sukunimi"].ToString() + " " + ds.Tables[0].Rows[0]["etunimi"].ToString();
                        lahiosoite = ds.Tables[0].Rows[0]["lahiosoite"].ToString();
                        postitoimipaikka = ds.Tables[0].Rows[0]["postitoimipaikka"].ToString();
                        email = ds.Tables[0].Rows[0]["email"].ToString();

                        // Avaa uusi ikkuna.
                        lisaaLaskuWindow.ShowDialog();
                    }
                    catch(Exception ex)
                    {
                        // Tulosta virheilmoitus.
                        MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Tulosta virheilmoitus.
                MessageBox.Show("Varausvalinnassa tapahtui virhe. Valitsithan vain yhden varauksen?", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Käyttäjä valitsee jommankumman ikkunan välilehdistä,
        // jolloin välilehteä vastaava dataGridView päivitetään
        // ajantasaisella SQL-hakutuloksella.
        private void tabControl_Laskutus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Jos käyttäjä valitsee välilehden 'Laskuttamattomat'...
            if (tabControl_Laskutus.SelectedTab == tabControl_Laskutus.TabPages["TabLaskuttamattomat"])
            {
                // Haetaan tietokannasta laskuttamattomat varaukset.
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    try
                    {
                        // Haetaan tietokannasta varaukset, jotka on jo laskutettu.
                        string query = "SELECT Varaus.varaus_id AS 'Varausnumero', Toimipiste.nimi AS 'Toimipiste', Asiakas.sukunimi AS 'Sukunimi',Asiakas.etunimi AS 'Etunimi',Varaus.vahvistus_pvm AS 'Vahvistettu' " +
                        "FROM Varaus " +
                            "INNER JOIN Asiakas ON Varaus.asiakas_id=Asiakas.asiakas_id " +
                            "INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id " +
                        "WHERE Varaus.vahvistus_pvm IS NOT NULL AND Varaus.laskutettu = 'false'";

                        // Luo SQL-komento.
                        SqlCommand command = new SqlCommand(query, connection);

                        // Suorita haku tietokannasta ja vie hakutulokset dataGridView-näkymään.
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        //SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);
                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);
                        dataGridView1.ReadOnly = true;
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tapahtui virhe: {0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Jos käyttäjä valitsee välilehden 'Laskutetut'...
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    try
                    {
                        // Haetaan tietokannasta varaukset, jotka on jo laskutettu.
                        string query = "SELECT Lasku.lasku_id AS 'Laskun nro', Varaus.varaus_id AS 'Varausnro', Lasku.nimi AS 'Asiakkaan nimi', Lasku.lahiosoite AS 'Lähiosoite', Lasku.postitoimipaikka AS 'Postitoimipaikka', Lasku.summa AS 'Laskutettu summa'" +
                                    "FROM Varaus " +
                                        "INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id " +
                                        "INNER JOIN Lasku ON Lasku.varaus_id = Varaus.varaus_id " +
                                    "WHERE Varaus.vahvistus_pvm IS NOT NULL AND Varaus.laskutettu = 'true'";

                        // Luo SQL-komento.
                        SqlCommand command = new SqlCommand(query, connection);

                        // Suorita haku tietokannasta ja vie hakutulokset dataGridView-näkymään.
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        //SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);
                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);
                        dataGridView2.ReadOnly = true;
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tapahtui virhe: {0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }       
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varaus_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Varausnumero"].Value);
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lasku_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Laskun nro"].Value);

            // Avaa lasku.
            LaskuPohja laskuPohjaWindow = new LaskuPohja();
            laskuPohjaWindow.ShowDialog();
        }

        private void button_Tulosta2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 1 | dataGridView2.SelectedRows.Count == 1)
            {
                lasku_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Laskun nro"].Value);
                LaskuPohja laskuPohjaWindow = new LaskuPohja();
                laskuPohjaWindow.ShowDialog();
            }
            else
            {
                // Tulosta virheilmoitus.
                MessageBox.Show("Laskunvalinnassa tapahtui virhe. Valitsithan vain yhden varauksen?", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}