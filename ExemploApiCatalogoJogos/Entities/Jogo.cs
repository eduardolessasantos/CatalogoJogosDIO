
using System;

namespace ExemploApiCatalogoJogos.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public int Genero { get; set; }
        public string GeneroDescricao { get; set; }
    }
}
