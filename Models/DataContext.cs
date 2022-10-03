using Microsoft.EntityFrameworkCore;

namespace Atacadista.Models
{
  public class DataContext : DbContext //instanciar
  {
    public DataContext(DbContextOptions<DataContext> options) :
        base(options)
    {

    }
    public DbSet<Itens> Itens { get; set; } //adicionar tabela no banco
    public DbSet<Estoques> Estoques { get; set; } //adicionar tabela no banco
  }
}