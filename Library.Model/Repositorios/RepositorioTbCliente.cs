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
    public class RepositorioTbCliente : IDisposable
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioTbCliente()
        {
            db = new LibraryContext();
        }
        public RepositorioTbCliente(LibraryContext _db)
        {
            db = _db;
            RecebeuContexto = true;
        }
        public void Incluir(TbCliente oCliente) // Método "Incluir"
        {
            db.TbCliente.Add(oCliente);
            db.SaveChanges();
        }
        public void Alterar(TbCliente oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Excluir(TbCliente oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
        public void Excluir(string nome)
        {
            TbCliente oCliente = db.TbCliente.Find(nome);
            db.TbCliente.Remove(oCliente);
            db.SaveChanges();
        }
        public TbCliente Selecionar(string nome)
        {
            return db.TbCliente.Find(nome);
        }
        public TbCliente SelecionarScontexto(string Nome)
        {
            return (from d in db.TbCliente where d.Nome == Nome select d).AsNoTracking().FirstOrDefault();
        }
        public List<TbCliente> SelecionarTodos()
        {
            return db.TbCliente.ToList();
        }
        public List<TbCliente> SelecionarTodosScontexto()
        {
            return (from x in db.TbCliente select x).AsNoTracking().ToList();
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
