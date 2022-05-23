using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraEmprestimo
    {
        RepositorioTbEmprestimo _Repositorio;
        public ControladoraEmprestimo()
        {
            _Repositorio = new RepositorioTbEmprestimo();
        }
        public void Incluir(TbEmprestimo oEmprestimo)
        {
            _Repositorio.Incluir(oEmprestimo);
        }

        public void Alterar(TbEmprestimo oEmprestimo)
        {
            _Repositorio.Alterar(oEmprestimo);
        }

        public void Excluir(TbEmprestimo oEmprestimo)
        {
            _Repositorio.Excluir(oEmprestimo);
        }
        public List<TbEmprestimo> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose();
        }
    }
}
