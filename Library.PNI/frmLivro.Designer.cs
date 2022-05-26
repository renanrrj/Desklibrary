namespace Library.PNI
{
    partial class frmLivro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivro));
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.pboxLivro = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grdLib = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCarregarImg = new System.Windows.Forms.Button();
            this.ofdLivro = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLib)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(20, 53);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(40, 15);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 15);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Título:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(13, 82);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(47, 15);
            this.lblEditora.TabIndex = 8;
            this.lblEditora.Text = "Editora:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(66, 18);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(200, 23);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(66, 48);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(200, 23);
            this.txtAutor.TabIndex = 1;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(66, 77);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(200, 23);
            this.txtEditora.TabIndex = 2;
            // 
            // pboxLivro
            // 
            this.pboxLivro.Location = new System.Drawing.Point(338, 18);
            this.pboxLivro.Name = "pboxLivro";
            this.pboxLivro.Size = new System.Drawing.Size(156, 201);
            this.pboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLivro.TabIndex = 2;
            this.pboxLivro.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ImageIndex = 0;
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(187, 115);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salve-.png");
            this.imageList1.Images.SetKeyName(1, "adicionar-imagem.png");
            // 
            // grdLib
            // 
            this.grdLib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.autor,
            this.editora,
            this.btnAlterar,
            this.btnExcluir});
            this.grdLib.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLib.Location = new System.Drawing.Point(0, 251);
            this.grdLib.Name = "grdLib";
            this.grdLib.RowTemplate.Height = 25;
            this.grdLib.Size = new System.Drawing.Size(547, 199);
            this.grdLib.TabIndex = 9;
            this.grdLib.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLib_CellClick);
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "Titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            // 
            // autor
            // 
            this.autor.DataPropertyName = "autor";
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            // 
            // editora
            // 
            this.editora.DataPropertyName = "editora";
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            // 
            // btnAlterar
            // 
            this.btnAlterar.HeaderText = "Alterar";
            this.btnAlterar.Name = "btnAlterar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            // 
            // btnCarregarImg
            // 
            this.btnCarregarImg.FlatAppearance.BorderSize = 0;
            this.btnCarregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarImg.ImageIndex = 1;
            this.btnCarregarImg.ImageList = this.imageList1;
            this.btnCarregarImg.Location = new System.Drawing.Point(92, 110);
            this.btnCarregarImg.Name = "btnCarregarImg";
            this.btnCarregarImg.Size = new System.Drawing.Size(40, 41);
            this.btnCarregarImg.TabIndex = 10;
            this.btnCarregarImg.UseVisualStyleBackColor = true;
            this.btnCarregarImg.Click += new System.EventHandler(this.btnCarregarImg_Click);
            // 
            // ofdLivro
            // 
            this.ofdLivro.FileName = "openFileDialog1";
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnCarregarImg);
            this.Controls.Add(this.grdLib);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pboxLivro);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAutor);
            this.KeyPreview = true;
            this.Name = "frmLivro";
            this.Text = "Cadastro de Livros";
            this.Activated += new System.EventHandler(this.frmLibrary_Activated);
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAutor;
        private Label lblTitulo;
        private Label lblEditora;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEditora;
        private PictureBox pboxLivro;
        private Button btnSalvar;
        private DataGridView grdLib;
        private ImageList imageList1;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn editora;
        private DataGridViewButtonColumn btnAlterar;
        private DataGridViewButtonColumn btnExcluir;
        private Button btnCarregarImg;
        private OpenFileDialog ofdLivro;
    }
}