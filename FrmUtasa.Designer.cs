namespace WFA220112
{
    partial class FrmUtasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUtasKod = new System.Windows.Forms.TextBox();
            this.rtbCim = new System.Windows.Forms.RichTextBox();
            this.msUtas = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUresUrlap = new System.Windows.Forms.ToolStripMenuItem();
            this.cbJelentkezes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.msUtas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utas kód:";
            // 
            // tbUtasKod
            // 
            this.tbUtasKod.Enabled = false;
            this.tbUtasKod.Location = new System.Drawing.Point(125, 32);
            this.tbUtasKod.Name = "tbUtasKod";
            this.tbUtasKod.Size = new System.Drawing.Size(121, 23);
            this.tbUtasKod.TabIndex = 1;
            this.tbUtasKod.TextChanged += new System.EventHandler(this.tbUtasKod_TextChanged);
            // 
            // rtbCim
            // 
            this.rtbCim.Location = new System.Drawing.Point(125, 150);
            this.rtbCim.Name = "rtbCim";
            this.rtbCim.Size = new System.Drawing.Size(302, 96);
            this.rtbCim.TabIndex = 2;
            this.rtbCim.Text = "";
            // 
            // msUtas
            // 
            this.msUtas.Dock = System.Windows.Forms.DockStyle.Right;
            this.msUtas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmiKereses,
            this.tsmiMentes,
            this.tsmiTorles,
            this.tsmiUresUrlap});
            this.msUtas.Location = new System.Drawing.Point(417, 0);
            this.msUtas.Name = "msUtas";
            this.msUtas.Padding = new System.Windows.Forms.Padding(6, 40, 0, 2);
            this.msUtas.Size = new System.Drawing.Size(126, 337);
            this.msUtas.TabIndex = 3;
            this.msUtas.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 4);
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::WFA220112.Properties.Resources.keres;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(113, 55);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiKereses.Click += new System.EventHandler(this.TsmiKereses_Click);
            // 
            // tsmiMentes
            // 
            this.tsmiMentes.Image = global::WFA220112.Properties.Resources.ment;
            this.tsmiMentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMentes.Name = "tsmiMentes";
            this.tsmiMentes.Size = new System.Drawing.Size(113, 55);
            this.tsmiMentes.Text = "Mentés";
            this.tsmiMentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiMentes.Click += new System.EventHandler(this.TsmiMentes_Click);
            // 
            // tsmiTorles
            // 
            this.tsmiTorles.Enabled = false;
            this.tsmiTorles.Image = global::WFA220112.Properties.Resources.delete;
            this.tsmiTorles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTorles.Name = "tsmiTorles";
            this.tsmiTorles.Size = new System.Drawing.Size(113, 55);
            this.tsmiTorles.Text = "Törlés";
            this.tsmiTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiTorles.Click += new System.EventHandler(this.TsmiTorles_Click);
            // 
            // tsmiUresUrlap
            // 
            this.tsmiUresUrlap.Image = global::WFA220112.Properties.Resources.ures;
            this.tsmiUresUrlap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUresUrlap.Name = "tsmiUresUrlap";
            this.tsmiUresUrlap.Size = new System.Drawing.Size(113, 55);
            this.tsmiUresUrlap.Text = "Üres Űrlap";
            this.tsmiUresUrlap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiUresUrlap.Click += new System.EventHandler(this.TsmiUresUrlap_Click);
            // 
            // cbJelentkezes
            // 
            this.cbJelentkezes.FormattingEnabled = true;
            this.cbJelentkezes.Location = new System.Drawing.Point(125, 281);
            this.cbJelentkezes.Name = "cbJelentkezes";
            this.cbJelentkezes.Size = new System.Drawing.Size(121, 24);
            this.cbJelentkezes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jelentkezés:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(125, 91);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(302, 23);
            this.tbNev.TabIndex = 1;
            // 
            // FrmUtasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 337);
            this.Controls.Add(this.cbJelentkezes);
            this.Controls.Add(this.rtbCim);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbUtasKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msUtas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.msUtas;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUtasa";
            this.Text = "Utas";
            this.Load += new System.EventHandler(this.FrmUtasa_Load);
            this.msUtas.ResumeLayout(false);
            this.msUtas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msUtas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.ToolStripMenuItem tsmiMentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiTorles;
        private System.Windows.Forms.ToolStripMenuItem tsmiUresUrlap;
        internal System.Windows.Forms.TextBox tbUtasKod;
        internal System.Windows.Forms.RichTextBox rtbCim;
        internal System.Windows.Forms.ComboBox cbJelentkezes;
        internal System.Windows.Forms.TextBox tbNev;
    }
}