﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proposal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Repository.Config
{
    public class TipoTemplateConfiguration : IEntityTypeConfiguration<TipoTemplate>
    {
        public void Configure(EntityTypeBuilder<TipoTemplate> builder)
        {
            throw new NotImplementedException();
        }
    }
}
