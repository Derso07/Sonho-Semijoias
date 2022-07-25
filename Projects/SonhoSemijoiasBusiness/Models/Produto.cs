using System.ComponentModel.DataAnnotations.Schema;

namespace SonhoSemijoiasBusiness.Models
{
    public class Produto : Entity
    {
        public Produto(string titulo, string descricao, double preco, int quantidade, DateTime dataCadastro, bool ativo, Guid categoriaId)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            CategoriaId = categoriaId;
        }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public Guid CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
