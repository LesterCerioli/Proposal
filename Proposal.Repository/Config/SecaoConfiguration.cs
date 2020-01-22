using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposta.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class SecaoConfiguration : IEntityTypeConfiguration<Secao>
    {
        public void Configure(EntityTypeBuilder<Secao> builder)
        {
            throw new NotImplementedException();
        }
    }
}
