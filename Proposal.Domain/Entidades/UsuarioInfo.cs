using Proposal.Domain.Entidades;
using Proposal.Domain.Entities;
using System;

namespace Proposta.Domain.Entidades
{
    public class UsuarioInfo : Entity
    {

        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
