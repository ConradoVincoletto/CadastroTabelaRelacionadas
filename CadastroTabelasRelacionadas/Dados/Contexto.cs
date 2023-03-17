using CadastroTabelasRelacionadas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroTabelasRelacionadas.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Produto> produtos { get; set; }

    }
}
