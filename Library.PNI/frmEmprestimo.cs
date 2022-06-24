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
using Microsoft.Data.SqlClient;

namespace Library.PNI
{
   
    public partial class frmEmprestimo : Form
    {

        Bitmap bmp;

        private ControladoraEmprestimo _Controle = new ControladoraEmprestimo();
        private bool Alterar = false;
        private TbEmprestimo oEmprestimo1Alterado = null;

        public frmEmprestimo()
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
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cbEmprestimo.ValueMember = "Id";
            cbEmprestimo.DisplayMember = "Nome";
            cbEmprestimo.DataSource = _Controle.SelecionarTodosClientes();
           // cbEmprestimo.DataSource = _Controle.SelecionarTodos();
        }

        //----------------------------------------------------
        

        private bool ValidaControles()
        {
            if (txtObjeto.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Título.", Application.ProductName, MessageBoxButtons.OK);
                txtObjeto.Focus();
                return false;
            }
            else if (cbEmprestimo.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Autor.", Application.ProductName, MessageBoxButtons.OK);
                cbEmprestimo.Focus();
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
                    TbEmprestimo oEmprestimo1 = new TbEmprestimo(); // instancia                   

                    oEmprestimo1.Objeto = txtObjeto.Text;
                    oEmprestimo1.Cliente = cbEmprestimo.Text;
                    oEmprestimo1.DataEmprestimo = dtpEmprestimo.Value;
                    oEmprestimo1.DataDevolucao = dtpDevolucao.Value;
                    _Controle.Incluir(oEmprestimo1);
                }
                else
                {//Alteração
                    oEmprestimo1Alterado.Objeto = txtObjeto.Text;
                    oEmprestimo1Alterado.Cliente = cbEmprestimo.Text;
                    oEmprestimo1Alterado.DataEmprestimo = dtpEmprestimo.Value;
                    oEmprestimo1Alterado.DataDevolucao = dtpDevolucao.Value;
                    _Controle.Alterar(oEmprestimo1Alterado);
                }
                LimpaControles();
                CarregaGrid();
                txtObjeto.Focus();
            }

        }
        private void frmEmprestimo1_Activated(object sender, EventArgs e)
        {
            frmPrincipal oFrm = (frmPrincipal)this.MdiParent;
            oFrm.stbPrin.Text = this.Text;
        }
        private void LimpaControles()
        {
            txtObjeto.Text = "";
            cbEmprestimo.Text = "";            
            oEmprestimo1Alterado = null;
            Alterar = false;
        }

        private void grdEmp1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdEmp1.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (grdEmp1.Columns[e.ColumnIndex].Name == "btnAlterar")
                {
                    oEmprestimo1Alterado = (TbEmprestimo)grdEmp1.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtObjeto.Text = oEmprestimo1Alterado.Objeto;
                    cbEmprestimo.Text = oEmprestimo1Alterado.Cliente;
                    
                }
                else if (grdEmp1.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TbEmprestimo oEmprestimo = (TbEmprestimo)grdEmp1.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(oEmprestimo);
                        LimpaControles();
                        CarregaGrid();
                        txtObjeto.Focus();
                    }

                }
            }
        }

        private void cbEmprestimo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            ofdEmprestimo.Title = "Selecionar foto";
            ofdEmprestimo.Filter = "PNG |*.png| JPG|*.jpg";

            if (ofdEmprestimo.ShowDialog() == DialogResult.OK)
            {
                string imgnome = ofdEmprestimo.FileName;
                bmp = new Bitmap(imgnome);
                pboxEmprestimo.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Alterar == false)
                {
                    TbEmprestimo oEmprestimo1 = new TbEmprestimo(); // instancia                   

                    oEmprestimo1.Objeto = txtObjeto.Text;
                    oEmprestimo1.Cliente = cbEmprestimo.Text;
                    oEmprestimo1.DataEmprestimo = dtpEmprestimo.Value;
                    oEmprestimo1.DataDevolucao = dtpDevolucao.Value;
                    _Controle.Incluir(oEmprestimo1);
                }
                else
                {//Alteração
                    oEmprestimo1Alterado.Objeto = txtObjeto.Text;
                    oEmprestimo1Alterado.Cliente = cbEmprestimo.Text;
                    oEmprestimo1Alterado.DataEmprestimo = dtpEmprestimo.Value;
                    oEmprestimo1Alterado.DataDevolucao = dtpDevolucao.Value;
                    _Controle.Alterar(oEmprestimo1Alterado);
                }
                LimpaControles();
                CarregaGrid();
                txtObjeto.Focus();
            }
        }
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}


    }
}
