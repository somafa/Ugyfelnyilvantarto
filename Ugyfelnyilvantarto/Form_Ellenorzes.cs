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
    public partial class Form_Ellenorzes : Form
    {
        public Form_Ellenorzes()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_ugyfel_Click(object sender, EventArgs e)
        {
            DG_Ellenorzes.Rows.Clear();
            DG_Ellenorzes.Columns.Clear();
            this.Close();
            Program.form_Ugyfel.Show();
        }

        private void ToolStripMenuItem_kollega_Click(object sender, EventArgs e)
        {
            DG_Ellenorzes.Rows.Clear();
            DG_Ellenorzes.Columns.Clear();
            this.Close();
            Program.form_Kollega.Show();
        }

        private void ToolStripMenuItem_fooldalra_Click(object sender, EventArgs e)
        {
            DG_Ellenorzes.Rows.Clear();
            DG_Ellenorzes.Columns.Clear();
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void Form_Ellenorzes_Load(object sender, EventArgs e)
        {
            Ellenorzes_Grid_beallitasai();
        }
        private void Ellenorzes_Grid_beallitasai()
        {
            DG_Ellenorzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Ellenorzes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_Ellenorzes.MultiSelect = false;
            DG_Ellenorzes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewColumn col_datum = new DataGridViewColumn();
            {
                col_datum.Name = "column1";
                col_datum.DataPropertyName = "datum";
                col_datum.HeaderText = "dátum";
                col_datum.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(0, col_datum);

            DataGridViewColumn col_ugyfel = new DataGridViewColumn();
            {
                col_ugyfel.Name = "column2";
                col_ugyfel.DataPropertyName = "u_nev";
                col_ugyfel.HeaderText = "ügyfél neve";
                col_ugyfel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(1, col_ugyfel);

            DataGridViewColumn col_leiras = new DataGridViewColumn();
            {
                col_leiras.Name = "column3";
                col_leiras.DataPropertyName = "leiras";
                col_leiras.HeaderText = "leírás";
                col_leiras.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(2, col_leiras);

            DataGridViewColumn col_forras = new DataGridViewColumn();
            {
                col_forras.Name = "column4";
                col_forras.DataPropertyName = "forrasnyelv";
                col_forras.HeaderText = "forrás nyelv";
                col_forras.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(3, col_forras);

            DataGridViewColumn col_cel = new DataGridViewColumn();
            {
                col_cel.Name = "column5";
                col_cel.DataPropertyName = "celnyelv";
                col_cel.HeaderText = "cél nyelv";
                col_cel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(4, col_cel);

            DataGridViewColumn col_kollega = new DataGridViewColumn();
            {
                col_kollega.Name = "column6";
                col_kollega.DataPropertyName = "k_nev";
                col_kollega.HeaderText = "kolléga";
                col_kollega.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(5, col_kollega);

            DataGridViewColumn col_kolldij = new DataGridViewColumn();
            {
                col_kolldij.Name = "column7";
                col_kolldij.DataPropertyName = "kollega_dija";
                col_kolldij.HeaderText = "kolléga díja";
                col_kolldij.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(6, col_kolldij);

            DataGridViewColumn col_pld = new DataGridViewColumn();
            {
                col_pld.Name = "column8";
                col_pld.DataPropertyName = "pld";
                col_pld.HeaderText = "példányszám";
                col_pld.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(7, col_pld);

            DataGridViewColumn col_futar = new DataGridViewColumn();
            {
                col_futar.Name = "column9";
                col_futar.DataPropertyName = "futar";
                col_futar.HeaderText = "futár";
                col_futar.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(8, col_futar);

            DataGridViewColumn col_hitel = new DataGridViewColumn();
            {
                col_hitel.Name = "column10";
                col_hitel.DataPropertyName = "hitelesites";
                col_hitel.HeaderText = "hitelesítés";
                col_hitel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(9, col_hitel);

            DataGridViewColumn col_ar = new DataGridViewColumn();
            {
                col_ar.Name = "column11";
                col_ar.DataPropertyName = "ar";
                col_ar.HeaderText = "ár";
                col_ar.CellTemplate = new DataGridViewTextBoxCell();
                col_ar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Ellenorzes.Columns.Insert(10, col_ar);

            DataGridViewColumn col_fizetve = new DataGridViewColumn();
            {
                col_fizetve.Name = "column12";
                col_fizetve.DataPropertyName = "fizetve";
                col_fizetve.HeaderText = "fizetve";
                col_fizetve.CellTemplate = new DataGridViewTextBoxCell();
                col_fizetve.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_Ellenorzes.Columns.Insert(11, col_fizetve);

            DataGridViewColumn col_mikor = new DataGridViewColumn();
            {
                col_mikor.Name = "column13";
                col_mikor.DataPropertyName = "mikor";
                col_mikor.HeaderText = "mikor";
                col_mikor.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(12, col_mikor);

            DataGridViewColumn col_statusz = new DataGridViewColumn();
            {
                col_statusz.Name = "column14";
                col_statusz.DataPropertyName = "statusz";
                col_statusz.HeaderText = "státusz";
                col_statusz.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ellenorzes.Columns.Insert(13, col_statusz);
        }

        private void button_ellenorzes_Click(object sender, EventArgs e)
        {
            DG_Ellenorzes.Rows.Clear();
            DG_Ellenorzes.Columns.Clear();

            if (!string.IsNullOrEmpty(textBox_ugyfel.Text) && string.IsNullOrEmpty(textBox_kollega.Text))
            {
                for (int i = 0; i < Program.ugyfelek.Count; i++)
                {
                    if (Program.munkak[i].U_nev.Equals(textBox_ugyfel.Text))
                    {
                        int n = DG_Ellenorzes.Rows.Add();
                        DG_Ellenorzes.Rows[n].Cells["column1"].Value = Program.munkak[i].Datum.ToString("yyyy.MM.dd");
                        DG_Ellenorzes.Rows[n].Cells["column2"].Value = Program.munkak[i].U_nev;
                        DG_Ellenorzes.Rows[n].Cells["column3"].Value = Program.munkak[i].Leiras;
                        DG_Ellenorzes.Rows[n].Cells["column4"].Value = Program.munkak[i].Forrasny_megnev;
                        DG_Ellenorzes.Rows[n].Cells["column5"].Value = Program.munkak[i].Celny_megnev;
                        DG_Ellenorzes.Rows[n].Cells["column6"].Value = Program.munkak[i].K_nev;
                        DG_Ellenorzes.Rows[n].Cells["column8"].Value = Program.munkak[i].Pld;
                        DG_Ellenorzes.Rows[n].Cells["column9"].Value = Program.munkak[i].Futar;
                        DG_Ellenorzes.Rows[n].Cells["column10"].Value = Program.munkak[i].Hitelesites;
                        DG_Ellenorzes.Rows[n].Cells["column11"].Value = Program.munkak[i].Ar;
                        DG_Ellenorzes.Rows[n].Cells["column12"].Value = Program.munkak[i].Fizetve;
                        DG_Ellenorzes.Rows[n].Cells["column13"].Value = Program.munkak[i].Mikor;
                        DG_Ellenorzes.Rows[n].Cells["column14"].Value = Program.munkak[i].Statusz;
                    }
                }
            }
            else if (string.IsNullOrEmpty(textBox_ugyfel.Text) && !string.IsNullOrEmpty(textBox_kollega.Text))
            {
                for (int i = 0; i < Program.kollegak.Count; i++)
                {
                    if (Program.munkak[i].K_nev.Equals(textBox_kollega.Text))
                    {
                        int n = DG_Ellenorzes.Rows.Add();
                        DG_Ellenorzes.Rows[n].Cells["column1"].Value = Program.munkak[i].Datum.ToString("yyyy.MM.dd");
                        DG_Ellenorzes.Rows[n].Cells["column2"].Value = Program.munkak[i].U_nev;
                        DG_Ellenorzes.Rows[n].Cells["column3"].Value = Program.munkak[i].Leiras;
                        DG_Ellenorzes.Rows[n].Cells["column4"].Value = Program.munkak[i].Forrasny_megnev;
                        DG_Ellenorzes.Rows[n].Cells["column5"].Value = Program.munkak[i].Celny_megnev;
                        DG_Ellenorzes.Rows[n].Cells["column6"].Value = Program.munkak[i].K_nev;
                        DG_Ellenorzes.Rows[n].Cells["column7"].Value = Program.munkak[i].Kollega_dija;
                        DG_Ellenorzes.Rows[n].Cells["column14"].Value = Program.munkak[i].Statusz;
                    }
                }
            }
        }
    }
}
