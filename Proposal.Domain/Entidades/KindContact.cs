using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Domain.Entidades
{
    public class KindContact : Entity
    {
        
        public int Id { get; set; }
        public int ContatoId { get; set; }
        public string TipoNome { get; set; } 
        
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(TipoNome))
                AdicionarCritica("Crítica - O tipo do contato deve estar preenchido");
        }
    }
}
