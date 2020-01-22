using Proposal.Domain.Entidades;
using System;

namespace Proposta.Domain.Entidades
{
    public class Pais : Entity
    {

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NomePais { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomePais))
                AdicionarCritica("Crítica - O nome do país deve ser informado");
        }
    }
}
