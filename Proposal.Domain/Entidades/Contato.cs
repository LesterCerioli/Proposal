using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entidades
{

    
    public class Contato : Entity
    {
        public int Id { get; set; }
        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public int KindContatctId { get; set; }
        public virtual KindContact GetKindContact { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomeContato))
                AdicionarCritica("Crítica - O nome do contato deve estar preenchido");

            if (string.IsNullOrEmpty(TelefoneContato))
                AdicionarCritica("Crítica - O telefone do contato deve estar preenchido");
        }
    }
}
