using System;
using System.Collections.Generic;
using ProjetoPapaiNoel.Domain.Entidades;
using ProjetoPapaiNoel.Domain.Interfaces;

namespace ProjetoPapaiNoel.Application.Services
{
    public class CartinhaService
    {
        private readonly ICartinhaRepository _repository;

        public CartinhaService(ICartinhaRepository repository)
        {
            _repository = repository;
        }

        public void AdicionarCartinha(Cartinha cartinha)
        {
            ValidarCartinha(cartinha);
            _repository.Adicionar(cartinha);
        }

        public List<Cartinha> ListarCartinhas()
        {
            return _repository.ListarTodas();
        }

        private void ValidarCartinha(Cartinha cartinha)
        {
            if (string.IsNullOrWhiteSpace(cartinha.NomeCrianca) ||
                cartinha.NomeCrianca.Length < 3 || cartinha.NomeCrianca.Length > 255)
                throw new ArgumentException("Nome da criança deve ter entre 3 e 255 caracteres.");

            if (string.IsNullOrWhiteSpace(cartinha.Endereco))
                throw new ArgumentException("Endereço é obrigatório.");

            if (cartinha.Idade < 0 || cartinha.Idade >= 15)
                throw new ArgumentException("Idade da criança deve ser menor que 15.");

            if (string.IsNullOrWhiteSpace(cartinha.TextoCarta) ||
                cartinha.TextoCarta.Length > 500)
                throw new ArgumentException("Texto da carta é obrigatório e deve ter no máximo 500 caracteres.");
        }
    }
}
