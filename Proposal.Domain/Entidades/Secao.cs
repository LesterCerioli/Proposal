using Proposal.Domain.Entidades;
using System;

namespace Proposta.Domain.Entidades
{
    public class Secao : Entity
    {

        public int Id { get; set; }
        public string SecoaNome { get; set; }
        public int TipoSecaoId { get; set; }
        

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
