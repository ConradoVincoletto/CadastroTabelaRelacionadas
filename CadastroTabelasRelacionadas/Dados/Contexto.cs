using CadastroTabelasRelacionadas.Entidades;
using CadastroTabelasRelacionadas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroTabelasRelacionadas.Dados
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Usuarios> usuarios { get; set; }

        public DbSet<Produto> produtos { get; set; }

        public DbSet<Categoria> categorias { get; set; }

        public DbSet<Permissao> permissoes { get; set; }   
        
        public DbSet<Usuarios_Permissoes> usuario_permissao { get; set; }



    }
}
