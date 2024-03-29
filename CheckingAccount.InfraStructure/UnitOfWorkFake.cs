﻿using CheckingAccount.Domain.SeedWork;
using System.Threading;
using System.Threading.Tasks;

namespace CheckingAccount.InfraStructure
{
    public class UnitOfWorkFake : IUnitOfWork
    {
        public void Dispose()
        {
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(1);
        }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(true);
        }
    }
}
