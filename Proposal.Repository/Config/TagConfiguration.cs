using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposta.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            throw new NotImplementedException();
        }
    }
}
