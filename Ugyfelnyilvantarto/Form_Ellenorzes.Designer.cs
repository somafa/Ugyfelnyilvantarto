namespace Ugyfelnyilvantarto
{
    partial class Form_Ellenorzes
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
            this.textBox_ugyfel = new System.Windows.Forms.TextBox();
            this.button_ellenorzes = new System.Windows.Forms.Button();
            this.textBox_kollega = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_ugyfel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_kollega = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_fooldalra = new System.Windows.Forms.ToolStripMenuItem();
            this.DG_Ellenorzes = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ellenorzes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ugyfel
            // 
            this.textBox_ugyfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ugyfel.Location = new System.Drawing.Point(718, 39);
            this.textBox_ugyfel.Name = "textBox_ugyfel";
            this.textBox_ugyfel.Size = new System.Drawing.Size(175, 24);
            this.textBox_ugyfel.TabIndex = 14;
            // 
            // button_ellenorzes
            // 
            this.button_ellenorzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ellenorzes.Location = new System.Drawing.Point(570, 31);
            this.button_ellenorzes.Name = "button_ellenorzes";
            this.button_ellenorzes.Size = new System.Drawing.Size(116, 40);
            this.button_ellenorzes.TabIndex = 13;
            this.button_ellenorzes.Text = "Ellenőrzés";
            this.button_ellenorzes.UseVisualStyleBackColor = true;
            this.button_ellenorzes.Click += new System.EventHandler(this.button_ellenorzes_Click);
            // 
            // textBox_kollega
            // 
            this.textBox_kollega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kollega.Location = new System.Drawing.Point(359, 39);
            this.textBox_kollega.Name = "textBox_kollega";
            this.textBox_kollega.Size = new System.Drawing.Size(175, 24);
            this.textBox_kollega.TabIndex = 12;
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
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
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
            // DG_Ellenorzes
            // 
            this.DG_Ellenorzes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Ellenorzes.Location = new System.Drawing.Point(12, 79);
            this.DG_Ellenorzes.Name = "DG_Ellenorzes";
            this.DG_Ellenorzes.Size = new System.Drawing.Size(1230, 359);
            this.DG_Ellenorzes.TabIndex = 16;
            // 
            // Form_Ellenorzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.DG_Ellenorzes);
            this.Controls.Add(this.textBox_ugyfel);
            this.Controls.Add(this.button_ellenorzes);
            this.Controls.Add(this.textBox_kollega);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Ellenorzes";
            this.Text = "Ellenőrzés";
            this.Load += new System.EventHandler(this.Form_Ellenorzes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ellenorzes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ugyfel;
        private System.Windows.Forms.Button button_ellenorzes;
        private System.Windows.Forms.TextBox textBox_kollega;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ugyfel;
        private System.Windows.Forms.DataGridView DG_Ellenorzes;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_kollega;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_fooldalra;
    }
}