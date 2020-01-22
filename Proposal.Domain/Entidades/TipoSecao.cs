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
                AdicionarCritica("Cr�tica - O nome do tipo de se�l�o deve ser informado");

        }
    }
}
