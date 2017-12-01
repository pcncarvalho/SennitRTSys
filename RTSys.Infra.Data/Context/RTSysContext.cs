using RTSys.Infra.Data.EntityConfiguration;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RTSys.Infra.Data.Context
{
    public class RTSysContext : DbContext
    {
        private DbConnection _objCn;

        public RTSysContext() 
            : base("RTSys")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public RTSysContext(string connectionString)
        {
            var cn = ConfigurationManager.ConnectionStrings[connectionString];
            _objCn = DbProviderFactories.GetFactory(cn.ProviderName).CreateConnection();
            _objCn.ConnectionString = cn.ConnectionString;
        }

        public RTSysContext(DbConnection connection)
            : base(connection, true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelbuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelbuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelbuilder.Configurations.Add(new ClienteConfiguration());
            modelbuilder.Configurations.Add(new CupomConfiguration());
        }

        public DbSet<Domain.Entities.Cliente> Clientes { get; set; }
        public DbSet<Domain.Entities.Cupom> Cupons { get; set; }
    }
}
