namespace Library.PNI
{
    partial class frmCliente
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.grdCli = new System.Windows.Forms.DataGridView();
            this.pboxCapa = new System.Windows.Forms.PictureBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(129, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(89, 86);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 23);
            this.txtEndereco.TabIndex = 11;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(89, 57);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(200, 23);
            this.txtCpf.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            this.txtNome.TabIndex = 9;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(29, 91);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 15);
            this.lblEndereco.TabIndex = 17;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(36, 62);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 16;
            this.lblCpf.Text = "CPF:";
            // 
            // grdCli
            // 
            this.grdCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.Cpf,
            this.Endereço,
            this.Cidade,
            this.Bairro,
            this.btnAlterar,
            this.btnExcluir});
            this.grdCli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCli.Location = new System.Drawing.Point(0, 251);
            this.grdCli.Name = "grdCli";
            this.grdCli.RowTemplate.Height = 25;
            this.grdCli.Size = new System.Drawing.Size(751, 199);
            this.grdCli.TabIndex = 18;
            this.grdCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCli_CellClick);
            // 
            // pboxCapa
            // 
            this.pboxCapa.Image = global::Library.PNI.Properties.Resources.jpg__Logo_;
            this.pboxCapa.Location = new System.Drawing.Point(453, 27);
            this.pboxCapa.Name = "pboxCapa";
            this.pboxCapa.Size = new System.Drawing.Size(156, 201);
            this.pboxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCapa.TabIndex = 19;
            this.pboxCapa.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(89, 117);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(89, 147);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(36, 126);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 15);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(29, 155);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 15);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro:";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "CPF";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            // 
            // Endereço
            // 
            this.Endereço.DataPropertyName = "endereco";
            this.Endereço.HeaderText = "Endereco";
            this.Endereço.Name = "Endereço";
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
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
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.pboxCapa);
            this.Controls.Add(this.grdCli);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Name = "frmCliente";
            this.Text = "Cadastro de Clientes";
            this.Activated += new System.EventHandler(this.frmCliente_Activated);
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSalvar;
        private TextBox txtEndereco;
        private TextBox txtCpf;
        private TextBox txtNome;
        private Label lblEndereco;
        private Label lblNome;
        private Label lblCpf;
        private DataGridView grdCli;
        private PictureBox pboxCapa;
        private DataGridViewTextBoxColumn Endereco;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label lblCidade;
        private Label lblBairro;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewButtonColumn btnAlterar;
        private DataGridViewButtonColumn btnExcluir;
    }
}