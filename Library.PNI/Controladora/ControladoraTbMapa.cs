using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Model.Repositorios;

namespace Library.PNI.Controladora
{
    public class ControladoraTbMapa : IDisposable
    {
        RepositorioTbMapa _Repositorio;

        public ControladoraTbMapa()
        {
            _Repositorio = new RepositorioTbMapa();
        }
        public void Incluir(TbMapa oCliente)
        {
            _Repositorio.Incluir(oCliente);
        }

        public void Alterar(TbMapa oCliente)
        {
            _Repositorio.Alterar(oCliente);
        }

        public void Excluir(TbMapa oCliente)
        {
            _Repositorio.Excluir(oCliente);
        }

        public List<TbMapa> SelecionarTodos()
        {
            return _Repositorio.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repositorio.Dispose();
        }
    }
}
