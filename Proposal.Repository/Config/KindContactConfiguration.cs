using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class KindContactConfiguration : IEntityTypeConfiguration<KindContact>
    {
        public void Configure(EntityTypeBuilder<KindContact> builder)
        {
            throw new NotImplementedException();
        }
    }
}
