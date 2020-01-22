using System;
using System.Collections.Generic;
using System.Text;

namespace Proposal.Domain.Contratos
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        //This instruction update on database
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);

    }
}
