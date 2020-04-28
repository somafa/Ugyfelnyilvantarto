namespace Ugyfelnyilvantarto
{
    partial class Form_Kollega
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_fooldalra = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ellenorzes = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.button_modositas = new System.Windows.Forms.Button();
            this.button_hasznal = new System.Windows.Forms.Button();
            this.button_ujkollega = new System.Windows.Forms.Button();
            this.DG_kollega_kivalasztott = new System.Windows.Forms.DataGridView();
            this.button_kereses = new System.Windows.Forms.Button();
            this.textBox_kollega_kereses = new System.Windows.Forms.TextBox();
            this.textBox_nyelvkereses = new System.Windows.Forms.TextBox();
            this.DG_Kollega = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_kollega_kivalasztott)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Kollega)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_fooldalra});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_fooldalra
            // 
            this.ToolStripMenuItem_fooldalra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_fooldalra.Name = "ToolStripMenuItem_fooldalra";
            this.ToolStripMenuItem_fooldalra.Size = new System.Drawing.Size(84, 24);
            this.ToolStripMenuItem_fooldalra.Text = "Főoldalra";
            this.ToolStripMenuItem_fooldalra.Click += new System.EventHandler(this.ToolStripMenuItem_fooldalra_Click);
            // 
            // button_ellenorzes
            // 
            this.button_ellenorzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ellenorzes.Location = new System.Drawing.Point(985, 31);
            this.button_ellenorzes.Name = "button_ellenorzes";
            this.button_ellenorzes.Size = new System.Drawing.Size(116, 40);
            this.button_ellenorzes.TabIndex = 3;
            this.button_ellenorzes.Text = "Ellenőrzés";
            this.button_ellenorzes.UseVisualStyleBackColor = true;
            // 
            // button_mentes
            // 
            this.button_mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mentes.Location = new System.Drawing.Point(773, 31);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(116, 40);
            this.button_mentes.TabIndex = 4;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = true;
            // 
            // button_modositas
            // 
            this.button_modositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modositas.Location = new System.Drawing.Point(567, 31);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(116, 40);
            this.button_modositas.TabIndex = 5;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = true;
            // 
            // button_hasznal
            // 
            this.button_hasznal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hasznal.Location = new System.Drawing.Point(356, 31);
            this.button_hasznal.Name = "button_hasznal";
            this.button_hasznal.Size = new System.Drawing.Size(116, 40);
            this.button_hasznal.TabIndex = 6;
            this.button_hasznal.Text = "Használom";
            this.button_hasznal.UseVisualStyleBackColor = true;
            // 
            // button_ujkollega
            // 
            this.button_ujkollega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ujkollega.Location = new System.Drawing.Point(153, 31);
            this.button_ujkollega.Name = "button_ujkollega";
            this.button_ujkollega.Size = new System.Drawing.Size(116, 40);
            this.button_ujkollega.TabIndex = 7;
            this.button_ujkollega.Text = "Új kolléga";
            this.button_ujkollega.UseVisualStyleBackColor = true;
            // 
            // DG_kollega_kivalasztott
            // 
            this.DG_kollega_kivalasztott.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_kollega_kivalasztott.Location = new System.Drawing.Point(12, 77);
            this.DG_kollega_kivalasztott.Name = "DG_kollega_kivalasztott";
            this.DG_kollega_kivalasztott.Size = new System.Drawing.Size(1230, 72);
            this.DG_kollega_kivalasztott.TabIndex = 8;
            // 
            // button_kereses
            // 
            this.button_kereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kereses.Location = new System.Drawing.Point(570, 155);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(116, 40);
            this.button_kereses.TabIndex = 10;
            this.button_kereses.Text = "Keresés";
            this.button_kereses.UseVisualStyleBackColor = true;
            this.button_kereses.Click += new System.EventHandler(this.button_kereses_Click);
            // 
            // textBox_kollega_kereses
            // 
            this.textBox_kollega_kereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kollega_kereses.Location = new System.Drawing.Point(360, 163);
            this.textBox_kollega_kereses.Name = "textBox_kollega_kereses";
            this.textBox_kollega_kereses.Size = new System.Drawing.Size(175, 24);
            this.textBox_kollega_kereses.TabIndex = 9;
            // 
            // textBox_nyelvkereses
            // 
            this.textBox_nyelvkereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nyelvkereses.Location = new System.Drawing.Point(719, 163);
            this.textBox_nyelvkereses.Name = "textBox_nyelvkereses";
            this.textBox_nyelvkereses.Size = new System.Drawing.Size(175, 24);
            this.textBox_nyelvkereses.TabIndex = 11;
            // 
            // DG_Kollega
            // 
            this.DG_Kollega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Kollega.Location = new System.Drawing.Point(12, 201);
            this.DG_Kollega.Name = "DG_Kollega";
            this.DG_Kollega.Size = new System.Drawing.Size(1230, 455);
            this.DG_Kollega.TabIndex = 12;
            // 
            // Form_Kollega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.DG_Kollega);
            this.Controls.Add(this.textBox_nyelvkereses);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.textBox_kollega_kereses);
            this.Controls.Add(this.DG_kollega_kivalasztott);
            this.Controls.Add(this.button_ellenorzes);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_modositas);
            this.Controls.Add(this.button_hasznal);
            this.Controls.Add(this.button_ujkollega);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Kollega";
            this.Text = "Kolléga";
            this.Load += new System.EventHandler(this.Form_Kollega_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_kollega_kivalasztott)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Kollega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_fooldalra;
        private System.Windows.Forms.Button button_ellenorzes;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.Button button_hasznal;
        private System.Windows.Forms.Button button_ujkollega;
        private System.Windows.Forms.DataGridView DG_kollega_kivalasztott;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.TextBox textBox_kollega_kereses;
        private System.Windows.Forms.TextBox textBox_nyelvkereses;
        private System.Windows.Forms.DataGridView DG_Kollega;
    }
}