using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class SecaoArquivoConfiguration : IEntityTypeConfiguration<SecaoArquivo>
    {
        public void Configure(EntityTypeBuilder<SecaoArquivo> builder)
        {
            throw new NotImplementedException();
        }
    }
}
