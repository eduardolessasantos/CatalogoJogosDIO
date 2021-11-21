
using System;

namespace ExemploApiCatalogoJogos.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public int Genero { get; set; }
        public string GeneroDescricao { get; set; }

        public static string RetornaDescricaoGenero(int genero)
        {
            CategoriaJogo categoria = new CategoriaJogo(genero);
            return categoria.DescricaoCategoria;
        }
    }


}
