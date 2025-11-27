using System.Collections.Generic;
using ProjetoPapaiNoel.Domain.Entidades;
using ProjetoPapaiNoel.Domain.Interfaces;

namespace ProjetoPapaiNoel.Data.Repositories
{
    public class CartinhaRepository : ICartinhaRepository
    {
        private readonly List<Cartinha> _cartinhas = new();
        private int _autoIncrementId = 1;

        public void Adicionar(Cartinha cartinha)
        {
            cartinha.Id = _autoIncrementId++;
            _cartinhas.Add(cartinha);
        }

        public List<Cartinha> ListarTodas()
        {
            return new List<Cartinha>(_cartinhas);
        }
    }
}
