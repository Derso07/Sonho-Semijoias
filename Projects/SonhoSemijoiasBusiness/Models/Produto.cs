namespace SonhoSemijoiasBusiness.Models
{
    public class Produto : Entity
    {
        public Produto(string titulo, string descricao, string imagem, double preco, int quantidade, int categoriaId, Categoria categoria)
        {
            Titulo = titulo;
            Descricao = descricao;
            Imagem = imagem;
            Preco = preco;
            Quantidade = quantidade;
            CategoriaId = categoriaId;
            Categoria = categoria;
        }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
