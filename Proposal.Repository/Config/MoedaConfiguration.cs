using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposta.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class MoedaConfiguration : IEntityTypeConfiguration<Moeda>
    {
        public void Configure(EntityTypeBuilder<Moeda> builder)
        {
            throw new NotImplementedException();
        }
    }
}
