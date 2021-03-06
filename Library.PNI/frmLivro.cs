using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        Bitmap bmp;
        private ControladoraTbLivro _Controle = new ControladoraTbLivro();
        private bool Alterar = false;
        private TbLivro oLivroAlterado = null;

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
                    TbLivro oLivro = new TbLivro(); // instancia


                    //Bitmap imagem = (Bitmap)pboxLivro.Image;
                    //var stream = new MemoryStream();

                    //string base64String = string.Empty;


                    //MemoryStream memoryStream = new MemoryStream();
                    //bmp.Save(memoryStream, ImageFormat.Png);


                    //memoryStream.Position = 0;
                    //byte[] byteBuffer = memoryStream.ToArray();


                    //memoryStream.Close();


                    //base64String = Convert.ToBase64String(byteBuffer);
                    //byteBuffer = null;

                    //String ImagemConvertida = base64String;




                    oLivro.Titulo = txtTitulo.Text;
                    oLivro.Autor = txtAutor.Text;
                    oLivro.Editora = txtEditora.Text;
                    _Controle.Incluir(oLivro);
                }
                else
                {//Alteração
                    oLivroAlterado.Titulo = txtTitulo.Text;
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
                    oLivroAlterado = (TbLivro)grdLib.Rows[e.RowIndex].DataBoundItem;
                    Alterar = true;
                    txtTitulo.Text = oLivroAlterado.Titulo;
                    txtAutor.Text = oLivroAlterado.Autor;
                    txtEditora.Text = oLivroAlterado.Editora;
                }
                else if (grdLib.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    if (MessageBox.Show("Confirme a excluisão, para continuar", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TbLivro oLivro = (TbLivro)grdLib.Rows[e.RowIndex].DataBoundItem;
                        _Controle.Excluir(oLivro);
                        LimpaControles();
                        CarregaGrid();
                        txtAutor.Focus();
                    }                        

                }
            }
        }

        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            
                ofdLivro.Title = "Selecionar foto";
                ofdLivro.Filter = "PNG |*.png| JPG|*.jpg";

                if (ofdLivro.ShowDialog() == DialogResult.OK)
                {
                    string imgnome = ofdLivro.FileName;
                    bmp = new Bitmap(imgnome);
                    pboxLivro.Image = bmp;
                }
         
        }

        


    }
}
