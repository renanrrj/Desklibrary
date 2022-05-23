using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraTbCliente : IDisposable
    {
        RepositorioTbCliente _Repositorio;

        public ControladoraTbCliente()
        {
            _Repositorio = new RepositorioTbCliente();
        }
        public void Incluir(TbCliente oCliente)
        {
            _Repositorio.Incluir(oCliente);
        }

        public void Alterar(TbCliente oCliente)
        {
            _Repositorio.Alterar(oCliente);
        }

        public void Excluir(TbCliente oCliente)
        {
            _Repositorio.Excluir(oCliente);
        }

        public List<TbCliente> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose();
        }
    }
}
