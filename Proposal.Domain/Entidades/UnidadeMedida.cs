using Proposal.Domain.Entidades;
using System;


namespace Proposal.Domain.Entities
{
    public class UnidadeMedida : Entity
    {

        public int Id { get; set; }
        public string UnidadeMedidaNome { get; set; }
        public string UnidadeSigla { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(UnidadeMedidaNome))
                AdicionarCritica("Crítica - A unidade de medida não foi informado");

            if (string.IsNullOrEmpty(UnidadeSigla))
                AdicionarCritica("Crítica - A sigla da unidade de medida não foi informado");
        }
    }
}
