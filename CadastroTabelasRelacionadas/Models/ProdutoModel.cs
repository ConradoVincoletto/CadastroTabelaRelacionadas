using CadastroTabelasRelacionadas.Entidades;

namespace CadastroTabelasRelacionadas.Models
{
    public class ProdutoModel : Produto
    {
        public List<Categoria> ListaCategorias { get; set; }      

    }
}
