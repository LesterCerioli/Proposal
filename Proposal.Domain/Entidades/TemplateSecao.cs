using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entities
{

    
    public class TemplateSecao : Entity
    {

        public int Id { get; set; }

        public string TemplateSecaoNome { get; set; }
        public int TemplateId { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(TemplateSecaoNome))
                AdicionarCritica("Crítica - O nome do template de seção deve ser informado");
        }
    }
}
