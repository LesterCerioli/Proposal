using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entities
{
    public class TipoSecao : Entity
    {

        public int Id { get; set; }
        public int SecaoId { get; set; }
        public string TipoSecaoNome { get; set; }


        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(TipoSecaoNome))
                AdicionarCritica("Crítica - O nome do tipo de seçlão deve ser informado");

        }
    }
}
