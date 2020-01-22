using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
