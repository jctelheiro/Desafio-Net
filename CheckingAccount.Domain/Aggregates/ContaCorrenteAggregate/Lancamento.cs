using CheckingAccount.Domain.Aggregates.ContaCorrenteAggregate;
using System;

namespace CheckingAccount.Domain.Aggregates.ContaCorrente
{
    public class Lancamento
    {
        public Lancamento(
            TipoLancamentoEnum tipoLancamento,
            DateTime data,
            decimal valor)
        {
            TipoLancamento = tipoLancamento;
            Valor = valor;
            Data = data;
        }

        public TipoLancamentoEnum TipoLancamento { get; protected set; }
        public decimal Valor { get; protected set; }
        public DateTime Data { get; protected set; }
    }
}
