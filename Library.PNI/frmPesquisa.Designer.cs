namespace Library.PNI
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtBioma = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblBioma = new System.Windows.Forms.Label();
            this.grdCli = new System.Windows.Forms.DataGridView();
            this.TitPesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ilPesquisa = new System.Windows.Forms.ImageList(this.components);
            this.dtpPesquisa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(121, 21);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(200, 23);
            this.txtPesquisa.TabIndex = 16;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(10, 21);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(105, 15);
            this.lblPesquisa.TabIndex = 17;
            this.lblPesquisa.Text = "Título da pesquisa:";
            // 
            // txtBioma
            // 
            this.txtBioma.Location = new System.Drawing.Point(121, 50);
            this.txtBioma.Name = "txtBioma";
            this.txtBioma.Size = new System.Drawing.Size(200, 23);
            this.txtBioma.TabIndex = 18;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(81, 79);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 15);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "Data:";
            // 
            // lblBioma
            // 
            this.lblBioma.AutoSize = true;
            this.lblBioma.Location = new System.Drawing.Point(71, 50);
            this.lblBioma.Name = "lblBioma";
            this.lblBioma.Size = new System.Drawing.Size(44, 15);
            this.lblBioma.TabIndex = 20;
            this.lblBioma.Text = "Bioma:";
            // 
            // grdCli
            // 
            this.grdCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitPesquisa,
            this.bioma,
            this.Data,
            this.btnAlterar,
            this.btnExcluir});
            this.grdCli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCli.Location = new System.Drawing.Point(0, 251);
            this.grdCli.Name = "grdCli";
            this.grdCli.RowTemplate.Height = 25;
            this.grdCli.Size = new System.Drawing.Size(800, 199);
            this.grdCli.TabIndex = 23;
            this.grdCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCli_CellClick);
            // 
            // TitPesquisa
            // 
            this.TitPesquisa.DataPropertyName = "TituloPesquisa";
            this.TitPesquisa.HeaderText = "Pesquisa";
            this.TitPesquisa.Name = "TitPesquisa";
            // 
            // bioma
            // 
            this.bioma.DataPropertyName = "Bioma";
            this.bioma.HeaderText = "Bioma";
            this.bioma.Name = "bioma";
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
            this.btnSalvar.ImageIndex = 0;
            this.btnSalvar.ImageList = this.ilPesquisa;
            this.btnSalvar.Location = new System.Drawing.Point(176, 120);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 36);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ilPesquisa
            // 
            this.ilPesquisa.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilPesquisa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPesquisa.ImageStream")));
            this.ilPesquisa.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPesquisa.Images.SetKeyName(0, "salve-.png");
            // 
            // dtpPesquisa
            // 
            this.dtpPesquisa.Location = new System.Drawing.Point(121, 79);
            this.dtpPesquisa.Name = "dtpPesquisa";
            this.dtpPesquisa.Size = new System.Drawing.Size(205, 23);
            this.dtpPesquisa.TabIndex = 24;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpPesquisa);
            this.Controls.Add(this.grdCli);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBioma);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblBioma);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Name = "frmPesquisa";
            this.Text = "Cadastro de Pesquisas";
            this.Activated += new System.EventHandler(this.frmPesquisa_Activated);
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPesquisa;
        private Label lblPesquisa;
        private TextBox txtBioma;
        private Label lblData;
        private Label lblBioma;
        private DataGridView grdCli;
        private Button btnSalvar;
        private DataGridViewTextBoxColumn TitPesquisa;
        private DataGridViewTextBoxColumn bioma;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewButtonColumn btnAlterar;
        private DataGridViewButtonColumn btnExcluir;
        private ImageList ilPesquisa;
        private DateTimePicker dtpPesquisa;
    }
}