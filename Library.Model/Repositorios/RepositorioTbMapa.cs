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
    public class RepositorioTbMapa : IDisposable
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioTbMapa()
        {
            db = new LibraryContext();
        }
        public RepositorioTbMapa(LibraryContext _db)
        {
            db = _db;
            RecebeuContexto = true;
        }
        public void Incluir(TbMapa oCliente) // Método "Incluir"
        {
            db.TbMapa.Add(oCliente);
            db.SaveChanges();
        }
        public void Alterar(TbMapa oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Excluir(TbMapa oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
        public void Excluir(string nome)
        {
            TbMapa oCliente = db.TbMapa.Find(nome);
            db.TbMapa.Remove(oCliente);
            db.SaveChanges();
        }
        public TbMapa Selecionar(string nome)
        {
            return db.TbMapa.Find(nome);
        }
        public TbMapa SelecionarScontexto(string Nome)
        {
            return (from d in db.TbMapa where d.Locall == Nome select d).AsNoTracking().FirstOrDefault();
        }
        public List<TbMapa> SelecionarTodos()
        {
            return db.TbMapa.ToList();
        }
        public List<TbMapa> SelecionarTodosScontexto()
        {
            return (from x in db.TbMapa select x).AsNoTracking().ToList();
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

