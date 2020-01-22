using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposta.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class UsuarioInfoConfiguration : IEntityTypeConfiguration<UsuarioInfo>
    {
        public void Configure(EntityTypeBuilder<UsuarioInfo> builder)
        {
            throw new NotImplementedException();
        }
    }
}
