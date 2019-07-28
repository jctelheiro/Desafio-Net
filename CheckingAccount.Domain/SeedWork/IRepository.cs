using System;
using System.Threading.Tasks;

namespace CheckingAccount.Domain.SeedWork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        void Add(T aggregate);
        void Update(T aggregate);
        void Delete(T aggregate);
        Task<T> FindByIdAsync(Guid aggregateId);
    }
}
