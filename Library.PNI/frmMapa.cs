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
    public partial class frmMapa : Form
    {

        private ControladoraTbMapa _Controle = new ControladoraTbMapa();
        private bool Alterar = false;
        private TbMapa aDataAlterada = null;

        public frmMapa()
        {
            InitializeComponent();
        }        

        private void CarregaGrid()
        {
            grdCli.AutoGenerateColumns = false;
            grdCli.DataSource = _Controle.SelecionarTodos();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            if (txtLocal.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Nome.", Application.ProductName, MessageBoxButtons.OK);
                txtLocal.Focus();
                return false;
            }
            else if (dtpData.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo CPF.", Application.ProductName, MessageBoxButtons.OK);
                dtpData.Focus();
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
                    TbMapa oMapa = new TbMapa(); // instancia                    

                    oMapa.Locall = txtLocal.Text;                    
                    oMapa.Dataa = dtpData.Value;

                    //oMapa.Imagem = pboxCapa.Image;
                    _Controle.Incluir(oMapa);
                }
                else
                {//Alteração
                    aDataAlterada.Locall = txtLocal.Text;
                    aDataAlterada.Dataa = dtpData.Value;
                    _Controle.Alterar(aDataAlterada);
                }
                LimpaControles();
                CarregaGrid();
                txtLocal.Focus();
            }
        }

        private void frmMapa_Activated(object sender, EventArgs e)
        {
            frmPrincipal _oFrm = (frmPrincipal)this.MdiParent;
            _oFrm.stbPrin.Text = this.Text;
        }

        private void LimpaControles()
        {
            txtLocal.Text = "";
            //dtpData.Value = "";            
            aDataAlterada = null;
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
                    aDataAlterada = (TbMapa)grdCli.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtLocal.Text = aDataAlterada.Locall;
                    dtpData.Value = aDataAlterada.Dataa;

                }
                else if (grdCli.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TbMapa oMapa = (TbMapa)grdCli.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(oMapa);
                        LimpaControles();
                        CarregaGrid();
                        txtLocal.Focus();
                    }

                }
            }
        }
    }
}
