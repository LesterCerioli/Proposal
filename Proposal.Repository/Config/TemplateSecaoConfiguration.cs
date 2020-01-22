using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class TemplateSecaoConfiguration : IEntityTypeConfiguration<TemplateSecao>
    {
        public void Configure(EntityTypeBuilder<TemplateSecao> builder)
        {
            throw new NotImplementedException();
        }
    }
}
