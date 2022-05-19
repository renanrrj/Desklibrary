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
    public class RepositorioEmprestimo1 : IDisposable
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioEmprestimo1() // Construtor 1 cria contexto na memoria
        {
            db = new LibraryContext();
        }

        public RepositorioEmprestimo1(LibraryContext _db) // Construtor 2 recebe o contexto de outro lugar
        {
            db = _db;
            RecebeuContexto = true;
        }
        public void Incluir(Emprestimo1 oEmprestimo1) // Método "Incluir"
        {
            db.Emprestimo1.Add(oEmprestimo1);
            db.SaveChanges();
        }

        public void Alterar(Emprestimo1 oEmprestimo1)
        {
            db.Entry(oEmprestimo1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Emprestimo1 oEmprestimo1)
        {
            db.Entry(oEmprestimo1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
        public Emprestimo1 Selecionar(int id)
        {
            return db.Emprestimo1.Find(id);
        }

        public Emprestimo1 SelecionarScontexto(int Id)
        {
            return (from p in db.Emprestimo1 where p.Id == Id select p).AsNoTracking().FirstOrDefault();
        }

        public List<Emprestimo1> SelecionarTodos()
        {//aqui
            return db.Emprestimo1.ToList();
        }

        public List<Emprestimo1> SelecionarTodosScontexto()
        {
            return (from p in db.Emprestimo1 select p).AsNoTracking().ToList();
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
