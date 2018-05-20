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
    
    public partial class Varaukset : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"); // sulkuihin tietokannan connection string

        SqlCommand cmd = new SqlCommand();

        Varaus muokattava = new Varaus();
        

        public Varaukset()
        {            
            InitializeComponent();
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            cbToimipisteenLataus();
            dgvVarauksetLataus();
            this.varausTableAdapter.Fill(this.mokkivarausDataSet.Varaus);
        }

        // Haetaan toimipisteiden luettelo tietokannasta.
        // Viedään toimipisteiden nimet cbToimipiste:hen.
        private void cbToimipisteenLataus()
        {
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
                    cbToimipiste.ValueMember = "toimipiste_id";
                    cbToimipiste.DisplayMember = "nimi";
                    cbToimipiste.DataSource = dt;
                    cbToimipiste.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.Message);
                }
            }
        }

        //Haetaan tietokannasta varaukset ja
        //viedään ne dgvVaraukset:hin.
        private void dgvVarauksetLataus()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    // Määritellään SQL-tietokannasta tehtävä haku.
                    string query = "SELECT Varaus.varaus_id AS 'Varaus ID', Varaus.asiakas_id AS 'Asiakas ID', Toimipiste.nimi AS 'Toimipiste', Varaus.varattu_pvm AS 'Varauspäivä', " +
                        "Varaus.vahvistus_pvm AS 'Vahvistuspäivämäärä', Varaus.varattu_alkupvm AS 'Varauksen alkupäivämäärä', Varaus.varattu_loppupvm AS 'Varauksen loppupäivämäärä' " +
                        "FROM Varaus " +
                        "INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Suorita haku tietokannasta ja vie hakutulokset
                    //DataGridView-näkymään tarkasteltavaksi.
                    var dataAdapter = new SqlDataAdapter(query, connection);

                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dgvVaraukset.DataSource = ds.Tables[0];
                }
                catch
                {
                    // Tulosta virheilmoitus.
                    MessageBox.Show("Tietokantaan ei voitu muodostaa yhteyttä. Käynnistä sovellus uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Funktio, jolla haetaan päävalikosta tulevalla asiakas ID:llä
        //asiakkaan varaukset
        public void asiakkaanVaraukset(int asiakasID)
        {
            //Avataan varaukset tab page
            tcVaraukset.SelectedTab = tpVaraukset;
            //Tyhjennetään olemassa olevat tiedot
            btnTyhjenna.PerformClick();
            //Asetetaan asiakasID tbAsiakasID:hen
            tbAsiakasID.Text = Convert.ToString(asiakasID);
            //Suoritetaan haku asiakkaan tiedoilla
            btnHae.PerformClick();
        }


        //Päivämäärien tarkistus
        private string pvmTark()
        {
            if (dtpVarattuAlkupvm.Value > dtpVarattuLoppupvm.Value)
            {
                return "Varauksen alkupäivämäärän tulee olla ennen varauksen loppupäivämäärää.";
            }
            else if (dtpVarattupvm.Value > dtpVarattuAlkupvm.Value)
            {
                return "Varauspäivän tulee olla ennen varauksen alkupäivämäärää.";
            }
            return null;
        }

        //Varauksen tallennus tietokantaan
        private bool varauksenTallennus(string query, int x, int y, string toimipiste)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand(query, cn);

                    //Haetaan toimipisteen id'
                    string query2 = "SELECT Toimipiste.toimipiste_id FROM Toimipiste WHERE Toimipiste.nimi LIKE @Toimipistenimi";
                    SqlCommand cmd2 = new SqlCommand(query2, cn);
                    cmd2.Parameters.Add("@toimipistenimi", SqlDbType.Char).Value = cbToimipiste.Text;
                    cn.Open();
                    SqlDataReader dr1 = cmd2.ExecuteReader();
                    if (dr1.Read())
                    {
                        cmd.Parameters.Add("@toimipiste_id", SqlDbType.Int).Value = (int)dr1.GetValue(0);
                    }
                    else
                    {
                        MessageBox.Show("Tarkista ylläpidosta, että toimipiste löytyy tietokannasta.");
                        return false;
                    }
                    cn.Close();

                    //Parametrit tallennukseen
                    cmd.Parameters.Add("@varaus_id", SqlDbType.Int).Value = x;
                    cmd.Parameters.Add("@asiakas_id", SqlDbType.Int).Value = y;
                    cmd.Parameters.Add("@varattu_pvm", SqlDbType.Date).Value = DateTime.Today;
                    cmd.Parameters.Add("@vahvistus_pvm", SqlDbType.Date).Value = dtpVahvistuspvm.Value;
                    cmd.Parameters.Add("@varattu_alkupvm", SqlDbType.Date).Value = dtpVarattuAlkupvm.Value;
                    cmd.Parameters.Add("@varattu_loppupvm", SqlDbType.Date).Value = dtpVarattuLoppupvm.Value;

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

        //Klikkaamalla kerran rivin päästä varauksen tiedot siirtyy
        //Varauksen tiedot -osioon
        private void dgvVaraukset_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbVarausID.Text = Convert.ToString(dgvVaraukset.SelectedRows[0].Cells[0].Value);
            tbAsiakasID.Text = Convert.ToString(dgvVaraukset.SelectedRows[0].Cells[1].Value);
            cbToimipiste.Text = Convert.ToString(dgvVaraukset.SelectedRows[0].Cells[2].Value);
            dtpVarattupvm.Value = Convert.ToDateTime(dgvVaraukset.SelectedRows[0].Cells[3].Value);
            dtpVahvistuspvm.Value = Convert.ToDateTime(dgvVaraukset.SelectedRows[0].Cells[4].Value);
            dtpVarattuAlkupvm.Value = Convert.ToDateTime(dgvVaraukset.SelectedRows[0].Cells[5].Value);
            dtpVarattuLoppupvm.Value = Convert.ToDateTime(dgvVaraukset.SelectedRows[0].Cells[6].Value);

            tbVarausID.ReadOnly = true;
        }

        //Tupla klikkauksella rivinpäästä näyttää rivillä olevan 
        //varauksen palvelut.
        private void dgvVaraukset_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tcVaraukset.SelectTab(1);
            tbVarausIDpg2.Text = Convert.ToString(dgvVaraukset.SelectedRows[0].Cells[0].Value);
            btnHaeVaraus_Click(sender, e);
        }

        //Käyttäjä painaa 'Päävalikko'-painiketta,
        //mikä poistaa Varaukset-ikkunan.
        private void btnPaavalikko_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        //Käyttäjä painaa 'Tyhjennä painiketta jolloin tyhjennetään hakuehdot
        //ja päivitetään dtgVaraukset
        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbVarausID.ReadOnly = false;
            //Käydään läpi kaikki VarauksenTiedot-groupissa olevat laatikot
            //ja tyhjennetään ne
            foreach (Control ctrl in gbVarauksenTiedot.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
            }
            //Käydään läpi kaikki VarauksenTiedot-groupissa olevat DateTimePickerit
            //ja asetetaan niihin nykyinen päivä
            foreach (Control ctrl in gbVarauksenTiedot.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker tb = (DateTimePicker)ctrl;
                    tb.Value = DateTime.Today;
                }
            }
            //Haetaan toimipisteet varmuuden vuoksi uudelleen
            cbToimipisteenLataus();
            //Päivitetään dgvVaraukset näyttämään kaikki
            //tietokannan
            dgvVarauksetLataus();
            
        }

        //Käyttäjä painaa 'Hae'-painiketta, jolloin dvgVaraukset:ta filtteröidään
        //varauksen, asiakkaan ja/tai toimipisteen ID:llä
        private void btnHae_Click(object sender, EventArgs e)
        {
            //Muodostetaan SQL-skriptin alkuosa
            string query = "SELECT Varaus.varaus_id AS 'Varaus ID', Varaus.asiakas_id AS 'Asiakas ID', Toimipiste.nimi AS 'Toimipiste', Varaus.varattu_pvm AS 'Varauspäivä', " +
                "Varaus.vahvistus_pvm AS 'Vahvistus- päivämäärä', Varaus.varattu_alkupvm AS 'Varauksen alkupäivämäärä', Varaus.varattu_loppupvm AS 'Varauksen loppupäivämäärä' " +
                "FROM Varaus " +
                "INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id";

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {
                    //Muodostetaan SQL-skiptin loppuosa
                    //Jos käyttäjä on antanut syötteen tbVarausID:hen,
                    //jatketaan skriptiä.
                    //Jos ei syötettä, skriptiä ei muokata.
                    if (int.TryParse(tbVarausID.Text, out int x))
                    {
                        query = query + " WHERE Varaus.varaus_id = @varaus_id";
                    }

                    //Jos käyttäjä on antanut syötteen tbAsiakasID:hen JA
                    //tbVarausID:hen, aloitetaan skriptin muokkaus AND:llä.
                    if (int.TryParse(tbAsiakasID.Text, out int y) && x != 0)
                    {
                        query = query + " AND Varaus.asiakas_id = @asiakas_id";
                    }
                    //Jos käyttäjä antoi syötteen tbAsiakasID:hen, muttei tbVarausID:hen,
                    //aloitetaan skirtin muokkaus WHERE:llä
                    //Jos ei syötettä, skriptiä ei muokata.
                    else if (y != 0)
                    {
                        query = query + " WHERE Varaus.asiakas_id = @asiakas_id";
                    }

                    //Jos käyttäjä on antanut syötteen cbToimipiste:hen JA
                    //tbAsiakasID:hen, aloitetaan skriptin muokkaus AND:llä.
                    if (cbToimipiste.Text != "" && (y != 0 || x != 0))
                    {
                        query = query + " AND Toimipiste.nimi LIKE '%' + @toimipistenimi + '%'";
                    }
                    //Jos käyttäjä antoi syötteen cbToimipiste:hen, muttei tbAsiakasID:hen,
                    //aloitetaan skirtin muokkaus WHERE:llä
                    //Jos ei syötettä, skriptiä ei muokata.
                    else if (cbToimipiste.Text != "")
                    {
                        query = query + " WHERE Toimipiste.nimi LIKE '%' + @toimipistenimi + '%'";
                    }

                    //Lisätään haulle parametrit
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@varaus_id", SqlDbType.Int).Value = x;
                    cmd.Parameters.Add("@asiakas_id", SqlDbType.Int).Value = y;
                    cmd.Parameters.Add("@toimipistenimi", SqlDbType.Char).Value = cbToimipiste.Text;

                    //Haetaan tiedot tietokannasta
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    //päivitetään dgvVaraukset
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVaraukset.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Haku epäonnistui. Ota yhteys tukeen.", ex.Message);
            }
        }

        //Käyttäjä painaa 'Lisää'-painiketta, jolloin tarkistetaan ettei ole
        //tyhjiä kenttiä ja että päivämäärät on OK, minkä jälkeen (jos kaikki on)
        //tallennetaan asiakkaan tiedot tietokantaan
        private void btnLisaa_Click(object sender, EventArgs e)
        {

            //Tarkistetaan päivämäärät
            if (pvmTark() != null)
            {
                MessageBox.Show(pvmTark());
            }
            //Edetään jos päivämäärät OK
            else
            {
                //Tarkistetaan että asiakas_id on annettu
                if (!int.TryParse(tbAsiakasID.Text, out int y))
                {
                    MessageBox.Show("Anna asiakkaan ID.");
                }
                else
                {
                    //Tarkistetaan että toimipiste on annettu
                    if (cbToimipiste.Text == "")
                    {
                        MessageBox.Show("Anna toimipiste.");
                    }
                    else
                    {
                        //Määritetään SQL-skripti varauksen tallennusta varten
                        string query = "INSERT INTO Varaus (asiakas_id, Varaus.toimipiste_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) " +
                            "VALUES (@asiakas_id, @toimipiste_id, @varattu_pvm, @vahvistus_pvm, @varattu_alkupvm, @varattu_loppupvm)";

                        if(varauksenTallennus(query, 0, y, cbToimipiste.Text))
                        {
                            MessageBox.Show("Varaus tallennettu tietokantaan.");
                            btnTyhjenna_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Varauksen tallennus epäonnistui.\n\nTarkista asikastiedoista ja ylläpidosta, että asiakas ja toimipiste löytyvät tietokannasta.");
                        }
                    }
                }
            }
        }


        //Käyttäjä painaa 'Muokkaa'-painiketta, jolloin tarkistetaan ettei ole
        //tyhjiä kenttiä ja että päivämäärät on OK, minkä jälkeen (jos kaikki OK) 
        //tallennetaan asiakkaan tiedot tietokantaan
        private void btnMuokkaa_Click(object sender, EventArgs e)
        { 
            //Tarkistetaan päivämäärät
            if (pvmTark() != null)
            {
                MessageBox.Show(pvmTark());
            }
            //Edetään jos päivämäärät ja laatiko ok
            else
            {
                if (MessageBox.Show("Haluatko muokata varauksen tietoja?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //Ei jatketa jos käyttäjä vastaa ei
                }
                //Edetään jos vastaus kyllä
                else
                {
                    //Tarkistetaan että id on annettu
                    if (!int.TryParse(tbVarausID.Text, out int x))
                    {
                        MessageBox.Show("Anna varauksen ID.");
                    }
                    else
                    {
                        //Tarkistetaan että id on annettu
                        if (!int.TryParse(tbAsiakasID.Text, out int y))
                        {
                            MessageBox.Show("Anna asiakkaan ID.");
                        }
                        else
                        {
                            //Tarkistetaan että id on annettu
                            if (cbToimipiste.Text == null)
                            {
                                MessageBox.Show("Anna toimipiste.");
                            }
                            else
                            {
                                //Määritetään SQL-skripti varauksen tallennusta varten
                                string query = "UPDATE Varaus " +
                                    "SET asiakas_id = @asiakas_id, Varaus.toimipiste_id = @toimipiste_id, " +
                                    "vahvistus_pvm = @vahvistus_pvm, varattu_alkupvm = @varattu_alkupvm, varattu_loppupvm = @varattu_loppupvm " +
                                    "WHERE varaus_id = @varaus_id";

                                if (varauksenTallennus(query, x, y, cbToimipiste.Text))
                                {
                                    MessageBox.Show("Varauksen tiedot muokattu onnistuneesti.");
                                    btnTyhjenna_Click(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Varauksen tallennus epäonnistui.\n\nTarkista asiakastiedoista ja ylläpidosta, että asiakas ja toimipiste löytyvät tietokannasta.");
                                }
                            }
                        }
                    }
                }
            }
        }


        //Käyttäjä painaa 'Poista'-painiketta, jolloin poistetaan
        //valittu varaus
        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                //Tarkistetaan, että tbAsiakasID:ssä on numero
                if (!int.TryParse(tbVarausID.Text, out int x))
                {
                    MessageBox.Show("Valitse poistettava varaus taulukosta.");

                }
                //Edetään jos tbVarausID:ssä numero
                else
                {
                    if (MessageBox.Show("Haluatko poistaa varauksen tiedot tietokannasta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        //Ei jatketa jos käyttäjä vastaa ei
                    }
                    //Edetään jos vastaus kyllä
                    else
                    {

                        //SQL-skripti
                        string query = "DELETE FROM Varaus " +
                            "WHERE varaus_id = @varaus_id";

                        using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                        {
                            SqlCommand cmd = new SqlCommand(query, cn);

                            //Parametrit poistoon
                            cmd.Parameters.Add("@varaus_id", SqlDbType.Int).Value = x;

                            //Avataan SQL connection ja ajetaan SQL-skripti
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();

                            MessageBox.Show("Varaus poistettu tietokannasta.");
                            //Tyhjennetään kentät ja päivitetään dgvAsiakkaat
                            btnTyhjenna_Click(sender, e);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Varauksen poisto epäonnistui.\nTarkista, ettei varaukseen ole liitetty varauksia tai laskuja,\nja poista ne ensimmäisenä tarvittaessa.");
            }
        }




        //Käyttäjä painaa 'Hae varauksen palvelut' -painiketta, jolloin haetaan varauksen palvelut
        //ja haetaan mitä palveluita on toimipisteellä
        private void btnHaeVaraus_Click(object sender, EventArgs e)
        {

            //Määritetään SQL-skripti varauksen palveluiden hakua varten
            string query = "SELECT Varauksen_palvelut.varaus_id, Varauksen_palvelut.palvelu_id, Varauksen_palvelut.lkm " +
                "FROM Varauksen_palvelut " +
                    "WHERE Varauksen_palvelut.varaus_id = @varaus_id";

            //Määritetään SQL-skripti varauksen toimipisteen palveluiden hakua varten
            

            string query3 = "SELECT * FROM Varaus Where varaus_id = @varaus_id";

            

            try
            {

                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
                {

                    SqlCommand cmd = new SqlCommand(query, cn);
                    
                    SqlCommand cmd3 = new SqlCommand(query3, cn);

                    //Tarkistetaan, että annettu syöte on integer-muotoa 
                    if (int.TryParse(tbVarausIDpg2.Text, out int x))
                    {
                        //Määritetään hakujen parametri
                        cmd.Parameters.AddWithValue("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(tbVarausIDpg2.Text);
                        
                        cmd3.Parameters.AddWithValue("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(tbVarausIDpg2.Text);

                        cn.Open();
                        SqlDataReader DR1 = cmd3.ExecuteReader();
                        if (DR1.Read())
                        {
                            muokattava.Varausid = DR1.GetValue(0).ToString();

                            muokattava.Asiakasid = DR1.GetValue(1).ToString();
                            muokattava.Toimipisteid = DR1.GetValue(2).ToString();
                            muokattava.Varattu_pvm = DR1.GetValue(3).ToString();
                            muokattava.Vahvistus_pvm = DR1.GetValue(4).ToString();
                            muokattava.Varattu_alkupvm = DR1.GetValue(5).ToString();
                            muokattava.Varattu_loppupvm = DR1.GetValue(6).ToString();

                            muokattava.Ero = pvmEro(muokattava.Varattu_alkupvm, muokattava.Varattu_loppupvm);

                        }
                        cn.Close(); ;

                        //Haetaan tiedot varauksen palveluista tietokannasta 
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        //Päivitetään dgvVarauksenPalvelut
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        dgvVarauksenPalvelut.DataSource = dt;

                        string query2 = "SELECT Palvelu.palvelu_id, Palvelu.toimipiste_id, Palvelu.nimi, Palvelu.tyyppi, Palvelu.kuvaus, Palvelu.hinta, Palvelu.alv " +
                "FROM (SELECT * FROM Palvelu where Palvelu.palvelu_id NOT IN"+
                "(SELECT Varauksen_palvelut.palvelu_id from Varauksen_palvelut where varaus_id in" +
                "(SELECT varaus_id from Varaus where Convert(date, '" + muokattava.Varattu_alkupvm + "', 100) between varattu_alkupvm and varattu_loppupvm " +
                "or Convert(date, '" + muokattava.Varattu_loppupvm + "', 100) between varattu_alkupvm and varattu_loppupvm " +
                "or (varattu_alkupvm <= Convert(date, '" + muokattava.Varattu_alkupvm + "', 100) and varattu_loppupvm >= Convert(date, '" + muokattava.Varattu_loppupvm + "', 100))))) as Palvelu " +
                   "INNER JOIN Varaus ON Palvelu.toimipiste_id = Varaus.toimipiste_id " +
                    "WHERE Varaus.varaus_id = @varaus_id";
                        
                        

                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.Parameters.AddWithValue("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(tbVarausIDpg2.Text);

                        //Haetaan tiedot varauksen toimipisteen palveluista tietokannasta
                        cn.Open();
                        cmd2.ExecuteNonQuery();
                        cn.Close();
                        //Päivitetään dgvToimipisteenPalvelut
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        dgvToimipisteenPalvelut.DataSource = dt2;

                        

                        
                        tb_PalvLkm.Text = "1";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Varauksen palveluiden haussa tapahtui virhe. Ottakaa yhteys tukeen.");
            }
        }

        //Käyttäjä painaa 'Valitse asiakas'-painiketta, jolloin
        //suoritetaan Päävalikosta funktio, joka avaa asiakastiedot
        private void btnValAsiakas_Click(object sender, EventArgs e)
        {
            PaaValikko pvlikko = (PaaValikko)this.Owner;
            pvlikko.avaaAsiakastiedot();
        }

        private void dgvToimipisteenPalvelut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVarauksenPalvelut.ClearSelection();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            string varausid;
            string palveluid;
            string lkm;
            try { 
            palveluid = Convert.ToString(dgvToimipisteenPalvelut.SelectedRows[0].Cells[0].Value);
            varausid = tbVarausIDpg2.Text;
                if (Convert.ToInt32(dgvToimipisteenPalvelut.SelectedRows[0].Cells[3].Value) == 1 && Convert.ToInt32(tb_PalvLkm.Text) > 1)
                {
                    tb_PalvLkm.Text = Convert.ToString(muokattava.Ero);
                    
                    
                }
            lkm = tb_PalvLkm.Text;

           
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = "insert into Varauksen_palvelut (varaus_id, palvelu_id, lkm) values ('" + varausid + "', '" + palveluid + "', '" + lkm + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            paivitaVarauksenPalvelut(Convert.ToInt32(muokattava.Varausid));
                paivitaToimipisteenPalvelut();
              
            MessageBox.Show("Palvelu lisättiin varaukseen!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tietojen lisäys tietokantaan epäonnistui : \rMuista valita palvelun rivi, jonka haluat lisätä varaukseen.", ex.Message);
                cn.Close();
            }

        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Poista palvelu varauksesta
                //Päivitä lista
                try
                {
                   
                    cmd.Connection = cn;
                    int vid;
                    int pid;

                    vid = Convert.ToInt32(dgvVarauksenPalvelut.SelectedRows[0].Cells[0].Value);
                    pid = Convert.ToInt32(dgvVarauksenPalvelut.SelectedRows[0].Cells[1].Value);
                    cn.Open();

                    cmd.CommandText = "DELETE FROM Varauksen_palvelut where varaus_id = " + vid+"and palvelu_id = "+pid;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    paivitaVarauksenPalvelut(vid);
                    cb_NaytaVaratut_CheckedChanged(sender, e);
                    MessageBox.Show("Palvelu poistettiin varauksesta.");
                                     

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Palvelun poistaminen varauksesta epäonnistui : {0}", ex.Message);
                }
            }
        }
        private void paivitaVarauksenPalvelut(int varausid)
        {

                string select = "select * from  Varauksen_palvelut where varaus_id = " + varausid;
                var dataAdapter = new SqlDataAdapter(select, cn);
                var cmd2 = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();

                dataAdapter.Fill(ds);
                dgvVarauksenPalvelut.ReadOnly = true;
                dgvVarauksenPalvelut.DataSource = ds.Tables[0];
            

        }

        private double pvmEro(string pvm1, string pvm2)
        {
            double i = 1;
            DateTime alku = DateTime.Parse(pvm1);
            DateTime loppu = DateTime.Parse(pvm2);

            i = (loppu - alku).TotalDays;
            if(i == 0)
            {
                i = 1;
            }

            return i; 
        }

        private void dgvToimipisteenPalvelut_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void dgvToimipisteenPalvelut_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvToimipisteenPalvelut_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt32(dgvToimipisteenPalvelut.SelectedRows[0].Cells[3].Value) == 1)
            {
                tb_PalvLkm.Text = Convert.ToString(muokattava.Ero);
                tb_PalvLkm.Enabled = false;
            }
            else
            {
                tb_PalvLkm.Text = "1";
                tb_PalvLkm.Enabled = true;
                
            }

        }
        private void paivitaToimipisteenPalvelut()
        {
            try
            {

               string query2 = "SELECT Palvelu.palvelu_id, Palvelu.toimipiste_id, Palvelu.nimi, Palvelu.tyyppi, Palvelu.kuvaus, Palvelu.hinta, Palvelu.alv " +
                "FROM (SELECT * FROM Palvelu where Palvelu.palvelu_id NOT IN" +
                "(SELECT Varauksen_palvelut.palvelu_id from Varauksen_palvelut where varaus_id in" +
                "(SELECT varaus_id from Varaus where Convert(date, '" + muokattava.Varattu_alkupvm + "', 100) between varattu_alkupvm and varattu_loppupvm " +
                "or Convert(date, '" + muokattava.Varattu_loppupvm + "', 100) between varattu_alkupvm and varattu_loppupvm " +
                "or (varattu_alkupvm <= Convert(date, '" + muokattava.Varattu_alkupvm + "', 100) and varattu_loppupvm >= Convert(date, '" + muokattava.Varattu_loppupvm + "', 100))))) as Palvelu " +
                   "INNER JOIN Varaus ON Palvelu.toimipiste_id = Varaus.toimipiste_id " +
                    "WHERE Varaus.varaus_id = @varaus_id";

            SqlCommand cmd2 = new SqlCommand(query2, cn);
            cmd2.Parameters.AddWithValue("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(tbVarausIDpg2.Text);

            //Haetaan tiedot varauksen toimipisteen palveluista tietokannasta
            cn.Open();
            cmd2.ExecuteNonQuery();
            cn.Close();
            //Päivitetään dgvToimipisteenPalvelut
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvToimipisteenPalvelut.DataSource = dt2;
            }
            catch 
            {
                MessageBox.Show("Varauksen palveluiden päivittäminen epäonnistui", "Virhe");
            }

        }

        private void btn_VaratutPalvelut_Click(object sender, EventArgs e)
        {

            

        }

        private void cb_NaytaVaratut_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_NaytaVaratut.Checked == true)
            {
                btnLisaaPalvelu.Enabled = false;
                try
                {

                    string query2 = "SELECT Palvelu.palvelu_id, Palvelu.toimipiste_id, Palvelu.nimi, Palvelu.tyyppi, Palvelu.kuvaus, Palvelu.hinta, Palvelu.alv " +
                     "FROM (SELECT * FROM Palvelu where Palvelu.palvelu_id IN" +
                     "(SELECT Varauksen_palvelut.palvelu_id from Varauksen_palvelut where varaus_id in" +
                     "(SELECT varaus_id from Varaus where Convert(date, '" + muokattava.Varattu_alkupvm + "', 100) between varattu_alkupvm and varattu_loppupvm " +
                     "or Convert(date, '" + muokattava.Varattu_loppupvm + "', 100) between varattu_alkupvm and varattu_loppupvm " +
                     "or (varattu_alkupvm <= Convert(date, '" + muokattava.Varattu_alkupvm + "', 100) and varattu_loppupvm >= Convert(date, '" + muokattava.Varattu_loppupvm + "', 100))))) as Palvelu " +
                        "INNER JOIN Varaus ON Palvelu.toimipiste_id = Varaus.toimipiste_id " +
                         "WHERE Varaus.varaus_id = @varaus_id";

                    SqlCommand cmd2 = new SqlCommand(query2, cn);
                    cmd2.Parameters.AddWithValue("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(tbVarausIDpg2.Text);

                    //Haetaan tiedot varauksen toimipisteen palveluista tietokannasta
                    cn.Open();
                    cmd2.ExecuteNonQuery();
                    cn.Close();
                    //Päivitetään dgvToimipisteenPalvelut
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dgvToimipisteenPalvelut.DataSource = dt2;
                }
                catch
                {
                    MessageBox.Show("Varauksen palveluiden päivittäminen epäonnistui", "Virhe");
                }

            }
            else
            {
                paivitaToimipisteenPalvelut();
                btnLisaaPalvelu.Enabled = true;
            }
        }
    }
}