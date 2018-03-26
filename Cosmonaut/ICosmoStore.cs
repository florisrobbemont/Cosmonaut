﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;

namespace Cosmonaut
{
    public interface ICosmoStore<TEntity>
    {
        Task<CosmosResponse> AddAsync(TEntity entity, RequestOptions requestOptions = null);

        Task<TEntity> FirstOrDefaultAsync(Func<TEntity, bool> predicate);

        Task<List<TEntity>> ToListAsync(Func<TEntity, bool> predicate = null);
    }
}