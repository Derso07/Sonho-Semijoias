namespace SonhoSemijoiasBusiness.Models
{
    public class Categoria : Entity
    {
        public Categoria () { }
        public Categoria(string titulo, bool ativa, List<Produto> produtos)
        {
            Titulo = titulo;
            Ativa = ativa;
            Produtos = produtos;
        }

        public string Titulo { get; set; }

        public bool Ativa { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
