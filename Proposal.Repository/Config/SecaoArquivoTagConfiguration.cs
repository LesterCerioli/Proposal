using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class SecaoArquivoTagConfiguration : IEntityTypeConfiguration<SecaoArquivoTag>
    {
        public void Configure(EntityTypeBuilder<SecaoArquivoTag> builder)
        {
            throw new NotImplementedException();
        }
    }
}
