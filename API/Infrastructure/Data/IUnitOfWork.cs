﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data
{
    public interface IRepositoryFactory
    {
        IWriteRepository<TEntity> GetWriteRepository<TEntity>() where TEntity : class;
        IReadRepository<TEntity> GetReadRepository<TEntity>() where TEntity : class;
    }

    public interface IUnitOfWork : IRepositoryFactory, IDisposable
    {
        int Commit();
        Task<int> CommitAsync();
    }
}
