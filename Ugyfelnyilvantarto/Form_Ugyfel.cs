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
    public partial class Form_Ugyfel : Form
    {
        public Form_Ugyfel()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_fooldalra_Click(object sender, EventArgs e)
        {
            DG_Ugyfel.Rows.Clear();
            DG_Ugyfel.Columns.Clear();
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void Form_Ugyfel_Load(object sender, EventArgs e)
        {
            Ugyfel_Grid_beallitasai();
            Ugyfel_Grid_feltoltese();
        }
        private void Ugyfel_Grid_beallitasai()
        {
            DG_Ugyfel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Ugyfel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_Ugyfel.MultiSelect = false;
            DG_Ugyfel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                col_ID.Name = "column1";
                col_ID.DataPropertyName = "u_ID";
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.Visible = false;
            }
            DG_Ugyfel.Columns.Insert(0, col_ID);

            DataGridViewColumn col_nev = new DataGridViewColumn();
            {
                col_nev.Name = "column2";
                col_nev.DataPropertyName = "u_nev";
                col_nev.HeaderText = "ügyfél neve";
                col_nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(1, col_nev);

            DataGridViewColumn col_tel = new DataGridViewColumn();
            {
                col_tel.Name = "column3";
                col_tel.DataPropertyName = "u_tel";
                col_tel.HeaderText = "telefonszám";
                col_tel.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(2, col_tel);

            DataGridViewColumn col_mail = new DataGridViewColumn();
            {
                col_mail.Name = "column4";
                col_mail.DataPropertyName = "u_mail";
                col_mail.HeaderText = "e-mail cím";
                col_mail.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(3, col_mail);

            DataGridViewColumn col_mas = new DataGridViewColumn();
            {
                col_mas.Name = "column5";
                col_mas.DataPropertyName = "u_mas";
                col_mas.HeaderText = "más elérhetőség";
                col_mas.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(4, col_mas);

            DataGridViewColumn col_szekhely = new DataGridViewColumn();
            {
                col_szekhely.Name = "column6";
                col_szekhely.DataPropertyName = "u_szekhely";
                col_szekhely.HeaderText = "székhely";
                col_szekhely.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(5, col_szekhely);

            DataGridViewColumn col_adoszam = new DataGridViewColumn();
            {
                col_adoszam.Name = "column7";
                col_adoszam.DataPropertyName = "u_adoszam";
                col_adoszam.HeaderText = "adószám";
                col_adoszam.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(6, col_adoszam);

            DataGridViewColumn col_cegj = new DataGridViewColumn();
            {
                col_cegj.Name = "column8";
                col_cegj.DataPropertyName = "u_cegj";
                col_cegj.HeaderText = "cégjegyzékszám";
                col_cegj.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(7, col_cegj);

            DataGridViewColumn col_bank = new DataGridViewColumn();
            {
                col_bank.Name = "column9";
                col_bank.DataPropertyName = "u_bank";
                col_bank.HeaderText = "bank";
                col_bank.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(8, col_bank);

            DataGridViewColumn col_iban = new DataGridViewColumn();
            {
                col_iban.Name = "column10";
                col_iban.DataPropertyName = "u_iban";
                col_iban.HeaderText = "IBAN kód";
                col_iban.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(9, col_iban);

            DataGridViewColumn col_megj = new DataGridViewColumn();
            {
                col_megj.Name = "column11";
                col_megj.DataPropertyName = "u_megj";
                col_megj.HeaderText = "megjegyzés";
                col_megj.CellTemplate = new DataGridViewTextBoxCell();
            }
            DG_Ugyfel.Columns.Insert(10, col_megj);
        }
        private void Ugyfel_Grid_feltoltese()
        {
            DG_Ugyfel.Rows.Clear();

            foreach (Ugyfel item in Program.ugyfelek)
            {
                int n = DG_Ugyfel.Rows.Add();
                DG_Ugyfel.Rows[n].Cells["column1"].Value = item.U_ID;
                DG_Ugyfel.Rows[n].Cells["column2"].Value = item.U_nev;
                DG_Ugyfel.Rows[n].Cells["column3"].Value = item.U_tel;
                DG_Ugyfel.Rows[n].Cells["column4"].Value = item.U_mail;
                DG_Ugyfel.Rows[n].Cells["column5"].Value = item.U_mas;
                DG_Ugyfel.Rows[n].Cells["column6"].Value = item.U_szekhely;
                DG_Ugyfel.Rows[n].Cells["column7"].Value = item.U_adoszam;
                DG_Ugyfel.Rows[n].Cells["column8"].Value = item.U_cegj;
                DG_Ugyfel.Rows[n].Cells["column9"].Value = item.U_bank;
                DG_Ugyfel.Rows[n].Cells["column10"].Value = item.U_iban;
                DG_Ugyfel.Rows[n].Cells["column11"].Value = item.U_megj;
            }
        }
        private void button_kereses_Click(object sender, EventArgs e)
        {
            DG_Ugyfel.Rows.Clear();

            for (int i = 0; i < Program.ugyfelek.Count; i++)
            {
                if (Program.ugyfelek[i].U_nev.Contains(textBox_ugyfel_kereses.Text.Trim()) || Program.ugyfelek[i].U_tel.Contains(textBox_ugyfel_kereses.Text.Trim()) || Program.ugyfelek[i].U_mail.Contains(textBox_ugyfel_kereses.Text.Trim()))
                {
                    int n = DG_Ugyfel.Rows.Add();
                    DG_Ugyfel.Rows[n].Cells["column1"].Value = Program.ugyfelek[i].U_ID;
                    DG_Ugyfel.Rows[n].Cells["column2"].Value = Program.ugyfelek[i].U_nev;
                    DG_Ugyfel.Rows[n].Cells["column3"].Value = Program.ugyfelek[i].U_tel;
                    DG_Ugyfel.Rows[n].Cells["column4"].Value = Program.ugyfelek[i].U_mail;
                    DG_Ugyfel.Rows[n].Cells["column5"].Value = Program.ugyfelek[i].U_mas;
                    DG_Ugyfel.Rows[n].Cells["column6"].Value = Program.ugyfelek[i].U_szekhely;
                    DG_Ugyfel.Rows[n].Cells["column7"].Value = Program.ugyfelek[i].U_adoszam;
                    DG_Ugyfel.Rows[n].Cells["column8"].Value = Program.ugyfelek[i].U_cegj;
                    DG_Ugyfel.Rows[n].Cells["column9"].Value = Program.ugyfelek[i].U_bank;
                    DG_Ugyfel.Rows[n].Cells["column10"].Value = Program.ugyfelek[i].U_iban;
                    DG_Ugyfel.Rows[n].Cells["column11"].Value = Program.ugyfelek[i].U_megj;
                }
            }
        }
    }
}
