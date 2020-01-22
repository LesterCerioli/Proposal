using Proposal.Domain.Entidades;
using System;

namespace Proposta.Domain.Entidades
{
    public class Template : Entity
    {

        public int Id { get; set; }
        public string TemplateNome { get; set; }
        public int TemplateSecaoId { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(TemplateNome))
                AdicionarCritica("Crítica - O nome do template deve ser informado");
        }
    }
}
