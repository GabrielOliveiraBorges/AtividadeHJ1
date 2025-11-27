using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Data.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly AppDbContext _context;

        public MatriculaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Matricula Adicionar(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            _context.SaveChanges();
            return matricula;
        }

        public void Remover(int id)
        {
            var matricula = _context.Matriculas.Find(id);
            if (matricula != null)
            {
                _context.Matriculas.Remove(matricula);
                _context.SaveChanges();
            }
        }

        public Matricula BuscarPorId(int id)
        {
            return _context.Matriculas.FirstOrDefault(m => m.Id == id);
        }

        public List<Matricula> BuscarTodos()
        {
            return _context.Matriculas.ToList();
        }
    }
}
