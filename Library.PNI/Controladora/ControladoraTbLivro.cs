using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraTbLivro : IDisposable
    {
        RepositorioTbLivro _Repositorio;

        public ControladoraTbLivro()
        {
            _Repositorio = new RepositorioTbLivro();
        }
        public void Incluir(TbLivro oLivro)
        {
            _Repositorio.Incluir(oLivro);
        }

        public void Alterar(TbLivro oLivro)
        {
            _Repositorio.Alterar(oLivro);
        }

        public void Excluir (TbLivro oLivro)
        {
            _Repositorio.Excluir(oLivro);
        }

        public List<TbLivro> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose(); 
        }
    }
}
