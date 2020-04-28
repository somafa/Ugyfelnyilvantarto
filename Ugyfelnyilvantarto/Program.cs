using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ugyfelnyilvantarto
{
    static class Program
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        public static Form form_Fooldal = null;
        public static Form form_Ugyfel = null;
        public static Form form_Kollega = null;
        public static Form form_Nyelvek = null;
        public static Form form_Ellenorzes = null;
        public static List<Munka> munkak = new List<Munka>();
        public static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        public static List<Kollega> kollegak = new List<Kollega>();
        public static List<Nyelv> nyelvek = new List<Nyelv>();
        public static Munka kiv_munka = new Munka();
        static void Main()
        {
            MySqlBaseConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "ugyfelnyilvantarto";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Fooldal = new Form_Fooldal();
            form_Ugyfel = new Form_Ugyfel();
            form_Kollega = new Form_Kollega();
            form_Nyelvek = new Form_Nyelvek();
            form_Ellenorzes = new Form_Ellenorzes();
            Application.Run(form_Fooldal);
        }
        public static void Adatbazis_beolvasas()
        {
            sql.Parameters.Clear();
            sql.CommandText = "SELECT m_ID, datum, u_ID, u_nev, leiras, forrasny_ID, forrasnyelv, celny_ID, celnyelv, k_ID, k_nev, kollega_dija, pld, futar, hitelesites, ar, fizetve, mikor, statusz FROM dg_fooldal ORDER BY datum";
            try
            {
                conn.Open();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Munka uj = new Munka();
                        DateTime ures = DateTime.MinValue;
                        uj.M_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("m_ID");
                        uj.Datum = dr.IsDBNull(1) ? ures : dr.GetDateTime("datum");
                        uj.U_ID = dr.IsDBNull(2) ? 0 : dr.GetInt32("u_ID");
                        uj.U_nev = dr.IsDBNull(3) ? "" : dr.GetString("u_nev");
                        uj.Leiras = dr.IsDBNull(4) ? "" : dr.GetString("leiras");
                        uj.Forrasny_ID = dr.IsDBNull(5) ? 0 : dr.GetInt32("forrasny_ID");
                        uj.Forrasny_megnev = dr.IsDBNull(6) ? "" : dr.GetString("forrasnyelv");
                        uj.Celny_ID = dr.IsDBNull(7) ? 0 : dr.GetInt32("celny_ID");
                        uj.Celny_megnev = dr.IsDBNull(8) ? "" : dr.GetString("celnyelv");
                        uj.K_ID = dr.IsDBNull(9) ? 0 : dr.GetInt32("k_ID");
                        uj.K_nev = dr.IsDBNull(10) ? "" : dr.GetString("k_nev");
                        uj.Kollega_dija = dr.IsDBNull(11) ? 0 : dr.GetInt32("kollega_dija");
                        uj.Pld = dr.IsDBNull(12) ? 0 : dr.GetInt32("pld");
                        uj.Futar = dr.IsDBNull(13) ? 0 : dr.GetInt32("futar");
                        uj.Hitelesites = dr.IsDBNull(14) ? 0 : dr.GetInt32("hitelesites");
                        uj.Ar = dr.IsDBNull(15) ? 0 : dr.GetInt32("ar");
                        uj.Fizetve = dr.IsDBNull(16) ? 0 : dr.GetInt32("fizetve");
                        uj.Mikor = dr.IsDBNull(17) ? ures : dr.GetDateTime("mikor");
                        uj.Statusz = dr.IsDBNull(18) ? "" : dr.GetString("statusz");
                        munkak.Add(uj);
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            sql.Parameters.Clear();
            sql.CommandText = "SELECT u_ID, u_nev, u_tel, u_mail, u_mas, u_szekhely, u_adoszam, u_cegj, u_bank, u_iban, u_megj FROM ugyfel ORDER BY u_ID";
            try
            {
                conn.Open();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Ugyfel uj = new Ugyfel();
                        uj.U_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("u_ID");
                        uj.U_nev = dr.IsDBNull(1) ? "" : dr.GetString("u_nev");
                        uj.U_tel = dr.IsDBNull(2) ? "" : dr.GetString("u_tel");
                        uj.U_mail = dr.IsDBNull(3) ? "" : dr.GetString("u_mail");
                        uj.U_mas = dr.IsDBNull(4) ? "" : dr.GetString("u_mas");
                        uj.U_szekhely = dr.IsDBNull(5) ? "" : dr.GetString("u_szekhely");
                        uj.U_adoszam = dr.IsDBNull(6) ? "" : dr.GetString("u_adoszam");
                        uj.U_cegj = dr.IsDBNull(7) ? "" : dr.GetString("u_cegj");
                        uj.U_bank = dr.IsDBNull(8) ? "" : dr.GetString("u_bank");
                        uj.U_iban = dr.IsDBNull(9) ? "" : dr.GetString("u_iban");
                        uj.U_megj = dr.IsDBNull(10) ? "" : dr.GetString("u_megj");
                        ugyfelek.Add(uj);
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            sql.Parameters.Clear();
            sql.CommandText = "SELECT k_ID, k_nev, k_tel, k_mail, k_mas, k_nyelv1, nyelv1, k_nyelv2, nyelv2, k_nyelv3, nyelv3, k_nyelv4, nyelv4, k_megj FROM dg_kollega ORDER BY k_ID";
            try
            {
                conn.Open();
                using (MySqlDataReader dr=sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kollega uj = new Kollega();
                        uj.K_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("k_ID");
                        uj.K_nev = dr.IsDBNull(1) ? "" : dr.GetString("k_nev");
                        uj.K_tel = dr.IsDBNull(2) ? "" : dr.GetString("k_tel");
                        uj.K_mail = dr.IsDBNull(3) ? "" : dr.GetString("k_mail");
                        uj.K_mas = dr.IsDBNull(4) ? "" : dr.GetString("k_mas");
                        uj.K_nyelv1 = dr.IsDBNull(5) ? 0 : dr.GetInt32("k_nyelv1");
                        uj.K_ny1 = dr.IsDBNull(6) ? "" : dr.GetString("nyelv1");
                        uj.K_nyelv2 = dr.IsDBNull(7) ? 0 : dr.GetInt32("k_nyelv2");
                        uj.K_ny2 = dr.IsDBNull(8) ? "" : dr.GetString("nyelv2");
                        uj.K_nyelv3 = dr.IsDBNull(9) ? 0 : dr.GetInt32("k_nyelv3");
                        uj.K_ny3 = dr.IsDBNull(10) ? "" : dr.GetString("nyelv3");
                        uj.K_nyelv4 = dr.IsDBNull(11) ? 0 : dr.GetInt32("k_nyelv4");
                        uj.K_ny4 = dr.IsDBNull(12) ? "" : dr.GetString("nyelv4");
                        uj.K_megj = dr.IsDBNull(13) ? "" : dr.GetString("k_megj");
                        kollegak.Add(uj);
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            sql.Parameters.Clear();
            sql.CommandText = "SELECT ny_ID, megnevezes FROM nyelvek ORDER BY ny_ID";
            try
            {
                conn.Open();
                using (MySqlDataReader dr=sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Nyelv uj = new Nyelv();
                        uj.Ny_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("ny_ID");
                        uj.Megnevezes = dr.IsDBNull(1) ? "" : dr.GetString("megnevezes");
                        nyelvek.Add(uj);
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
