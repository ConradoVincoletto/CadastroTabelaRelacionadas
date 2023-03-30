using CadastroTabelasRelacionadas.Entidades;
using Microsoft.Build.ObjectModelRemoting;

namespace CadastroTabelasRelacionadas.Models
{
    public class ListaPermissoesModel
    {
        public int UsuarioId { get; set; }
        public List<Permissao> TodasPermissoes { get; set; }
        public List<Usuarios_Permissoes> PermissoesUsuario { get; set; }
    }
}
