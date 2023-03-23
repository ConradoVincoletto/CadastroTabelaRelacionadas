using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroTabelasRelacionadas.Entidades
{
    public class Produto
    {
        
        public int Id { get; set; }
        public string Descricao { get; set; }   
        
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }





    }
}
