using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraTbPesquisa : IDisposable
    {
        RepositorioTbPesquisa _Repositorio;

        public ControladoraTbPesquisa()
        {
            _Repositorio = new RepositorioTbPesquisa();
        }
        public void Incluir(TbPesquisa oCliente)
        {
            _Repositorio.Incluir(oCliente);
        }

        public void Alterar(TbPesquisa oCliente)
        {
            _Repositorio.Alterar(oCliente);
        }

        public void Excluir(TbPesquisa oCliente)
        {
            _Repositorio.Excluir(oCliente);
        }

        public List<TbPesquisa> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose();
        }
    }
}
