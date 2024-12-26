using System.Linq.Expressions;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{

    protected RepositoryContext RepositoryContext;

    public RepositoryBase(RepositoryContext repositoryContext)
    {
        RepositoryContext = repositoryContext;
    }

    public void Create(T entity)
    {
        RepositoryContext.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        RepositoryContext.Set<T>().Remove(entity);
    }


    public IQueryable<T> FindAll(bool trackChanges)
    {
        return trackChanges ?
        RepositoryContext.Set<T>() :
        RepositoryContext.Set<T>()
        .AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        return trackChanges ?
        RepositoryContext.Set<T>().Where(expression) :
        RepositoryContext.Set<T>().Where(expression)
        .AsNoTracking();
    }

    public void Update(T entity)
    {
        RepositoryContext.Set<T>().Update(entity);
    }
}
