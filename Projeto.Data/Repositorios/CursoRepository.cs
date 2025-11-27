using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly AppDbContext _context;

        public CursoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Curso Adicionar(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            return curso;
        }

        public Curso Atualizar(Curso curso)
        {
            _context.Cursos.Update(curso);
            _context.SaveChanges();
            return curso;
        }

        public void Remover(int idCurso)
        {
            var curso = _context.Cursos.Find(idCurso);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
        }

        public Curso BuscarPorId(int idCurso)
        {
            return _context.Cursos.FirstOrDefault(c => c.IdCurso == idCurso);
        }

        public List<Curso> BuscarTodos()
        {
            return _context.Cursos.ToList();
        }
    }
}
