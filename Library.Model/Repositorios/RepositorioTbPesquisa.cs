using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;


namespace Library.Model.Repositorios
{
    public class RepositorioTbPesquisa : IDisposable
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioTbPesquisa()
        {
            db = new LibraryContext();
        }
        public RepositorioTbPesquisa(LibraryContext _db)
        {
            db = _db;
            RecebeuContexto = true;
        }
        public void Incluir(TbPesquisa oCliente) // Método "Incluir"
        {
            db.TbPesquisa.Add(oCliente);
            db.SaveChanges();
        }
        public void Alterar(TbPesquisa oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Excluir(TbPesquisa oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
        public void Excluir(string nome)
        {
            TbPesquisa oCliente = db.TbPesquisa.Find(nome);
            db.TbPesquisa.Remove(oCliente);
            db.SaveChanges();
        }
        public TbPesquisa Selecionar(string nome)
        {
            return db.TbPesquisa.Find(nome);
        }
        public TbPesquisa SelecionarScontexto(string Nome)
        {
            return (from d in db.TbPesquisa where d.TituloPesquisa == Nome select d).AsNoTracking().FirstOrDefault();
        }
        public List<TbPesquisa> SelecionarTodos()
        {
            return db.TbPesquisa.ToList();
        }
        public List<TbPesquisa> SelecionarTodosScontexto()
        {
            return (from x in db.TbPesquisa select x).AsNoTracking().ToList();
        }
        public void Dispose()
        {
            if (!RecebeuContexto)
            {
                db.Dispose();
            }
        }
    }
}
