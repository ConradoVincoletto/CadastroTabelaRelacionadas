using CadastroTabelasRelacionadas.Entidades;
using Microsoft.Build.ObjectModelRemoting;

namespace CadastroTabelasRelacionadas.Models
{
    public class ListaPermissoesModel
    {
        public List<Permissao> TodasPermissoes { get; set; }
        public List<Usuarios_Permissoes> Permissoesusuario { get; set; }
    }
}
