using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entidades
{
    public class Cliente : Entity
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string NomeContato { get; set; }
        public string InscricaoEstadual { get; set; }
        public string EnderecoCompleto { get; set; }
        public string ContatoId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public int PaisId { get; set; }
        public virtual Contato Contato { get; set; } 

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(RazaoSocial))
                AdicionarCritica("Crítica - Razão Social deve estar preenchido");

            if (string.IsNullOrEmpty(NomeFantasia))
                AdicionarCritica("Crítica - Nome fantasia deve estar preenchido");

            if (string.IsNullOrEmpty(CNPJ))
                AdicionarCritica("Crítica - CNPJ deve estar preenchido");

            if (string.IsNullOrEmpty(NomeContato))
                AdicionarCritica("Crítica - Nome do contato deve estar preenchido");

            if (string.IsNullOrEmpty(EnderecoCompleto))
                AdicionarCritica("Crítica - O endereço completo deve estar preenchido");




        }
    }
}
       


        
        
        
    
    

