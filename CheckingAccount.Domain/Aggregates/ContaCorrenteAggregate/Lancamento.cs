using CheckingAccount.Domain.Aggregates.ContaCorrenteAggregate;
using CheckingAccount.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace CheckingAccount.Domain.Aggregates.ContaCorrente
{
    public class Lancamento : ValueObject
    {
        public Lancamento(
            TipoLancamento tipoLancamento,
            DateTime data,
            decimal valor)
        {
            TipoLancamento = tipoLancamento;
            Valor = valor;
            Data = data;
        }

        public TipoLancamento TipoLancamento { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return TipoLancamento;
            yield return Data;
            yield return Valor;
        }
    }
}
