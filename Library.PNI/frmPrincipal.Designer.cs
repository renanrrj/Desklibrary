namespace Library.PNI
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stbPrincipal = new System.Windows.Forms.ToolStrip();
            this.stbPrin = new System.Windows.Forms.ToolStripLabel();
            this.mnuPrincipal.SuspendLayout();
            this.stbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.mapasToolStripMenuItem,
            this.empréstimoToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pesquisaToolStripMenuItem.Image")));
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisas";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // mapasToolStripMenuItem
            // 
            this.mapasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mapasToolStripMenuItem.Image")));
            this.mapasToolStripMenuItem.Name = "mapasToolStripMenuItem";
            this.mapasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mapasToolStripMenuItem.Text = "Mapas";
            this.mapasToolStripMenuItem.Click += new System.EventHandler(this.mapasToolStripMenuItem_Click);
            // 
            // empréstimoToolStripMenuItem
            // 
            this.empréstimoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empréstimoToolStripMenuItem.Image")));
            this.empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            this.empréstimoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.empréstimoToolStripMenuItem.Text = "Empréstimo";
            this.empréstimoToolStripMenuItem.Click += new System.EventHandler(this.empréstimoToolStripMenuItem_Click);
            // 
            // stbPrincipal
            // 
            this.stbPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stbPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbPrin});
            this.stbPrincipal.Location = new System.Drawing.Point(0, 325);
            this.stbPrincipal.Name = "stbPrincipal";
            this.stbPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stbPrincipal.Size = new System.Drawing.Size(800, 25);
            this.stbPrincipal.TabIndex = 3;
            this.stbPrincipal.Text = "toolStrip1";
            // 
            // stbPrin
            // 
            this.stbPrin.Name = "stbPrin";
            this.stbPrin.Size = new System.Drawing.Size(53, 22);
            this.stbPrin.Text = "Principal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.stbPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.stbPrincipal.ResumeLayout(false);
            this.stbPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuPrincipal;
        public ToolStripLabel stbPrin;
        public ToolStrip stbPrincipal;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem empréstimoToolStripMenuItem;
        private ToolStripMenuItem pesquisaToolStripMenuItem;
        private ToolStripMenuItem mapasToolStripMenuItem;
    }
}