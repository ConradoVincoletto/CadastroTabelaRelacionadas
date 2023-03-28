namespace CadastroTabelasRelacionadas.Entidades
{
    public class Usuarios_Permissoes
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PermissaoId { get; set; }
        public Usuarios usuarios { get; set; }
        public Permissao permissao { get; set; }
    }
}
