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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastroPrin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClienteCad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLivroCad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmprestimo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.stbPrincipal = new System.Windows.Forms.ToolStrip();
            this.stbPrin = new System.Windows.Forms.ToolStripLabel();
            this.mnuPrincipal.SuspendLayout();
            this.stbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroPrin});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastroPrin
            // 
            this.mnuCadastroPrin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClienteCad,
            this.mnuLivroCad,
            this.mnuEmprestimo,
            this.mnuSair});
            this.mnuCadastroPrin.Name = "mnuCadastroPrin";
            this.mnuCadastroPrin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCadastroPrin.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastroPrin.Text = "&Cadastro";
            // 
            // mnuClienteCad
            // 
            this.mnuClienteCad.Name = "mnuClienteCad";
            this.mnuClienteCad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuClienteCad.Size = new System.Drawing.Size(180, 22);
            this.mnuClienteCad.Text = "&Cliente";
            this.mnuClienteCad.Click += new System.EventHandler(this.mnuClienteCad_Click);
            // 
            // mnuLivroCad
            // 
            this.mnuLivroCad.Name = "mnuLivroCad";
            this.mnuLivroCad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuLivroCad.Size = new System.Drawing.Size(180, 22);
            this.mnuLivroCad.Text = "&Livros";
            this.mnuLivroCad.Click += new System.EventHandler(this.mnuLivroCad_Click);
            // 
            // mnuEmprestimo
            // 
            this.mnuEmprestimo.Name = "mnuEmprestimo";
            this.mnuEmprestimo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEmprestimo.Size = new System.Drawing.Size(180, 22);
            this.mnuEmprestimo.Text = "&Emprestimo";
            this.mnuEmprestimo.Click += new System.EventHandler(this.mnuEmprestimo_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnuSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSair.Text = "Sai&r";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
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
        private ToolStripMenuItem mnuCadastroPrin;
        private ToolStripMenuItem mnuLivroCad;
        public ToolStripLabel stbPrin;
        public ToolStrip stbPrincipal;
        private ToolStripMenuItem mnuSair;
        private ToolStripMenuItem mnuClienteCad;
        private ToolStripMenuItem mnuEmprestimo;
    }
}