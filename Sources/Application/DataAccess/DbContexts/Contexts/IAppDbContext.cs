﻿using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DataAccess.DbContexts.Contexts
{
    public interface IAppDbContext : IDisposable
    {
        [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Same name as the one on the DbContext needed")]
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}