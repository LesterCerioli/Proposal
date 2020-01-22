using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entities
{
    public class TipoTemplate : Entity
    {

        public int Id { get; set; }
        public string NomeTemplate { get; set; }
        public int SecaoId { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomeTemplate))
                AdicionarCritica("Crítica - O nome do template deve ser informado");
        }
    }
}
