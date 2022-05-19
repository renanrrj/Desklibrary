namespace Library.PNI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuLivroCad_Click(object sender, EventArgs e) // menu de chamada para "Cadastro/Livros" - frmLibrary 
        {
            frmLivro oFrm = new frmLivro(); // posso usar a msm variavel "oFrm" em todoos os metodos pois é interna
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void mnuSair_Click(object sender, EventArgs e) // menu de chamada para "Cadastro/Sair" - frmPricnipal
        {
            this.Close(); // encerra a janela.
            Application.Exit(); // fecha todos os processos.
        }

        private void mnuClienteCad_Click(object sender, EventArgs e)
        {
            frmCliente oFrm = new frmCliente(); // posso usar a msm variavel "oFrm" em todoos os metodos pois é interna
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void mnuEmprestimo_Click(object sender, EventArgs e)
        {
            frmEmprestimo1 oFrm = new frmEmprestimo1(); // posso usar a msm variavel "oFrm" em todoos os metodos pois é interna
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        //private void mnuEmprestimo_Click(object sender, EventArgs e)
        //{
        //    frmEmprestimo oFrm = new frmEmprestimo(); // posso usar a msm variavel "oFrm" em todoos os metodos pois é interna
        //    oFrm.MdiParent = this;
        //    oFrm.Show();
        //}
    }
}