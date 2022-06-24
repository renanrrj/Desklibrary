namespace Library.PNI
{
    partial class frmMapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdCli = new System.Windows.Forms.DataGridView();
            this.local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ilMapa = new System.Windows.Forms.ImageList(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.pboxMapa = new System.Windows.Forms.PictureBox();
            this.btnCarregarImg = new System.Windows.Forms.Button();
            this.ofdMapa = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(66, 81);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(205, 23);
            this.dtpData.TabIndex = 32;
            // 
            // grdCli
            // 
            this.grdCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.local,
            this.Imagem,
            this.Data,
            this.btnAlterar,
            this.btnExcluir});
            this.grdCli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCli.Location = new System.Drawing.Point(0, 251);
            this.grdCli.Name = "grdCli";
            this.grdCli.RowTemplate.Height = 25;
            this.grdCli.Size = new System.Drawing.Size(546, 199);
            this.grdCli.TabIndex = 31;
            this.grdCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCli_CellClick);
            // 
            // local
            // 
            this.local.DataPropertyName = "Locall";
            this.local.HeaderText = "Local";
            this.local.Name = "local";
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "Imagem";
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.Name = "Imagem";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Dataa";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
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
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ImageIndex = 1;
            this.btnSalvar.ImageList = this.ilMapa;
            this.btnSalvar.Location = new System.Drawing.Point(196, 137);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 36);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ilMapa
            // 
            this.ilMapa.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilMapa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMapa.ImageStream")));
            this.ilMapa.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMapa.Images.SetKeyName(0, "adicionar-imagem.png");
            this.ilMapa.Images.SetKeyName(1, "salve-.png");
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(26, 81);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 15);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Data:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(66, 23);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(200, 23);
            this.txtLocal.TabIndex = 25;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(22, 26);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(38, 15);
            this.lblLocal.TabIndex = 26;
            this.lblLocal.Text = "Local:";
            // 
            // pboxMapa
            // 
            this.pboxMapa.Location = new System.Drawing.Point(328, 24);
            this.pboxMapa.Name = "pboxMapa";
            this.pboxMapa.Size = new System.Drawing.Size(162, 182);
            this.pboxMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMapa.TabIndex = 33;
            this.pboxMapa.TabStop = false;
            // 
            // btnCarregarImg
            // 
            this.btnCarregarImg.FlatAppearance.BorderSize = 0;
            this.btnCarregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarImg.ImageIndex = 0;
            this.btnCarregarImg.ImageList = this.ilMapa;
            this.btnCarregarImg.Location = new System.Drawing.Point(117, 132);
            this.btnCarregarImg.Name = "btnCarregarImg";
            this.btnCarregarImg.Size = new System.Drawing.Size(40, 41);
            this.btnCarregarImg.TabIndex = 34;
            this.btnCarregarImg.UseVisualStyleBackColor = true;
            this.btnCarregarImg.Click += new System.EventHandler(this.btnCarregarImg_Click);
            // 
            // ofdMapa
            // 
            this.ofdMapa.FileName = "openFileDialog1";
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btnCarregarImg);
            this.Controls.Add(this.pboxMapa);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdCli);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Name = "frmMapa";
            this.Text = "Cadastro de Mapas";
            this.Activated += new System.EventHandler(this.frmMapa_Activated);
            this.Load += new System.EventHandler(this.frmMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpData;
        private DataGridView grdCli;
        private Button btnSalvar;
        private Label lblData;
        private TextBox txtLocal;
        private Label lblLocal;
        private DataGridViewTextBoxColumn local;
        private DataGridViewTextBoxColumn Imagem;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewButtonColumn btnAlterar;
        private DataGridViewButtonColumn btnExcluir;
        private ImageList ilMapa;
        private PictureBox pboxMapa;
        private Button btnCarregarImg;
        private OpenFileDialog ofdMapa;
    }
}