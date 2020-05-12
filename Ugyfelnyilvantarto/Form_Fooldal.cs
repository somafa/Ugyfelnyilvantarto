using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugyfelnyilvantarto
{
    public partial class Form_Fooldal : Form
    {
        public Form_Fooldal()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_ugyfel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Ugyfel.ShowDialog();
        }

        private void ToolStripMenuItem_kollega_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Kollega.ShowDialog();
        }

        private void ToolStripMenuItem_kilepes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés a programból", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private void Form_Fooldal_Load(object sender, EventArgs e)
        {
            Fooldal_Grid_beallitasai();
            Program.Adatbazis_beolvasas();
            Fooldal_Grid_feltoltese();
            Kivalasztott_Grid_beallitasai();
        }
        private void Fooldal_Grid_beallitasai()
        {
            DG_Fooldal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Fooldal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_Fooldal.MultiSelect = false;
            DG_Fooldal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                col_ID.Name = "column1";
                col_ID.DataPropertyName = "m_ID";
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.Visible = false;
            }
            DG_Fooldal.Columns.Insert(0, col_ID);

            DataGridViewColumn col_datum = new DataGridViewColumn();
            {
                col_datum.Name = "column2";
                col_datum.DataPropertyName = "datum";
                col_datum.HeaderText = "dátum";
                col_datum.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(1, col_datum);

            DataGridViewColumn col_ugyfelID = new DataGridViewColumn();
            {
                col_ugyfelID.Name = "column3";
                col_ugyfelID.DataPropertyName = "u_ID";
                col_ugyfelID.CellTemplate = new DataGridViewTextBoxCell();
                col_ugyfelID.Visible = false;
            }
            DG_Fooldal.Columns.Insert(2, col_ugyfelID);

            DataGridViewColumn col_ugyfel = new DataGridViewColumn();
            {
                col_ugyfel.Name = "column4";
                col_ugyfel.DataPropertyName = "u_nev";
                col_ugyfel.HeaderText = "ügyfél neve";
                col_ugyfel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(3, col_ugyfel);

            DataGridViewColumn col_leiras = new DataGridViewColumn();
            {
                col_leiras.Name = "column5";
                col_leiras.DataPropertyName = "leiras";
                col_leiras.HeaderText = "leírás";
                col_leiras.CellTemplate = new DataGridViewTextBoxCell();
                col_leiras.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            DG_Fooldal.Columns.Insert(4, col_leiras);

            DataGridViewColumn col_forrasID = new DataGridViewColumn();
            {
                col_forrasID.Name = "column6";
                col_forrasID.DataPropertyName = "forrasny_ID";
                col_forrasID.CellTemplate = new DataGridViewTextBoxCell();
                col_forrasID.Visible = false;
            }
            DG_Fooldal.Columns.Insert(5, col_forrasID);

            DataGridViewColumn col_forras = new DataGridViewColumn();
            {
                col_forras.Name = "column7";
                col_forras.DataPropertyName = "forrasnyelv";
                col_forras.HeaderText = "forrás nyelv";
                col_forras.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(6, col_forras);

            DataGridViewColumn col_celID = new DataGridViewColumn();
            {
                col_celID.Name = "column8";
                col_celID.DataPropertyName = "celny_ID";
                col_celID.CellTemplate = new DataGridViewTextBoxCell();
                col_celID.Visible = false;
            }
            DG_Fooldal.Columns.Insert(7, col_celID);

            DataGridViewColumn col_cel = new DataGridViewColumn();
            {
                col_cel.Name = "column9";
                col_cel.DataPropertyName = "celnyelv";
                col_cel.HeaderText = "célnyelv";
                col_cel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(8, col_cel);

            DataGridViewColumn col_kollID = new DataGridViewColumn();
            {
                col_kollID.Name = "column10";
                col_kollID.DataPropertyName = "k_ID";
                col_kollID.CellTemplate = new DataGridViewTextBoxCell();
                col_kollID.Visible = false;
            }
            DG_Fooldal.Columns.Insert(9, col_kollID);

            DataGridViewColumn col_kollega = new DataGridViewColumn();
            {
                col_kollega.Name = "column11";
                col_kollega.DataPropertyName = "k_nev";
                col_kollega.HeaderText = "kolléga";
                col_kollega.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(10, col_kollega);

            DataGridViewColumn col_kolldij = new DataGridViewColumn();
            {
                col_kolldij.Name = "column12";
                col_kolldij.DataPropertyName = "kollega_dija";
                col_kolldij.HeaderText = "kolléga díja";
                col_kolldij.CellTemplate = new DataGridViewTextBoxCell();
                col_kolldij.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Fooldal.Columns.Insert(11, col_kolldij);

            DataGridViewColumn col_pld = new DataGridViewColumn();
            {
                col_pld.Name = "column13";
                col_pld.DataPropertyName = "pld";
                col_pld.HeaderText = "példányszám";
                col_pld.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(12, col_pld);

            DataGridViewColumn col_futar = new DataGridViewColumn();
            {
                col_futar.Name = "column14";
                col_futar.DataPropertyName = "futar";
                col_futar.HeaderText = "futár";
                col_futar.CellTemplate = new DataGridViewTextBoxCell();
                col_futar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Fooldal.Columns.Insert(13, col_futar);

            DataGridViewColumn col_hitel = new DataGridViewColumn();
            {
                col_hitel.Name = "column15";
                col_hitel.DataPropertyName = "hitelesites";
                col_hitel.HeaderText = "hitelesítés";
                col_hitel.CellTemplate = new DataGridViewTextBoxCell();
                col_hitel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Fooldal.Columns.Insert(14, col_hitel);

            DataGridViewColumn col_ar = new DataGridViewColumn();
            {
                col_ar.Name = "column16";
                col_ar.DataPropertyName = "ar";
                col_ar.HeaderText = "ár";
                col_ar.CellTemplate = new DataGridViewTextBoxCell();
                col_ar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Fooldal.Columns.Insert(15, col_ar);

            DataGridViewColumn col_fizetve = new DataGridViewColumn();
            {
                col_fizetve.Name = "column17";
                col_fizetve.DataPropertyName = "fizetve";
                col_fizetve.HeaderText = "fizetve";
                col_fizetve.CellTemplate = new DataGridViewTextBoxCell();
                col_fizetve.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Fooldal.Columns.Insert(16, col_fizetve);

            DataGridViewColumn col_mikor = new DataGridViewColumn();
            {
                col_mikor.Name = "column18";
                col_mikor.DataPropertyName = "mikor";
                col_mikor.HeaderText = "mikor";
                col_mikor.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(17, col_mikor);

            DataGridViewColumn col_statusz = new DataGridViewColumn();
            {
                col_statusz.Name = "column19";
                col_statusz.DataPropertyName = "statusz";
                col_statusz.HeaderText = "státusz";
                col_statusz.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Fooldal.Columns.Insert(18, col_statusz);
        }
        private void Fooldal_Grid_feltoltese()
        {
            DG_Fooldal.Rows.Clear();

            foreach (Munka item in Program.munkak)
            {
                if (checkBox_aktiv.Checked && item.Statusz!="letudva" && item.Statusz != "lemondva")
                {
                    int n = DG_Fooldal.Rows.Add();
                    DG_Fooldal.Rows[n].Cells["column1"].Value = item.M_ID;
                    DG_Fooldal.Rows[n].Cells["column2"].Value = item.Datum.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[n].Cells["column3"].Value = item.U_ID;
                    DG_Fooldal.Rows[n].Cells["column4"].Value = item.U_nev;
                    DG_Fooldal.Rows[n].Cells["column5"].Value = item.Leiras;
                    DG_Fooldal.Rows[n].Cells["column6"].Value = item.Forrasny_ID;
                    DG_Fooldal.Rows[n].Cells["column7"].Value = item.Forrasny_megnev;
                    DG_Fooldal.Rows[n].Cells["column8"].Value = item.Celny_ID;
                    DG_Fooldal.Rows[n].Cells["column9"].Value = item.Celny_megnev;
                    DG_Fooldal.Rows[n].Cells["column10"].Value = item.K_ID;
                    DG_Fooldal.Rows[n].Cells["column11"].Value = item.K_nev;
                    DG_Fooldal.Rows[n].Cells["column12"].Value = item.Kollega_dija;
                    DG_Fooldal.Rows[n].Cells["column13"].Value = item.Pld;
                    DG_Fooldal.Rows[n].Cells["column14"].Value = item.Futar;
                    DG_Fooldal.Rows[n].Cells["column15"].Value = item.Hitelesites;
                    DG_Fooldal.Rows[n].Cells["column16"].Value = item.Ar;
                    DG_Fooldal.Rows[n].Cells["column17"].Value = item.Fizetve;
                    DG_Fooldal.Rows[n].Cells["column18"].Value = item.Mikor.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[n].Cells["column19"].Value = item.Statusz;
                }
                else if (!checkBox_aktiv.Checked)
                {
                    int n = DG_Fooldal.Rows.Add();
                    DG_Fooldal.Rows[n].Cells["column1"].Value = item.M_ID;
                    DG_Fooldal.Rows[n].Cells["column2"].Value = item.Datum.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[n].Cells["column3"].Value = item.U_ID;
                    DG_Fooldal.Rows[n].Cells["column4"].Value = item.U_nev;
                    DG_Fooldal.Rows[n].Cells["column5"].Value = item.Leiras;
                    DG_Fooldal.Rows[n].Cells["column6"].Value = item.Forrasny_ID;
                    DG_Fooldal.Rows[n].Cells["column7"].Value = item.Forrasny_megnev;
                    DG_Fooldal.Rows[n].Cells["column8"].Value = item.Celny_ID;
                    DG_Fooldal.Rows[n].Cells["column9"].Value = item.Celny_megnev;
                    DG_Fooldal.Rows[n].Cells["column10"].Value = item.K_ID;
                    DG_Fooldal.Rows[n].Cells["column11"].Value = item.K_nev;
                    DG_Fooldal.Rows[n].Cells["column12"].Value = item.Kollega_dija;
                    DG_Fooldal.Rows[n].Cells["column13"].Value = item.Pld;
                    DG_Fooldal.Rows[n].Cells["column14"].Value = item.Futar;
                    DG_Fooldal.Rows[n].Cells["column15"].Value = item.Hitelesites;
                    DG_Fooldal.Rows[n].Cells["column16"].Value = item.Ar;
                    DG_Fooldal.Rows[n].Cells["column17"].Value = item.Fizetve;
                    DG_Fooldal.Rows[n].Cells["column18"].Value = item.Mikor.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[n].Cells["column19"].Value = item.Statusz;
                }
            }
        }

        private void checkBox_aktiv_CheckedChanged(object sender, EventArgs e)
        {
            Fooldal_Grid_feltoltese();
        }

        private void DG_Fooldal_SelectionChanged(object sender, EventArgs e)
        {
            if (DG_Fooldal.SelectedRows.Count > 0)
            {
                DataGridViewRow kivalasztott = DG_Fooldal.SelectedRows[0];
                DG_fooldal_kivalasztott.Rows.Clear();
                if (kivalasztott.Cells["column1"].Value != null)
                {
                    Fooldal_kivalasztott_grid_feltoltese((int)kivalasztott.Cells["column1"].Value);
                }
            }
        }
        private void Kivalasztott_Grid_beallitasai()
        {
            DG_fooldal_kivalasztott.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_fooldal_kivalasztott.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_fooldal_kivalasztott.MultiSelect = false;
            DG_fooldal_kivalasztott.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_fooldal_kivalasztott.ReadOnly = true;

            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                col_ID.Name = "column1";
                col_ID.DataPropertyName = "m_ID";
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.Visible = false;
            }
            DG_fooldal_kivalasztott.Columns.Insert(0, col_ID);

            DataGridViewColumn col_datum = new DataGridViewColumn();
            {
                col_datum.Name = "column2";
                col_datum.DataPropertyName = "datum";
                col_datum.DefaultCellStyle.Format = "yyyy.MM.dd";
                col_datum.HeaderText = "dátum";
                col_datum.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(1, col_datum);

            DataGridViewColumn col_ugyfelID = new DataGridViewColumn();
            {
                col_ugyfelID.Name = "column3";
                col_ugyfelID.DataPropertyName = "u_ID";
                col_ugyfelID.CellTemplate = new DataGridViewTextBoxCell();
                col_ugyfelID.Visible = false;
            }
            DG_fooldal_kivalasztott.Columns.Insert(2, col_ugyfelID);

            DataGridViewColumn col_ugyfel = new DataGridViewColumn();
            {
                col_ugyfel.Name = "column4";
                col_ugyfel.DataPropertyName = "u_nev";
                col_ugyfel.HeaderText = "ügyfél neve";
                col_ugyfel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(3, col_ugyfel);

            DataGridViewColumn col_leiras = new DataGridViewColumn();
            {
                col_leiras.Name = "column5";
                col_leiras.DataPropertyName = "leiras";
                col_leiras.HeaderText = "leírás";
                col_leiras.CellTemplate = new DataGridViewTextBoxCell();
                col_leiras.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            DG_fooldal_kivalasztott.Columns.Insert(4, col_leiras);

            DataGridViewColumn col_forrasID = new DataGridViewColumn();
            {
                col_forrasID.Name = "column6";
                col_forrasID.DataPropertyName = "forrasny_ID";
                col_forrasID.CellTemplate = new DataGridViewTextBoxCell();
                col_forrasID.Visible = false;
            }
            DG_fooldal_kivalasztott.Columns.Insert(5, col_forrasID);

            DataGridViewColumn col_forras = new DataGridViewColumn();
            {
                col_forras.Name = "column7";
                col_forras.DataPropertyName = "forrasnyelv";
                col_forras.HeaderText = "forrás nyelv";
                col_forras.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(6, col_forras);

            DataGridViewColumn col_celID = new DataGridViewColumn();
            {
                col_celID.Name = "column8";
                col_celID.DataPropertyName = "celny_ID";
                col_celID.CellTemplate = new DataGridViewTextBoxCell();
                col_celID.Visible = false;
            }
            DG_fooldal_kivalasztott.Columns.Insert(7, col_celID);

            DataGridViewColumn col_cel = new DataGridViewColumn();
            {
                col_cel.Name = "column9";
                col_cel.DataPropertyName = "celnyelv";
                col_cel.HeaderText = "célnyelv";
                col_cel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(8, col_cel);

            DataGridViewColumn col_kollID = new DataGridViewColumn();
            {
                col_kollID.Name = "column10";
                col_kollID.DataPropertyName = "k_ID";
                col_kollID.CellTemplate = new DataGridViewTextBoxCell();
                col_kollID.Visible = false;
            }
            DG_fooldal_kivalasztott.Columns.Insert(9, col_kollID);

            DataGridViewColumn col_kollega = new DataGridViewColumn();
            {
                col_kollega.Name = "column11";
                col_kollega.DataPropertyName = "k_nev";
                col_kollega.HeaderText = "kolléga";
                col_kollega.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(10, col_kollega);

            DataGridViewColumn col_kolldij = new DataGridViewColumn();
            {
                col_kolldij.Name = "column12";
                col_kolldij.DataPropertyName = "kollega_dija";
                col_kolldij.HeaderText = "kolléga díja";
                col_kolldij.CellTemplate = new DataGridViewTextBoxCell();
                col_kolldij.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_fooldal_kivalasztott.Columns.Insert(11, col_kolldij);

            DataGridViewColumn col_pld = new DataGridViewColumn();
            {
                col_pld.Name = "column13";
                col_pld.DataPropertyName = "pld";
                col_pld.HeaderText = "példányszám";
                col_pld.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(12, col_pld);

            DataGridViewColumn col_futar = new DataGridViewColumn();
            {
                col_futar.Name = "column14";
                col_futar.DataPropertyName = "futar";
                col_futar.HeaderText = "futár";
                col_futar.CellTemplate = new DataGridViewTextBoxCell();
                col_futar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_fooldal_kivalasztott.Columns.Insert(13, col_futar);

            DataGridViewColumn col_hitel = new DataGridViewColumn();
            {
                col_hitel.Name = "column15";
                col_hitel.DataPropertyName = "hitelesites";
                col_hitel.HeaderText = "hitelesítés";
                col_hitel.CellTemplate = new DataGridViewTextBoxCell();
                col_hitel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_fooldal_kivalasztott.Columns.Insert(14, col_hitel);

            DataGridViewColumn col_ar = new DataGridViewColumn();
            {
                col_ar.Name = "column16";
                col_ar.DataPropertyName = "ar";
                col_ar.HeaderText = "ár";
                col_ar.CellTemplate = new DataGridViewTextBoxCell();
                col_ar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_fooldal_kivalasztott.Columns.Insert(15, col_ar);

            DataGridViewColumn col_fizetve = new DataGridViewColumn();
            {
                col_fizetve.Name = "column17";
                col_fizetve.DataPropertyName = "fizetve";
                col_fizetve.HeaderText = "fizetve";
                col_fizetve.CellTemplate = new DataGridViewTextBoxCell();
                col_fizetve.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_fooldal_kivalasztott.Columns.Insert(16, col_fizetve);

            DataGridViewColumn col_mikor = new DataGridViewColumn();
            {
                col_mikor.Name = "column18";
                col_mikor.DataPropertyName = "mikor";
                col_mikor.DefaultCellStyle.Format = "yyyy.MM.dd";
                col_mikor.HeaderText = "mikor";
                col_mikor.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(17, col_mikor);

            DataGridViewColumn col_statusz = new DataGridViewColumn();
            {
                col_statusz.Name = "column19";
                col_statusz.DataPropertyName = "statusz";
                col_statusz.HeaderText = "státusz";
                col_statusz.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_fooldal_kivalasztott.Columns.Insert(18, col_statusz);
        }
        private void Fooldal_kivalasztott_grid_feltoltese(int id)
        {
            Program.sql.Parameters.Clear();
            Program.sql.CommandText = "SELECT m_ID, datum, u_ID, u_nev, leiras, forrasny_ID, forrasnyelv, celny_ID, celnyelv, k_ID, k_nev, kollega_dija, pld, futar, hitelesites, ar, fizetve, mikor, statusz FROM dg_fooldal WHERE m_ID=@id";
            Program.sql.Parameters.AddWithValue("@id", id);
            try
            {
                Program.conn.Open();
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    DG_fooldal_kivalasztott.Rows.Clear();
                    while (dr.Read())
                    {
                        int n = DG_fooldal_kivalasztott.Rows.Add();
                        DataGridViewRow sor = DG_fooldal_kivalasztott.Rows[n];
                        DateTime ures = DateTime.MinValue;
                        sor.Cells["column1"].Value = dr.IsDBNull(0) ? 0 : dr.GetInt32("m_ID");
                        sor.Cells["column2"].Value = dr.IsDBNull(1) ? ures : dr.GetDateTime("datum");
                        sor.Cells["column3"].Value = dr.IsDBNull(2) ? 0 : dr.GetInt32("u_ID");
                        sor.Cells["column4"].Value = dr.IsDBNull(3) ? "" : dr.GetString("u_nev");
                        sor.Cells["column5"].Value = dr.IsDBNull(4) ? "" : dr.GetString("leiras");
                        sor.Cells["column6"].Value = dr.IsDBNull(5) ? 0 : dr.GetInt32("forrasny_ID");
                        sor.Cells["column7"].Value = dr.IsDBNull(6) ? "" : dr.GetString("forrasnyelv");
                        sor.Cells["column8"].Value = dr.IsDBNull(7) ? 0 : dr.GetInt32("celny_ID");
                        sor.Cells["column9"].Value = dr.IsDBNull(8) ? "" : dr.GetString("celnyelv");
                        sor.Cells["column10"].Value = dr.IsDBNull(9) ? 0 : dr.GetInt32("k_ID");
                        sor.Cells["column11"].Value = dr.IsDBNull(10) ? "" : dr.GetString("k_nev");
                        sor.Cells["column12"].Value = dr.IsDBNull(11) ? 0 : dr.GetInt32("kollega_dija");
                        sor.Cells["column13"].Value = dr.IsDBNull(12) ? 0 : dr.GetInt32("pld");
                        sor.Cells["column14"].Value = dr.IsDBNull(13) ? 0 : dr.GetInt32("futar");
                        sor.Cells["column15"].Value = dr.IsDBNull(14) ? 0 : dr.GetInt32("hitelesites");
                        sor.Cells["column16"].Value = dr.IsDBNull(15) ? 0 : dr.GetInt32("ar");
                        sor.Cells["column17"].Value = dr.IsDBNull(16) ? 0 : dr.GetInt32("fizetve");
                        sor.Cells["column18"].Value = dr.IsDBNull(17) ? ures : dr.GetDateTime("mikor");
                        sor.Cells["column19"].Value = dr.IsDBNull(18) ? "" : dr.GetString("statusz");
                    }
                }
                Program.conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            DG_fooldal_kivalasztott.ReadOnly = false;
        }

        private void Modositasok_mentese()
        {
            //Program.sql.Parameters.Clear();
            //Program.sql.CommandText = "UPDATE ";
        }
    }
}
