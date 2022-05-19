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
    public class RepositorioCliente : IDisposable
    {
        private bool RecebeuContexto = false;        
        private LibraryContext db;
        
        public RepositorioCliente()
        {
            db = new LibraryContext();
        }
        public RepositorioCliente(LibraryContext _db)
        {
            db = _db;
            RecebeuContexto = true;
        }
        public void Incluir (Cliente oCliente) // Método "Incluir"
        {
            db.Cliente.Add(oCliente);
            db.SaveChanges();             
        }
        public void Alterar(Cliente oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Excluir(Cliente oCliente)
        {
            db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
        public void Excluir(string nome)
        {
            Cliente oCliente = db.Cliente.Find(nome);
            db.Cliente.Remove(oCliente);
            db.SaveChanges();
        }
        public Cliente Selecionar(string nome)
        {
            return db.Cliente.Find(nome);
        }
        public Cliente SelecionarScontexto (string Nome)
        {
            return (from d in db.Cliente where d.Nome == Nome select d).AsNoTracking().FirstOrDefault();
        }
        public List<Cliente> SelecionarTodos()
        { 
            return db.Cliente.ToList();
        }
        public List<Cliente> SelecionarTodosScontexto()
        {
            return (from x in db.Cliente select x).AsNoTracking().ToList();
        }
        public void Dispose()
        {
            if(!RecebeuContexto)
            {
                db.Dispose();
            }
        }
    }
}
