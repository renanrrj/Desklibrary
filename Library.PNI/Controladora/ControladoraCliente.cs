using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraCliente : IDisposable
    {
        RepositorioCliente1 _Repositorio;

        public ControladoraCliente()
        {
            _Repositorio = new RepositorioCliente1();
        }
        public void Incluir(Cliente oCliente)
        {
            _Repositorio.Incluir(oCliente);
        }

        public void Alterar(Cliente oCliente)
        {
            _Repositorio.Alterar(oCliente);
        }

        public void Excluir(Cliente oCliente)
        {
            _Repositorio.Excluir(oCliente);
        }

        public List<Cliente> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose();
        }
    }
}
