using CheckingAccount.Domain.Exceptions;
using System;

namespace CheckingAccount.Domain.Aggregates.CorrentistaAggregate
{
    public class Correntista
    {
        public Correntista(Guid id, string nome)
        {
            if (id == null || id == Guid.Empty)
            {
                throw new CheckingAccountDomainException("Id do correntista é obrigatório");
            }

            if (string.IsNullOrEmpty(nome))
            {
                throw new CheckingAccountDomainException("O nome do correntista é obrigatório");
            }

            Id = id;
            Nome = nome;
        }

        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }       
    }
}
