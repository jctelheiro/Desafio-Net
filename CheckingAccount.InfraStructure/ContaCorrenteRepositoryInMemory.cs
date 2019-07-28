using CheckingAccount.Domain.Aggregates.ContaCorrenteAggregate;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CheckingAccount.InfraStructure
{
    public class ContaCorrenteRepositoryInMemory
        : IContaCorrenteRepository
    {
        private readonly Dictionary<Guid, ContaCorrente> contasCorrentes;

        public ContaCorrenteRepositoryInMemory()
        {
            contasCorrentes = new Dictionary<Guid, ContaCorrente>();
        }

        public void Add(ContaCorrente contaCorrente)
        {
            if (!contasCorrentes.ContainsKey(contaCorrente.Id))
            {
                contasCorrentes.Add(contaCorrente.Id, contaCorrente);
            }
            else
            {
                throw new InvalidOperationException($"Erro ao incluir conta corrente: '{contaCorrente.Id}' já existe");
            }
        }

        public void Delete(ContaCorrente aggregate)
        {
            throw new NotImplementedException();
        }

        public Task<ContaCorrente> FindByIdAsync(Guid id)
        {
            ContaCorrente result = null;

            if (contasCorrentes.ContainsKey(id))
            {
                result = contasCorrentes[id];
            }

            return Task.FromResult(result);
        }

        public void Update(ContaCorrente contaCorrente)
        {
            if (contasCorrentes.ContainsKey(contaCorrente.Id))
            {
                contasCorrentes[contaCorrente.Id] = contaCorrente;
            }
            else
            {
                throw new InvalidOperationException($"Erro ao atualizar conta corrente: '{contaCorrente.Id}' não encontrada");
            }
        }
    }
}
