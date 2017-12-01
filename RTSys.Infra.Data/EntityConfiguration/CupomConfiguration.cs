using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSys.Infra.Data.EntityConfiguration
{
    public class CupomConfiguration : EntityTypeConfiguration<Domain.Entities.Cupom>
    {
        public CupomConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.Codigo)
                .IsRequired()
                .HasMaxLength(30);

            Property(c => c.DataCadastro)
                .IsRequired();
        }
    }
}
