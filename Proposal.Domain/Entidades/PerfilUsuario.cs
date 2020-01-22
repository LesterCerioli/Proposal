using Proposal.Domain.Entidades;
using System;

namespace Proposal.Domain.Entidades
{
    public class PerfilUsuario : Entity
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int UsuarioId {get; set;}

        public override void Validate()
        {

            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome do perfil não foi informado");

            
        }
    }
}