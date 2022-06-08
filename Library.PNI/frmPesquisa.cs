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
    public partial class frmPesquisa : Form
    {

        private ControladoraTbPesquisa _Controle = new ControladoraTbPesquisa();
        private bool Alterar = false;
        private TbPesquisa aPesquisaAlterada = null;


        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            grdCli.AutoGenerateColumns = false;
            grdCli.DataSource = _Controle.SelecionarTodos();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            if (txtPesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Nome.", Application.ProductName, MessageBoxButtons.OK);
                txtPesquisa.Focus();
                return false;
            }
            else if (txtBioma.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo CPF.", Application.ProductName, MessageBoxButtons.OK);
                txtBioma.Focus();
                return false;
            }
            else if (dtpPesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Endereço.", Application.ProductName, MessageBoxButtons.OK);
                dtpPesquisa.Focus();
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
                    TbPesquisa aPesquisa = new TbPesquisa(); // instancia                    

                    aPesquisa.TituloPesquisa = txtPesquisa.Text;
                    aPesquisa.Bioma = txtBioma.Text;
                    aPesquisa.Dataa = dtpPesquisa.Value;
                    
                    //aPesquisa.Imagem = pboxCapa.Image;
                    _Controle.Incluir(aPesquisa);
                }
                else
                {//Alteração
                    aPesquisaAlterada.TituloPesquisa = txtPesquisa.Text;
                    aPesquisaAlterada.Bioma = txtBioma.Text;
                    aPesquisaAlterada.Dataa = dtpPesquisa.Value;                    
                    _Controle.Alterar(aPesquisaAlterada);
                }
                LimpaControles();
                CarregaGrid();
                txtPesquisa.Focus();
            }
        }

        private void frmPesquisa_Activated(object sender, EventArgs e)
        {
            frmPrincipal _oFrm = (frmPrincipal)this.MdiParent;
            _oFrm.stbPrin.Text = this.Text;
        }

        private void LimpaControles()
        {
            txtPesquisa.Text = "";
            txtBioma.Text = "";
            //dtpPesquisa.Value = "";            
            aPesquisaAlterada = null;
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
                    aPesquisaAlterada = (TbPesquisa)grdCli.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtPesquisa.Text = aPesquisaAlterada.TituloPesquisa;
                    txtBioma.Text = aPesquisaAlterada.Bioma;
                    dtpPesquisa.Value = aPesquisaAlterada.Dataa;
                    
                }
                else if (grdCli.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TbPesquisa aPesquisa = (TbPesquisa)grdCli.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(aPesquisa);
                        LimpaControles();
                        CarregaGrid();
                        txtBioma.Focus();
                    }

                }
            }
        }
    }
}
