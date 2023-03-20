namespace CadastroTabelasRelacionadas.Entidades
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }       

        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }


    }
}
