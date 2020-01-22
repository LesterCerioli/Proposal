using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProposalDomain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class PropostaTagConfiguration : IEntityTypeConfiguration<PropostaTag>
    {
        public void Configure(EntityTypeBuilder<PropostaTag> builder)
        {
            throw new NotImplementedException();
        }
    }
}
