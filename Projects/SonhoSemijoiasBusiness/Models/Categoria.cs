namespace SonhoSemijoiasBusiness.Models
{
    public class Categoria : Entity
    {
        public Categoria(string titulo, bool ativa)
        {
            Titulo = titulo;
            Ativa = ativa;
        }

        public string Titulo { get; set; }

        public bool Ativa { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
