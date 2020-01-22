using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposa.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class PublicoAlvoConfiguration : IEntityTypeConfiguration<PublicoAlvo>
    {
        public void Configure(EntityTypeBuilder<PublicoAlvo> builder)
        {
            throw new NotImplementedException();
        }
    }
}
