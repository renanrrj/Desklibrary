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
    public class RepositorioTbEmprestimo : IDisposable
    {
        private bool RecebeuContexto = false;
        private LibraryContext db;

        public RepositorioTbEmprestimo() // Construtor 1 cria contexto na memoria
        {
            db = new LibraryContext();
        }

        public RepositorioTbEmprestimo(LibraryContext _db) // Construtor 2 recebe o contexto de outro lugar
        {
            db = _db;
            RecebeuContexto = true;
        }

        public void Incluir(TbEmprestimo oEmprestimo1) // Método "Incluir"
        {
            db.TbEmprestimo.Add(oEmprestimo1);
            db.SaveChanges();
        }

        public void Alterar(TbEmprestimo oEmprestimo1)
        {
            db.Entry(oEmprestimo1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(TbEmprestimo oEmprestimo1)
        {
            db.Entry(oEmprestimo1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
        public TbEmprestimo Selecionar(int id)
        {
            return db.TbEmprestimo.Find(id);
        }

        public TbEmprestimo SelecionarScontexto(int Id)
        {
            return (from p in db.TbEmprestimo where p.Id == Id select p).AsNoTracking().FirstOrDefault();
        }

        public List<TbEmprestimo> SelecionarTodos()
        {//aqui
            return db.TbEmprestimo.ToList();
        }
        

        public List<TbEmprestimo> SelecionarTodosScontexto()
        {
            return (from p in db.TbEmprestimo select p).AsNoTracking().ToList();
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
