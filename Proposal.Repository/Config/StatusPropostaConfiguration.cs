using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class StatusPropostaConfiguration : IEntityTypeConfiguration<StatusProposta>
    {
        public void Configure(EntityTypeBuilder<StatusProposta> builder)
        {
            throw new NotImplementedException();
        }
    }
}
