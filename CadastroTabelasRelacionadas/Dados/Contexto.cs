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

    }
}
