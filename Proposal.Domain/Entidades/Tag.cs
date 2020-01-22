using Proposal.Domain.Entidades;
using System;

namespace Proposta.Domain.Entidades
{
    public class Tag : Entity
    {

        public int Id { get; set; }
        public string NomeTag { get; set; }
        public int CidadeId { get; set; }
        public int ClienteId { get; set; }
        public int ContatoId { get; set; }
        public int EstadoId { get; set; }
        public int KindContactId { get; set; }
        public int LinguagemId { get; set; }
        public int MoedaId { get; set; }
        public int PaisId { get; set; }
        public int PerfilUsuarioId { get; set; }
        public int ProdutoId { get; set; }
        public int PropostaTagId { get; set; }
        public int PropoxId { get; set; }
        public int PublicoAlvoId { get; set; }
        public int RecursoId { get; set; }
        public int SecaoArquivoId { get; set; }
        public int SecaoArquivoTagId { get; set; }
        public int SecaoId { get; set; }
        public int StatusPropostaId { get; set; }
        public int TemplateId { get; set; }
        public int TemplateSecaoId { get; set; }
        public int TipoSecaoId { get; set; }
        public int TipoTemplateId { get; set; }
        public int UnidadeMedidaId { get; set; }
        public int UsuarioInfoId { get; set; }
        public int UsuarioId { get; set; }



        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

