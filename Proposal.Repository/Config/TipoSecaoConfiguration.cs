using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class TipoSecaoConfiguration : IEntityTypeConfiguration<TipoSecao>
    {
        public void Configure(EntityTypeBuilder<TipoSecao> builder)
        {
            throw new NotImplementedException();
        }
    }
}
