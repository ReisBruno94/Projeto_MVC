using Projeto.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto.EF
{
    public class ConexaoBD : DbContext
    {
        public ConexaoBD() : base("ConexaoDB")
        {
            
        }

        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Conta> conta { get; set; }
        public DbSet<Banco> banco { get; set; }
         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Cliente>().Property(x => x.nome).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            //modelBuilder.Entity<Cliente>().Property(x => x.cpf).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            //modelBuilder.Entity<Cliente>().Property(x => x.telefone).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            //modelBuilder.Entity<Cliente>().Property(x => x.email).IsRequired().HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
