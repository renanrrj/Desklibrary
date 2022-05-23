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
    public class RepositorioTbLivro : IDisposable  //libera da memoria para uso
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioTbLivro() // Construtor 1 cria contexto na memoria
        {
            db = new LibraryContext();
        }

        public RepositorioTbLivro(LibraryContext _db) // Construtor 2 recebe o contexto de outro lugar
        {
            db = _db;
            RecebeuContexto = true;
        }

        public void Incluir(TbLivro oTbLivro) // Método "Incluir"
        {
            db.TbLivro.Add(oTbLivro);
            db.SaveChanges();
        }

        public void Alterar(TbLivro oTbLivro)
        {
            db.Entry(oTbLivro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(TbLivro oTbLivro)
        {
            db.Entry(oTbLivro).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public TbLivro Selecionar(int id)
        {
            return db.TbLivro.Find(id);
        }

        public TbLivro SelecionarScontexto(int Id)
        {
            return (from p in db.TbLivro where p.Id == Id select p).AsNoTracking().FirstOrDefault();
        }

        public List<TbLivro> SelecionarTodos()
        {
            return db.TbLivro.ToList();
        }

        public List<TbLivro> SelecionarTodosScontexto()
        {
            return (from p in db.TbLivro select p).AsNoTracking().ToList();
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
