using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Model;
using Library.PNI.Controladora;

namespace Library.PNI
{
    public partial class frmCliente : Form
    {
        Bitmap bmp;

        private ControladoraTbCliente _Controle = new ControladoraTbCliente();
        private bool Alterar = false;
        private TbCliente oClienteAlterado = null;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            grdCli.AutoGenerateColumns = false;
            grdCli.DataSource = _Controle.SelecionarTodos();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private bool ValidaControles()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Nome.", Application.ProductName, MessageBoxButtons.OK);
                txtNome.Focus();
                return false;
            }
            else if (txtCpf.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo CPF.", Application.ProductName, MessageBoxButtons.OK);
                txtCpf.Focus();
                return false;
            }
            else if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Endereço.", Application.ProductName, MessageBoxButtons.OK);
                txtEndereco.Focus();
                return false;
            }
            else if (txtBairro.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Bairro.", Application.ProductName, MessageBoxButtons.OK);
                txtBairro.Focus();
                return false;
            }
            else if (txtCidade.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Cidade.", Application.ProductName, MessageBoxButtons.OK);
                txtCidade.Focus();
                return false;
            }
            return true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Alterar == false)
                {
                    TbCliente oCliente = new TbCliente(); // instancia                    

                    oCliente.Nome = txtNome.Text;
                    oCliente.Cpf = txtCpf.Text;
                    oCliente.Endereco = txtEndereco.Text;
                    oCliente.Cidade = txtCidade.Text;
                    oCliente.Bairro = txtBairro.Text;
                    //oCliente.Imagem = pboxCapa.Image;
                    _Controle.Incluir(oCliente);
                }
                else
                {//Alteração
                    oClienteAlterado.Nome = txtNome.Text;
                    oClienteAlterado.Cpf = txtCpf.Text;
                    oClienteAlterado.Endereco = txtEndereco.Text;
                    oClienteAlterado.Cidade = txtCidade.Text;
                    oClienteAlterado.Bairro = txtBairro.Text;
                    _Controle.Alterar(oClienteAlterado);
                }
                LimpaControles();
                CarregaGrid();
                txtNome.Focus();
            }
        }
        private void frmCliente_Activated(object sender, EventArgs e)
        {
            frmPrincipal _oFrm = (frmPrincipal)this.MdiParent;
            _oFrm.stbPrin.Text = this.Text;
        }
        private void LimpaControles()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            oClienteAlterado = null;
            Alterar = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }
        
        private void grdCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCli.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (grdCli.Columns[e.ColumnIndex].Name == "btnAlterar")
                {
                    oClienteAlterado = (TbCliente)grdCli.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtNome.Text = oClienteAlterado.Nome;
                    txtCpf.Text = oClienteAlterado.Cpf;
                    txtEndereco.Text = oClienteAlterado.Endereco;
                    txtCidade.Text = oClienteAlterado.Cidade;
                    txtBairro.Text = oClienteAlterado.Bairro;
                }
                else if (grdCli.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TbCliente oCliente = (TbCliente)grdCli.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(oCliente);
                        LimpaControles();
                        CarregaGrid();
                        txtCpf.Focus();
                    }

                }
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            ofdCliente.Title = "Selecionar foto";
            ofdCliente.Filter = "PNG| *.png|JPG *.jpg| BMP *.bmp";

            if (ofdCliente.ShowDialog() == DialogResult.OK)
            {                
                string imgnome = ofdCliente.FileName;
                bmp = new Bitmap(imgnome);
                pboxCapa.Image = bmp;
            }
        }
    }
}
