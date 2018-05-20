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
    public partial class LaskuPohja : Form
    {
        public LaskuPohja()
        {
            InitializeComponent();
        }

        public static string lasku_id;
        public static string nimi;
        public static string lahiosoite;
        public static string postitoimipaikka;
        public static string email;
        public static string viite;
        public static DateTime paivays;
        public static DateTime erapaiva;
        public static string varaus_id;
        public static string summa;

        public static string Lasku_id
        {
            get { return lasku_id; }
            set { lasku_id = value; }
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

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        public static string Viite
        {
            get { return viite; }
            set { viite = value; }
        }

        public static DateTime Paivays
        {
            get { return paivays; }
            set { paivays = value; }
        }

        public static DateTime Erapaiva
        {
            get { return erapaiva ; }
            set { erapaiva = value; }
        }

        public static string Varaus_Id
        {
            get { return varaus_id; }
            set { varaus_id = value; }
        }

        public static string Summa
        {
            get { return summa; }
            set { summa = value; }
        }

        private void LaskuPohja_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=|DataDirectory|\mokkivaraus.mdf; Integrated Security=True"))
            {
                try
                {
                    // Määritellään SQL-tietokannasta tehtävä haku.
                    string query = "SELECT Lasku.lasku_id, Lasku.nimi, Lasku.lahiosoite, Lasku.postitoimipaikka, Lasku.email, Lasku.summa, Lasku.alv, Lasku.paivays, Varaus.varaus_id " +
                        "FROM Lasku " +
                        "INNER JOIN Varaus ON Varaus.varaus_id = Lasku.varaus_id " +
                        "WHERE Varaus.varaus_id = @varaus_id";
                        
                    SqlCommand command = new SqlCommand(query, connection);

                    // Suorita haku tietokannasta ja vie hakutulokset
                    //DataGridView-näkymään tarkasteltavaksi.
                    command.Parameters.Add("@varaus_id", SqlDbType.Int).Value = Convert.ToInt32(Laskutus.Varaus_id);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);

                    nimi = ds.Tables[0].Rows[0]["nimi"].ToString();
                    lahiosoite = ds.Tables[0].Rows[0]["lahiosoite"].ToString();
                    postitoimipaikka = ds.Tables[0].Rows[0]["postitoimipaikka"].ToString();
                    email = ds.Tables[0].Rows[0]["email"].ToString();
                    lasku_id = ds.Tables[0].Rows[0]["lasku_id"].ToString();
                    paivays = DateTime.Parse(ds.Tables[0].Rows[0]["paivays"].ToString());
                    erapaiva = DateTime.Parse(ds.Tables[0].Rows[0]["paivays"].ToString()).AddDays(14);
                    varaus_id = ds.Tables[0].Rows[0]["varaus_id"].ToString();
                    summa = ds.Tables[0].Rows[0]["summa"].ToString();
                    viite = DateTime.Parse(ds.Tables[0].Rows[0]["paivays"].ToString()).Year + ds.Tables[0].Rows[0]["varaus_id"].ToString();
                }
                catch (Exception ex)
                {
                    // Tulosta virheilmoitus.
                    MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    // Määritellään raportin parametrit.
                    Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuNimi", LaskuPohja.Nimi),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuLahiosoite", LaskuPohja.Lahiosoite),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuPostitoimipaikka", LaskuPohja.Postitoimipaikka),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuEmail", LaskuPohja.Email),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuId", LaskuPohja.Lasku_id),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuViite", LaskuPohja.Viite.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuPaivays", LaskuPohja.Paivays.ToShortDateString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuErapaiva", LaskuPohja.Erapaiva.ToShortDateString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuVarausId", LaskuPohja.Varaus_Id),
                        new Microsoft.Reporting.WinForms.ReportParameter("LaskuSumma", LaskuPohja.Summa),
                    };

                    // Vie edellä määritellyt parametrit ReportViewer-ikkunaan.
                    this.reportViewer_LaskuPohja.LocalReport.SetParameters(parameters);
                    this.reportViewer_LaskuPohja.RefreshReport();
                }
                catch(Exception ex)
                {
                    // Tulosta virheilmoitus.
                    MessageBox.Show("Tapahtui virhe: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
