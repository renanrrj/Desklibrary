namespace Library.PNI
{
    partial class frmEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmprestimo));
            this.grdEmp1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pboxEmprestimo = new System.Windows.Forms.PictureBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.lblClienteEmp = new System.Windows.Forms.Label();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.cbEmprestimo = new System.Windows.Forms.ComboBox();
            this.btnCarregarImg = new System.Windows.Forms.Button();
            this.ilEmprestimo = new System.Windows.Forms.ImageList(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ofdEmprestimo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmp1
            // 
            this.grdEmp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmp1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.btnAlterar,
            this.btnExcluir});
            this.grdEmp1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdEmp1.Location = new System.Drawing.Point(0, 251);
            this.grdEmp1.Name = "grdEmp1";
            this.grdEmp1.RowTemplate.Height = 25;
            this.grdEmp1.Size = new System.Drawing.Size(642, 199);
            this.grdEmp1.TabIndex = 21;
            this.grdEmp1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmp1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Objeto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Livro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataemprestimo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Emprestimo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datadevolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Devolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // pboxEmprestimo
            // 
            this.pboxEmprestimo.Image = global::Library.PNI.Properties.Resources.jpg__Logo_;
            this.pboxEmprestimo.Location = new System.Drawing.Point(396, 6);
            this.pboxEmprestimo.Name = "pboxEmprestimo";
            this.pboxEmprestimo.Size = new System.Drawing.Size(156, 201);
            this.pboxEmprestimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEmprestimo.TabIndex = 20;
            this.pboxEmprestimo.TabStop = false;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(23, 139);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(66, 15);
            this.lblDevolucao.TabIndex = 16;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // lblEmprestimo
            // 
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.Location = new System.Drawing.Point(15, 101);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Size = new System.Drawing.Size(74, 15);
            this.lblEmprestimo.TabIndex = 17;
            this.lblEmprestimo.Text = "Emprestimo:";
            // 
            // lblClienteEmp
            // 
            this.lblClienteEmp.AutoSize = true;
            this.lblClienteEmp.Location = new System.Drawing.Point(42, 61);
            this.lblClienteEmp.Name = "lblClienteEmp";
            this.lblClienteEmp.Size = new System.Drawing.Size(47, 15);
            this.lblClienteEmp.TabIndex = 18;
            this.lblClienteEmp.Text = "Cliente:";
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Location = new System.Drawing.Point(42, 21);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(46, 15);
            this.lblObjeto.TabIndex = 19;
            this.lblObjeto.Text = "Objeto:";
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(95, 21);
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(205, 23);
            this.txtObjeto.TabIndex = 15;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(95, 139);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(205, 23);
            this.dtpDevolucao.TabIndex = 13;
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.Location = new System.Drawing.Point(95, 101);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(205, 23);
            this.dtpEmprestimo.TabIndex = 12;
            // 
            // cbEmprestimo
            // 
            this.cbEmprestimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmprestimo.FormattingEnabled = true;
            this.cbEmprestimo.Location = new System.Drawing.Point(95, 58);
            this.cbEmprestimo.Name = "cbEmprestimo";
            this.cbEmprestimo.Size = new System.Drawing.Size(205, 23);
            this.cbEmprestimo.TabIndex = 24;
            this.cbEmprestimo.SelectedIndexChanged += new System.EventHandler(this.cbEmprestimo_SelectedIndexChanged);
            // 
            // btnCarregarImg
            // 
            this.btnCarregarImg.FlatAppearance.BorderSize = 0;
            this.btnCarregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarImg.ImageIndex = 0;
            this.btnCarregarImg.ImageList = this.ilEmprestimo;
            this.btnCarregarImg.Location = new System.Drawing.Point(126, 168);
            this.btnCarregarImg.Name = "btnCarregarImg";
            this.btnCarregarImg.Size = new System.Drawing.Size(40, 41);
            this.btnCarregarImg.TabIndex = 36;
            this.btnCarregarImg.UseVisualStyleBackColor = true;
            this.btnCarregarImg.Click += new System.EventHandler(this.btnCarregarImg_Click);
            // 
            // ilEmprestimo
            // 
            this.ilEmprestimo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilEmprestimo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilEmprestimo.ImageStream")));
            this.ilEmprestimo.TransparentColor = System.Drawing.Color.Transparent;
            this.ilEmprestimo.Images.SetKeyName(0, "adicionar-imagem.png");
            this.ilEmprestimo.Images.SetKeyName(1, "salve-.png");
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ImageIndex = 1;
            this.btnSalvar.ImageList = this.ilEmprestimo;
            this.btnSalvar.Location = new System.Drawing.Point(205, 173);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 36);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // ofdEmprestimo
            // 
            this.ofdEmprestimo.FileName = "openFileDialog1";
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.btnCarregarImg);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbEmprestimo);
            this.Controls.Add(this.grdEmp1);
            this.Controls.Add(this.pboxEmprestimo);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.lblEmprestimo);
            this.Controls.Add(this.lblClienteEmp);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.txtObjeto);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpEmprestimo);
            this.Name = "frmEmprestimo";
            this.Text = "Emprestimo";
            this.Activated += new System.EventHandler(this.frmEmprestimo1_Activated);
            this.Load += new System.EventHandler(this.frmEmprestimo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView grdEmp1;
        private PictureBox pboxEmprestimo;
        private Label lblDevolucao;
        private Label lblEmprestimo;
        private Label lblClienteEmp;
        private Label lblObjeto;
        private TextBox txtObjeto;
        private DateTimePicker dtpDevolucao;
        private DateTimePicker dtpEmprestimo;
        private ComboBox cbEmprestimo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn btnAlterar;
        private DataGridViewButtonColumn btnExcluir;
        private Button btnCarregarImg;
        private Button btnSalvar;
        private ImageList ilEmprestimo;
        private OpenFileDialog ofdEmprestimo;
    }
}