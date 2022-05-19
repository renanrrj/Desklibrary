using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraLivro : IDisposable
    {
        RepositorioLivro _Repositorio;

        public ControladoraLivro()
        {
            _Repositorio = new RepositorioLivro();
        }
        public void Incluir(Livro oLivro)
        {
            _Repositorio.Incluir(oLivro);
        }

        public void Alterar(Livro oLivro)
        {
            _Repositorio.Alterar(oLivro);
        }

        public void Excluir (Livro oLivro)
        {
            _Repositorio.Excluir(oLivro);
        }

        public List<Livro> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose(); 
        }
    }
}
