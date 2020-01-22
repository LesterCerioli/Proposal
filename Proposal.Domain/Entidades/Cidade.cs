using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entidades
{
    public class Cidade : Entity
    {

        public int Id { get; set; }
        public string NomeCidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(NomeCidade))
                AdicionarCritica("O nome da cidade deve ser preenchido");
        }
    }

    


}