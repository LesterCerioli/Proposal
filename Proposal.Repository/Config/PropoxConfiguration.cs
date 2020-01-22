using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class PropoxConfiguration : IEntityTypeConfiguration<Propox>
    {
        public void Configure(EntityTypeBuilder<Propox> builder)
        {
            throw new NotImplementedException();
        }
    }
}
