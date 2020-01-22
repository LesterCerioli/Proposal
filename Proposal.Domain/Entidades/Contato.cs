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
                AdicionarCritica("Cr�tica - O nome do contato deve estar preenchido");

            if (string.IsNullOrEmpty(TelefoneContato))
                AdicionarCritica("Cr�tica - O telefone do contato deve estar preenchido");
        }
    }
}
