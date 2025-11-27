using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entidades;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Projeto.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração das tabelas
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.ToTable("Curso");
                entity.HasKey(c => c.IdCurso);
                entity.Property(c => c.Nome).HasMaxLength(100).IsRequired();
                entity.Property(c => c.NomeCoordenador).HasMaxLength(100).IsRequired();
                entity.Property(c => c.Ativo).IsRequired();
            });

            modelBuilder.Entity<Matricula>(entity =>
            {
                entity.ToTable("Matricula");
                entity.HasKey(m => m.Id);
                entity.Property(m => m.IdAluno).IsRequired();
                entity.Property(m => m.IdCurso).IsRequired();
                entity.Property(m => m.DataMatricula).IsRequired();
                entity.Property(m => m.Ativa).IsRequired();
            });
        }
    }
}
