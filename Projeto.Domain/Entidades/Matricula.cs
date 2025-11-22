namespace Projeto.Domain.Entidades
{
    public class Matricula
    {
        public int Id { get; set; } 
        public int IdAluno { get; set; }
        public int IdCurso { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativa { get; set; }
    }
}
