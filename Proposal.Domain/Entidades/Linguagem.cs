using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entidades
{
    public class Linguagem : Entity
    {

        public int Id { get; set; }
        public string NomeLinguagem { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomeLinguagem))
                AdicionarCritica("Crítica - O idioma do contato deve estar preenchido");
        }
    }
}
