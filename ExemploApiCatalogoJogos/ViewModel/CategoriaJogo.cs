namespace ExemploApiCatalogoJogos.ViewModel
{
    public class CategoriaJogo
    {

        public string DescricaoCategoria { get; set; }
        public CategoriaJogo(int genero)
        {
            string result;
            switch (genero)
            {
                case 1:
                    result = "Aventura";
                    break;
                case 2:
                    result = "Esportes";
                    break;
                case 3:
                    result = "Guerra";
                    break;
                case 4:
                    result = "RPG";
                    break;
                case 5:
                    result = "Estratégia";
                    break;
                default:
                    result = "Gênero insexistênte";
                    break;
            }

            DescricaoCategoria = result;
        }
    }
}
