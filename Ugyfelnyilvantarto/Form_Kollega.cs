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
    public partial class Form_Kollega : Form
    {
        public Form_Kollega()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_fooldalra_Click(object sender, EventArgs e)
        {
            DG_Kollega.Rows.Clear();
            DG_Kollega.Columns.Clear();
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void Form_Kollega_Load(object sender, EventArgs e)
        {
            Kollega_Grid_beallitasai();
            Kollega_Grid_feltoltese();
        }
        private void Kollega_Grid_beallitasai()
        {
            DG_Kollega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Kollega.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_Kollega.MultiSelect = false;
            DG_Kollega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                col_ID.Name = "column1";
                col_ID.DataPropertyName = "k_ID";
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.Visible = false;
            }
            DG_Kollega.Columns.Insert(0, col_ID);

            DataGridViewColumn col_nev = new DataGridViewColumn();
            {
                col_nev.Name = "column2";
                col_nev.DataPropertyName = "k_nev";
                col_nev.HeaderText = "kolléga neve";
                col_nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(1, col_nev);

            DataGridViewColumn col_tel = new DataGridViewColumn();
            {
                col_tel.Name = "column3";
                col_tel.DataPropertyName = "k_tel";
                col_tel.HeaderText = "telefonszám";
                col_tel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(2, col_tel);

            DataGridViewColumn col_mail = new DataGridViewColumn();
            {
                col_mail.Name = "column4";
                col_mail.DataPropertyName = "k_mail";
                col_mail.HeaderText = "e-mail cím";
                col_mail.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(3, col_mail);

            DataGridViewColumn col_mas = new DataGridViewColumn();
            {
                col_mas.Name = "column5";
                col_mas.DataPropertyName = "k_mas";
                col_mas.HeaderText = "más elérhetőség";
                col_mas.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(4, col_mas);

            DataGridViewColumn col_ny1ID = new DataGridViewColumn();
            {
                col_ny1ID.Name = "column6";
                col_ny1ID.DataPropertyName = "k_nyelv1";
                col_ny1ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ny1ID.Visible = false;
            }
            DG_Kollega.Columns.Insert(5, col_ny1ID);

            DataGridViewColumn col_nyelv1 = new DataGridViewColumn();
            {
                col_nyelv1.Name = "column7";
                col_nyelv1.DataPropertyName = "nyelv1";
                col_nyelv1.HeaderText = "nyelv1";
                col_nyelv1.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(6, col_nyelv1);

            DataGridViewColumn col_ny2ID = new DataGridViewColumn();
            {
                col_ny2ID.Name = "column8";
                col_ny2ID.DataPropertyName = "k_nyelv2";
                col_ny2ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ny2ID.Visible = false;
            }
            DG_Kollega.Columns.Insert(7, col_ny2ID);

            DataGridViewColumn col_nyelv2 = new DataGridViewColumn();
            {
                col_nyelv2.Name = "column9";
                col_nyelv2.DataPropertyName = "nyelv2";
                col_nyelv2.HeaderText = "nyelv2";
                col_nyelv2.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(8, col_nyelv2);

            DataGridViewColumn col_ny3ID = new DataGridViewColumn();
            {
                col_ny3ID.Name = "column10";
                col_ny3ID.DataPropertyName = "k_nyelv3";
                col_ny3ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ny3ID.Visible = false;
            }
            DG_Kollega.Columns.Insert(9, col_ny3ID);

            DataGridViewColumn col_nyelv3 = new DataGridViewColumn();
            {
                col_nyelv3.Name = "column11";
                col_nyelv3.DataPropertyName = "nyelv3";
                col_nyelv3.HeaderText = "nyelv3";
                col_nyelv3.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(10, col_nyelv3);

            DataGridViewColumn col_ny4ID = new DataGridViewColumn();
            {
                col_ny4ID.Name = "column12";
                col_ny4ID.DataPropertyName = "k_nyelv4";
                col_ny4ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ny4ID.Visible = false;
            }
            DG_Kollega.Columns.Insert(11, col_ny4ID);

            DataGridViewColumn col_nyelv4 = new DataGridViewColumn();
            {
                col_nyelv4.Name = "column13";
                col_nyelv4.DataPropertyName = "nyelv4";
                col_nyelv4.HeaderText = "nyelv4";
                col_nyelv4.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(12, col_nyelv4);

            DataGridViewColumn col_megj = new DataGridViewColumn();
            {
                col_megj.Name = "column14";
                col_megj.DataPropertyName = "k_megj";
                col_megj.HeaderText = "megjegyzés";
                col_megj.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Kollega.Columns.Insert(13, col_megj);
        }
        private void Kollega_Grid_feltoltese()
        {
            DG_Kollega.Rows.Clear();

            foreach (Kollega item in Program.kollegak)
            {
                int n = DG_Kollega.Rows.Add();
                DG_Kollega.Rows[n].Cells["column1"].Value = item.K_ID;
                DG_Kollega.Rows[n].Cells["column2"].Value = item.K_nev;
                DG_Kollega.Rows[n].Cells["column3"].Value = item.K_tel;
                DG_Kollega.Rows[n].Cells["column4"].Value = item.K_mail;
                DG_Kollega.Rows[n].Cells["column5"].Value = item.K_mas;
                DG_Kollega.Rows[n].Cells["column6"].Value = item.K_nyelv1;
                DG_Kollega.Rows[n].Cells["column7"].Value = item.K_ny1;
                DG_Kollega.Rows[n].Cells["column8"].Value = item.K_nyelv2;
                DG_Kollega.Rows[n].Cells["column9"].Value = item.K_ny2;
                DG_Kollega.Rows[n].Cells["column10"].Value = item.K_nyelv3;
                DG_Kollega.Rows[n].Cells["column11"].Value = item.K_ny3;
                DG_Kollega.Rows[n].Cells["column12"].Value = item.K_nyelv4;
                DG_Kollega.Rows[n].Cells["column13"].Value = item.K_ny4;
                DG_Kollega.Rows[n].Cells["column14"].Value = item.K_megj;
            }
        }

        private void button_kereses_Click(object sender, EventArgs e)
        {
            DG_Kollega.Rows.Clear();
            if (!string.IsNullOrEmpty(textBox_kollega_kereses.Text) && string.IsNullOrEmpty(textBox_nyelvkereses.Text))
            {
                for (int i = 0; i < Program.kollegak.Count; i++)
                {
                    if (Program.kollegak[i].K_nev.Contains(textBox_kollega_kereses.Text.Trim()) || Program.kollegak[i].K_tel.Contains(textBox_kollega_kereses.Text.Trim()) || Program.kollegak[i].K_mail.Contains(textBox_kollega_kereses.Text.Trim()))
                    {
                        int n = DG_Kollega.Rows.Add();
                        DG_Kollega.Rows[n].Cells["column1"].Value = Program.kollegak[i].K_ID;
                        DG_Kollega.Rows[n].Cells["column2"].Value = Program.kollegak[i].K_nev;
                        DG_Kollega.Rows[n].Cells["column3"].Value = Program.kollegak[i].K_tel;
                        DG_Kollega.Rows[n].Cells["column4"].Value = Program.kollegak[i].K_mail;
                        DG_Kollega.Rows[n].Cells["column5"].Value = Program.kollegak[i].K_mas;
                        DG_Kollega.Rows[n].Cells["column6"].Value = Program.kollegak[i].K_nyelv1;
                        DG_Kollega.Rows[n].Cells["column7"].Value = Program.kollegak[i].K_ny1;
                        DG_Kollega.Rows[n].Cells["column8"].Value = Program.kollegak[i].K_nyelv2;
                        DG_Kollega.Rows[n].Cells["column9"].Value = Program.kollegak[i].K_ny2;
                        DG_Kollega.Rows[n].Cells["column10"].Value = Program.kollegak[i].K_nyelv3;
                        DG_Kollega.Rows[n].Cells["column11"].Value = Program.kollegak[i].K_ny3;
                        DG_Kollega.Rows[n].Cells["column12"].Value = Program.kollegak[i].K_nyelv4;
                        DG_Kollega.Rows[n].Cells["column13"].Value = Program.kollegak[i].K_ny4;
                        DG_Kollega.Rows[n].Cells["column14"].Value = Program.kollegak[i].K_megj;
                    }
                }
            }
            else if (string.IsNullOrEmpty(textBox_kollega_kereses.Text) && !string.IsNullOrEmpty(textBox_nyelvkereses.Text))
            {
                for (int i = 0; i < Program.kollegak.Count; i++)
                {
                    if (Program.kollegak[i].K_ny1.Contains(textBox_nyelvkereses.Text.Trim()) || Program.kollegak[i].K_ny2.Contains(textBox_nyelvkereses.Text.Trim()) || Program.kollegak[i].K_ny3.Contains(textBox_nyelvkereses.Text.Trim()) || Program.kollegak[i].K_ny4.Contains(textBox_nyelvkereses.Text.Trim()))
                    {
                        int n = DG_Kollega.Rows.Add();
                        DG_Kollega.Rows[n].Cells["column1"].Value = Program.kollegak[i].K_ID;
                        DG_Kollega.Rows[n].Cells["column2"].Value = Program.kollegak[i].K_nev;
                        DG_Kollega.Rows[n].Cells["column3"].Value = Program.kollegak[i].K_tel;
                        DG_Kollega.Rows[n].Cells["column4"].Value = Program.kollegak[i].K_mail;
                        DG_Kollega.Rows[n].Cells["column5"].Value = Program.kollegak[i].K_mas;
                        DG_Kollega.Rows[n].Cells["column6"].Value = Program.kollegak[i].K_nyelv1;
                        DG_Kollega.Rows[n].Cells["column7"].Value = Program.kollegak[i].K_ny1;
                        DG_Kollega.Rows[n].Cells["column8"].Value = Program.kollegak[i].K_nyelv2;
                        DG_Kollega.Rows[n].Cells["column9"].Value = Program.kollegak[i].K_ny2;
                        DG_Kollega.Rows[n].Cells["column10"].Value = Program.kollegak[i].K_nyelv3;
                        DG_Kollega.Rows[n].Cells["column11"].Value = Program.kollegak[i].K_ny3;
                        DG_Kollega.Rows[n].Cells["column12"].Value = Program.kollegak[i].K_nyelv4;
                        DG_Kollega.Rows[n].Cells["column13"].Value = Program.kollegak[i].K_ny4;
                        DG_Kollega.Rows[n].Cells["column14"].Value = Program.kollegak[i].K_megj;
                    }
                }
            }
            else if (string.IsNullOrEmpty(textBox_kollega_kereses.Text) && string.IsNullOrEmpty(textBox_nyelvkereses.Text))
            {
                Kollega_Grid_feltoltese();
            }
        }
    }
}
