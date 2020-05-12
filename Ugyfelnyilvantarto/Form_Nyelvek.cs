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
    public partial class Form_Nyelvek : Form
    {
        public Form_Nyelvek()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_ugyfel_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_Ugyfel.Show();
        }

        private void ToolStripMenuItem_kollega_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_Kollega.Show();
        }

        private void ToolStripMenuItem_fooldalra_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void Form_Nyelvek_Load(object sender, EventArgs e)
        {
            Nyelv_Lista_feltoltese();
        }
        private void Nyelv_Lista_feltoltese()
        {
            foreach (Nyelv item in Program.nyelvek)
            {
                listBox_nyelvek.Items.Add(item);
            }
        }
    }
}
