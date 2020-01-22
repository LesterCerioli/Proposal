using Proposal.Domain.Entidades;
using System;

namespace Proposta.Domain.Entidades
{
    public class Moeda : Entity
    {

        public int Id { get; set; }
        public string NomeMoeda { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomeMoeda))
                AdicionarCritica("Crítica - O nome da moeda deve estar preenchido");
        }
    }
}
