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
    public partial class frmLivro : Form
    {
        private ControladoraLivro _Controle = new ControladoraLivro();
        private bool Alterar = false;
        private Livro oLivroAlterado = null;

        public frmLivro()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            grdLib.AutoGenerateColumns = false;
            grdLib.DataSource = _Controle.SelecionarTodos();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            if (txtTitulo.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Título.", Application.ProductName, MessageBoxButtons.OK);
                txtTitulo.Focus();
                return false;
            }
           else if (txtAutor.Text.Trim() =="")
           {
                MessageBox.Show("Preencha o Conteúdo do campo Autor.", Application.ProductName, MessageBoxButtons.OK);
                txtAutor.Focus();
                return false;
           }
            else if (txtEditora.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Conteúdo do campo Editora.", Application.ProductName, MessageBoxButtons.OK);
                txtEditora.Focus();
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
                    Livro oLivro = new Livro(); // instancia                    

                    oLivro.Nome = txtTitulo.Text;
                    oLivro.Autor = txtAutor.Text;
                    oLivro.Editora = txtEditora.Text;
                    _Controle.Incluir(oLivro);
                }
                else
                {//Alteração
                    oLivroAlterado.Nome = txtTitulo.Text;
                    oLivroAlterado.Autor = txtAutor.Text;
                    oLivroAlterado.Editora = txtEditora.Text;
                    _Controle.Alterar(oLivroAlterado);
                }
                LimpaControles();
                CarregaGrid();
                txtTitulo.Focus();
            }
        }
        private void frmLibrary_Activated(object sender, EventArgs e) // Evento para ativar a barra de status
        {
            frmPrincipal oFrm = (frmPrincipal)this.MdiParent;
            oFrm.stbPrin.Text =  this.Text; 
        }

        private void LimpaControles()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            oLivroAlterado = null;
            Alterar = false;
        }
        //private void btnLimpar_Click(object sender, EventArgs e)
        //{
        //    LimpaControles();
        //}

        private void grdLib_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdLib.Rows[e.RowIndex].DataBoundItem!=null)
            {
                if(grdLib.Columns[e.ColumnIndex].Name== "btnAlterar")
                {
                    oLivroAlterado = (Livro)grdLib.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtTitulo.Text = oLivroAlterado.Nome;
                    txtAutor.Text = oLivroAlterado.Autor;
                    txtEditora.Text = oLivroAlterado.Editora;
                }
                else if (grdLib.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Livro oLivro = (Livro)grdLib.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(oLivro);
                        LimpaControles();
                        CarregaGrid();
                        txtAutor.Focus();
                    }                        

                }
            }
        }
    }
}
