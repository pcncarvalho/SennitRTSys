using RTSys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Infra.Data.EntityConfiguration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Domain.Entities.Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.DataCadastro)
                .IsRequired();

        }
    }
}
