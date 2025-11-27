using System.Collections.Generic;
using ProjetoPapaiNoel.Domain.Entidades;

namespace ProjetoPapaiNoel.Domain.Interfaces
{
    public interface ICartinhaRepository
    {
        void Adicionar(Cartinha cartinha);
        List<Cartinha> ListarTodas();
    }
}
