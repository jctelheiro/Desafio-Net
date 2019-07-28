using CheckingAccount.Domain.Aggregates.ContaCorrenteAggregate;
using CheckingAccount.Domain.Exceptions;
using System;

namespace CheckingAccount.Domain.Services
{
    public class OperacaoDomainService
    {
        public void EfetuarTransacao(
            ContaCorrente contaOrigem, 
            ContaCorrente contaDestino, 
            DateTime data,
            decimal valorOperacao)
        {
            ValidarContas(contaOrigem, contaDestino);

            ChecarSaldoSuficiente(
                contaOrigem.Saldo, 
                valorOperacao);

            contaOrigem.AdicionarLancamento(
                TipoLancamento.Debito,
                valorOperacao,
                data);

            contaDestino.AdicionarLancamento(
                TipoLancamento.Credito,
                valorOperacao,
                data);
        }

        private void ValidarContas(ContaCorrente contaOrigem, ContaCorrente contaDestino)
        {
            if (contaDestino.Id == contaOrigem.Id)
            {
                throw new CheckingAccountDomainException("Conta de origem e destino devem ser diferentes para realizar esta operação");
            }
        }

        private void ChecarSaldoSuficiente(
            decimal saldoContaOrigem,
            decimal valorOperacao)
        {
            if (saldoContaOrigem < valorOperacao)
            {
                throw new CheckingAccountDomainException("O saldo da conta não é suficiente para realizar esta operação");
            }
        }
    }
}
