using clientes_crmall.Models;
using Microsoft.EntityFrameworkCore;
namespace clientes_crmall.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}