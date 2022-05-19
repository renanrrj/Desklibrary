using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraEmprestimo1
    {
        RepositorioEmprestimo1 _Repositorio;
        public ControladoraEmprestimo1()
        {
            _Repositorio = new RepositorioEmprestimo1();
        }
        public void Incluir(Emprestimo1 oEmprestimo1)
        {
            _Repositorio.Incluir(oEmprestimo1);
        }

        public void Alterar(Emprestimo1 oEmprestimo1)
        {
            _Repositorio.Alterar(oEmprestimo1);
        }

        public void Excluir(Emprestimo1 oEmprestimo1)
        {
            _Repositorio.Excluir(oEmprestimo1);
        }
        public List<Emprestimo1> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose();
        }
    }
}
