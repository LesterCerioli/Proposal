 using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entities
{
    public class Usuario : Entity
    {
        public int Id {get; set;}
        public string Nome { get; set; }
        public string SobreNome {get; set;}
        public string Email {get; set;}
        public string Senha { get; set; }
        public bool EhAdministrador {get; set;}
        public string Login {get; set;}
        public string PerfilUsuario {get; set;}

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email n�o foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha n�o foi informado");

            if (string.IsNullOrEmpty(Login))
                AdicionarCritica("Login n�o foi informado");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome n�o foi informado");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Sobrenome n�o foi informado");
        }
    }
}
