using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Domain.Entidades
{
    public class Estado : Entity
    {

        public int Id { get; set; }
        public string NomeEstado { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomeEstado))
                AdicionarCritica("Crítica - O nome do estado deve estar preenchido");
        }
    }
}
