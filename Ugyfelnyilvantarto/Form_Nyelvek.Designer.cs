namespace Ugyfelnyilvantarto
{
    partial class Form_Nyelvek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_nyelv_kivalasztas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_ugyfel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_kollega = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_fooldalra = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_nyelv = new System.Windows.Forms.TextBox();
            this.listBox_nyelvek = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_nyelv_kivalasztas
            // 
            this.button_nyelv_kivalasztas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nyelv_kivalasztas.Location = new System.Drawing.Point(94, 33);
            this.button_nyelv_kivalasztas.Name = "button_nyelv_kivalasztas";
            this.button_nyelv_kivalasztas.Size = new System.Drawing.Size(175, 40);
            this.button_nyelv_kivalasztas.TabIndex = 14;
            this.button_nyelv_kivalasztas.Text = "Nyelv kiválasztása";
            this.button_nyelv_kivalasztas.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ugyfel,
            this.ToolStripMenuItem_kollega,
            this.ToolStripMenuItem_fooldalra});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_ugyfel
            // 
            this.ToolStripMenuItem_ugyfel.Name = "ToolStripMenuItem_ugyfel";
            this.ToolStripMenuItem_ugyfel.Size = new System.Drawing.Size(115, 24);
            this.ToolStripMenuItem_ugyfel.Text = "Ügyfél oldalra";
            this.ToolStripMenuItem_ugyfel.Click += new System.EventHandler(this.ToolStripMenuItem_ugyfel_Click);
            // 
            // ToolStripMenuItem_kollega
            // 
            this.ToolStripMenuItem_kollega.Name = "ToolStripMenuItem_kollega";
            this.ToolStripMenuItem_kollega.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem_kollega.Text = "Kolléga oldalra";
            this.ToolStripMenuItem_kollega.Click += new System.EventHandler(this.ToolStripMenuItem_kollega_Click);
            // 
            // ToolStripMenuItem_fooldalra
            // 
            this.ToolStripMenuItem_fooldalra.Name = "ToolStripMenuItem_fooldalra";
            this.ToolStripMenuItem_fooldalra.Size = new System.Drawing.Size(84, 24);
            this.ToolStripMenuItem_fooldalra.Text = "Főoldalra";
            this.ToolStripMenuItem_fooldalra.Click += new System.EventHandler(this.ToolStripMenuItem_fooldalra_Click);
            // 
            // textBox_nyelv
            // 
            this.textBox_nyelv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nyelv.Location = new System.Drawing.Point(94, 93);
            this.textBox_nyelv.Name = "textBox_nyelv";
            this.textBox_nyelv.Size = new System.Drawing.Size(175, 24);
            this.textBox_nyelv.TabIndex = 17;
            // 
            // listBox_nyelvek
            // 
            this.listBox_nyelvek.FormattingEnabled = true;
            this.listBox_nyelvek.Location = new System.Drawing.Point(94, 139);
            this.listBox_nyelvek.Name = "listBox_nyelvek";
            this.listBox_nyelvek.Size = new System.Drawing.Size(175, 277);
            this.listBox_nyelvek.TabIndex = 18;
            // 
            // Form_Nyelvek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 430);
            this.Controls.Add(this.listBox_nyelvek);
            this.Controls.Add(this.textBox_nyelv);
            this.Controls.Add(this.button_nyelv_kivalasztas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyelvek";
            this.Text = "Nyelvek";
            this.Load += new System.EventHandler(this.Form_Nyelvek_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nyelv_kivalasztas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ugyfel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_kollega;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_fooldalra;
        private System.Windows.Forms.TextBox textBox_nyelv;
        private System.Windows.Forms.ListBox listBox_nyelvek;
    }
}