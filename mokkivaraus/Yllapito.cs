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
    public partial class Yllapito : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"); // sulkuihin tietokannan connection string

        SqlCommand cmd = new SqlCommand();
        

        public Yllapito()
        {
            InitializeComponent();

                      

        }

        //Käyttäjä klikkaa "Päävalikkoon" -painiketta, jolloin
        //ylläpitoikkuna sulkeutuu.
        private void button_Poistu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Käyttäjä klikkaa "Lisää toimipiste" -painiketta, jolloin
        //toimipisteiden lisäysikkuna avautuu
        LisaaToimipiste toimipisteLisaysWindow = new LisaaToimipiste();
        private void button_LisaaToimipiste_Click(object sender, EventArgs e)
        {
            Toimipiste uusiToimipiste = new Toimipiste();
            this.Enabled = false;
            
            toimipisteLisaysWindow.Show();

          
        }

        //Käyttäjä klikkaa "Muokkaa toimipistettä" -painiketta, jolloin valitun
        //toimipisteen muokkausikkuna avautuu
        private void button_MuokkaaToimipistetta_Click(object sender, EventArgs e)
        {
            //Avaa toimipisteen muokkausikkunan
            this.Enabled = false;
            Toimipiste p = new Toimipiste();
            p.SetToimipiste_id(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            p.SetNimi(Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value));
            p.SetOsoite(Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value));
            p.SetPostitoimipaikka(Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value));
            p.SetPostinumero(Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value));
            p.SetSahkoposti(Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value));
            p.SetPuhelinnro(Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value));

            MuokkaaToimipistettä muokkaatoimipistetta = new MuokkaaToimipistettä(p);
            muokkaatoimipistetta.Show();

        }


        //Käyttäjä klikkaa "Poista toimipiste" -painiketta, jolloin toimipiste
        //poistetaan varmistusviestin jälkeen tietokannasta
        private void button_PoistaToimipiste_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Haluatko varmasti poistaa toimipisteen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Poista toimipiste tietokannasta
                //Päivitä lista
                try
                {
                    int id;
                   
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                cn.Open();

                cmd.CommandText = "DELETE FROM Toimipiste where toimipiste_id = " + id;
                cmd.ExecuteNonQuery();
                cn.Close();
                    MessageBox.Show("Toimipiste poistettiin tietokannasta");
                    btn_paivita.PerformClick();
                    paivitaPalvelut();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Toimipisteen poistaminen tietokannasta epäonnistui : {0}", ex.Message);
                    cn.Close();
                }
            }
        }

        //Käyttäjä klikkaa "Lisää palvelu" -painiketta, jolloin
        //palveluiden lisäysikkuna avautuu
        private void button_LisaaPalvelu_Click(object sender, EventArgs e)
        {
            //Avaa palvelun lisäysikkunan
            LisääPalvelu lp = new LisääPalvelu();
            this.Enabled = false;
            lp.Show();
        }

        //Käyttäjä klikkaa "Muokkaa palvelua" -painiketta, jolloin valitun
        //palvelun muokkausikkuna avautuu
        private void button_MuokkaaPalvelua_Click(object sender, EventArgs e)
        {
            //Avaa palvelun muokkausikkunan
            try {
            Palvelu pal = new Palvelu();
            pal.SetPalveluid(Convert.ToString(dataGridView2.SelectedRows[0].Cells[0].Value));
            pal.SetToimipisteid(Convert.ToString(dataGridView2.SelectedRows[0].Cells[1].Value));
            pal.SetNimi(Convert.ToString(dataGridView2.SelectedRows[0].Cells[2].Value));
            pal.SetTyyppi(Convert.ToString(dataGridView2.SelectedRows[0].Cells[3].Value));
            pal.SetKuvaus(Convert.ToString(dataGridView2.SelectedRows[0].Cells[4].Value));
            pal.SetHinta(Convert.ToString(dataGridView2.SelectedRows[0].Cells[5].Value));
            pal.SetAlv(Convert.ToString(dataGridView2.SelectedRows[0].Cells[6].Value));
            // lähetetään pal-olio parametrina muokkaaPalveluaWindowiin
            MuokkaaPalvelua muokkaaPalveluaWindow = new MuokkaaPalvelua(pal);
                this.Enabled = false;
            muokkaaPalveluaWindow.Show();
            }
            catch
            {
                MessageBox.Show("Valitse ensin muokattava palvelu");
            }
        }

        //Käyttäjä klikkaa "Poista palvelu" -painiketta, jolloin palvelu
        //poistetaan varmistusviestin jälkeen tietokannasta
        private void button_PoistaPalvelu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistaa palvelun?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Poista palvelu tietokannasta
                //Päivitä lista
                try
                {
                    int id;

                    id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                    cn.Open();

                    cmd.CommandText = "DELETE FROM Palvelu where palvelu_id = " + id;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Palvelu poistettiin tietokannasta.");
                    btn_PäivitäPalvelut.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Palvelun poistaminen tietokannasta epäonnistui : {0}", ex.Message);
                    cn.Close();
                }
            }
        }

        private void Yllapito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkivarausDataSet.Palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.mokkivarausDataSet.Palvelu);
            // TODO: This line of code loads data into the 'mokkivarausDataSet.Toimipiste' table. You can move, or remove it, as needed.
            this.toimipisteTableAdapter.Fill(this.mokkivarausDataSet.Toimipiste);
            cmd.Connection = cn;
        }

        private void btn_paivita_Click(object sender, EventArgs e)
        {

            string select = "select * from  Toimipiste";
            var dataAdapter = new SqlDataAdapter(select, cn);
            var cmd = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "select * from  Palvelu";
            var dataAdapter = new SqlDataAdapter(select, cn);
            var cmd = new SqlCommandBuilder(dataAdapter);
            var ds2 = new DataSet();

            dataAdapter.Fill(ds2);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds2.Tables[0];
        }
        public void paivitaToimipiste()
        {
            btn_paivita.PerformClick();
        }
        public void paivitaPalvelut()
        {
            btn_PäivitäPalvelut.PerformClick();
        }
    }
}
