namespace Library.PNI
{
    partial class frmEmprestimo1
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grdEmp1 = new System.Windows.Forms.DataGridView();
            this.pboxCapa = new System.Windows.Forms.PictureBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.lblClienteEmp = new System.Windows.Forms.Label();
            this.lblLivroEmp = new System.Windows.Forms.Label();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(160, 184);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.grdEmp1.Size = new System.Drawing.Size(800, 199);
            this.grdEmp1.TabIndex = 21;
            this.grdEmp1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmp1_CellClick);
            // 
            // pboxCapa
            // 
            this.pboxCapa.Image = global::Library.PNI.Properties.Resources.jpg__Logo_;
            this.pboxCapa.Location = new System.Drawing.Point(396, 6);
            this.pboxCapa.Name = "pboxCapa";
            this.pboxCapa.Size = new System.Drawing.Size(156, 201);
            this.pboxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCapa.TabIndex = 20;
            this.pboxCapa.TabStop = false;
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
            // lblLivroEmp
            // 
            this.lblLivroEmp.AutoSize = true;
            this.lblLivroEmp.Location = new System.Drawing.Point(53, 21);
            this.lblLivroEmp.Name = "lblLivroEmp";
            this.lblLivroEmp.Size = new System.Drawing.Size(36, 15);
            this.lblLivroEmp.TabIndex = 19;
            this.lblLivroEmp.Text = "Livro:";
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(95, 21);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(205, 23);
            this.txtIdLivro.TabIndex = 15;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(95, 61);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(205, 23);
            this.txtIdCliente.TabIndex = 14;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Livro";
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
            // frmEmprestimo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grdEmp1);
            this.Controls.Add(this.pboxCapa);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.lblEmprestimo);
            this.Controls.Add(this.lblClienteEmp);
            this.Controls.Add(this.lblLivroEmp);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpEmprestimo);
            this.Name = "frmEmprestimo1";
            this.Text = "Emprestimo";
            this.Activated += new System.EventHandler(this.frmEmprestimo1_Activated);
            this.Load += new System.EventHandler(this.frmEmprestimo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private DataGridView grdEmp1;
        private PictureBox pboxCapa;
        private Label lblDevolucao;
        private Label lblEmprestimo;
        private Label lblClienteEmp;
        private Label lblLivroEmp;
        private TextBox txtIdLivro;
        private TextBox txtIdCliente;
        private DateTimePicker dtpDevolucao;
        private DateTimePicker dtpEmprestimo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn btnAlterar;
        private DataGridViewButtonColumn btnExcluir;
    }
}