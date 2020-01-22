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
                AdicionarCritica("Cr�tica - A unidade de medida n�o foi informado");

            if (string.IsNullOrEmpty(UnidadeSigla))
                AdicionarCritica("Cr�tica - A sigla da unidade de medida n�o foi informado");
        }
    }
}
