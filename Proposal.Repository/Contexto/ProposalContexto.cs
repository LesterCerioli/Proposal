using Microsoft.EntityFrameworkCore;
using Proposa.Domain.Entidades;
using Proposal.Domain.Entidades;
using Proposal.Domain.Entities;
using Proposal.Repository.Config;
using ProposalDomain.Entidades;
using Proposta.Domain.Entidades;

namespace Proposal.Repository.Contexto
{
    public class ProposalContexto : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<KindContact> KindContacts { get; set; }
        public DbSet<Linguagem> Linguagems { get; set; }
        public DbSet<Moeda> Moedas { get; set; }
        public DbSet<Pais> Paisees { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PropostaTag> PropostaTags { get; set; }
        public DbSet<Propox> Propoxes { get; set; }
        public DbSet<PublicoAlvo> PublicoAlvos { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Secao> Secaos { get; set; }
        public DbSet<SecaoArquivo> SecaoArquivos { get; set; }
        public DbSet<SecaoArquivoTag> SecaoArquivoTags { get; set; }
        public DbSet<StatusProposta> StatusPropostas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateSecao> TemplateSecaos { get; set; }
        public DbSet<TipoSecao> TipoSecaos { get; set; }
        public DbSet<TipoTemplate> TipoTemplates { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<UsuarioInfo> UsuarioInfos { get; set; }

       public ProposalContexto(DbContextOptions options) : base(options)
        {

                              

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Classes de mapeamento
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new KindContactConfiguration());
            modelBuilder.ApplyConfiguration(new LinguagemConfiguration());
            modelBuilder.ApplyConfiguration(new MoedaConfiguration());
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PropostaTagConfiguration());
            modelBuilder.ApplyConfiguration(new PropoxConfiguration());
            modelBuilder.ApplyConfiguration(new PublicoAlvoConfiguration());
            modelBuilder.ApplyConfiguration(new RecursoConfiguration());
            modelBuilder.ApplyConfiguration(new SecaoArquivoConfiguration());
            modelBuilder.ApplyConfiguration(new SecaoArquivoTagConfiguration());
            modelBuilder.ApplyConfiguration(new SecaoConfiguration());
            modelBuilder.ApplyConfiguration(new StatusPropostaConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new TemplateConfiguration());
            modelBuilder.ApplyConfiguration(new TemplateSecaoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new UnidadeMedidaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioInfoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());









            base.OnModelCreating(modelBuilder);
        }



        




    }
}

