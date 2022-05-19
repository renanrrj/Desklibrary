using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model.Repositorios;
using Library.Model;


namespace Library.Model.Repositorios
{
    public class RepositorioLivro : IDisposable  //libera da memoria para uso
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioLivro() // Construtor 1 cria contexto na memoria
        {
            db = new LibraryContext();
        }

        public RepositorioLivro(LibraryContext _db) // Construtor 2 recebe o contexto de outro lugar
        {
            db = _db;
            RecebeuContexto = true;
        }

        public void Incluir(Livro oLivro) // Método "Incluir"
        {
            db.Livro.Add(oLivro);
            db.SaveChanges();            
        }

        public void Alterar(Livro oLivro)
        {
            db.Entry(oLivro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();            
        }

        public void Excluir(Livro oLivro)
        {
            db.Entry(oLivro).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();            
        }

        public Livro Selecionar(int id)
        {
            return db.Livro.Find(id);
        }

        public Livro SelecionarScontexto(int Id)
        {
            return (from p in db.Livro where p.Id == Id select p).AsNoTracking().FirstOrDefault();
        }

        public List<Livro> SelecionarTodos()
        {
            return db.Livro.ToList();
        }

        public List<Livro> SelecionarTodosScontexto()
        {
            return (from p in db.Livro select p).AsNoTracking().ToList();
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
