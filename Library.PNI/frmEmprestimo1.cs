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
    public partial class frmEmprestimo1 : Form
    {
        private ControladoraEmprestimo1 _Controle = new ControladoraEmprestimo1();
        private bool Alterar = false;
        private Emprestimo1 oEmprestimo1Alterado = null;

        public frmEmprestimo1()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            grdEmp1.AutoGenerateColumns = false;
            grdEmp1.DataSource = _Controle.SelecionarTodos();
        }

        private void frmEmprestimo1_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            if (txtIdLivro.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Título.", Application.ProductName, MessageBoxButtons.OK);
                txtIdLivro.Focus();
                return false;
            }
            else if (txtIdCliente.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Autor.", Application.ProductName, MessageBoxButtons.OK);
                txtIdCliente.Focus();
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
                    Emprestimo1 oEmprestimo1 = new Emprestimo1(); // instancia                   

                    oEmprestimo1.Livro = txtIdLivro.Text;
                    oEmprestimo1.Cliente = txtIdCliente.Text;
                    oEmprestimo1.Dataemprestimo = dtpEmprestimo.Value;
                    oEmprestimo1.Datadevolucao = dtpDevolucao.Value;
                    _Controle.Incluir(oEmprestimo1);
                }
                else
                {//Alteração
                    oEmprestimo1Alterado.Livro = txtIdLivro.Text;
                    oEmprestimo1Alterado.Cliente = txtIdCliente.Text;
                    oEmprestimo1Alterado.Dataemprestimo = dtpEmprestimo.Value;
                    oEmprestimo1Alterado.Datadevolucao = dtpDevolucao.Value;
                    _Controle.Alterar(oEmprestimo1Alterado);
                }
                LimpaControles();
                CarregaGrid();
                txtIdLivro.Focus();
            }

        }
        private void frmEmprestimo1_Activated(object sender, EventArgs e)
        {
            frmPrincipal oFrm = (frmPrincipal)this.MdiParent;
            oFrm.stbPrin.Text = this.Text;
        }
        private void LimpaControles()
        {
            txtIdLivro.Text = "";
            txtIdCliente.Text = "";            
            oEmprestimo1Alterado = null;
            Alterar = false;
        }

        private void grdEmp1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdEmp1.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (grdEmp1.Columns[e.ColumnIndex].Name == "btnAlterar")
                {
                    oEmprestimo1Alterado = (Emprestimo1)grdEmp1.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtIdLivro.Text = oEmprestimo1Alterado.Livro;
                    txtIdCliente.Text = oEmprestimo1Alterado.Cliente;
                    
                }
                else if (grdEmp1.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Emprestimo1 oEmprestimo1 = (Emprestimo1)grdEmp1.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(oEmprestimo1);
                        LimpaControles();
                        CarregaGrid();
                        txtIdLivro.Focus();
                    }

                }
            }
        }
    }
}
