﻿using CheckingAccount.Domain.Aggregates.ContaCorrente;
using CheckingAccount.Domain.Exceptions;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CheckingAccount.Domain.Aggregates.ContaCorrenteAggregate
{
    public class ContaCorrente
    {
        private List<Lancamento> lancamentos = new List<Lancamento>();

        public ContaCorrente(
            Guid id,
            Guid correntistaId,
            IEnumerable<Lancamento> lancamentos)
        {
            if (id == null || id == Guid.Empty)
            {
                throw new CheckingAccountDomainException("Id da conta corrente é obrigatório");
            }

            if (correntistaId == null || correntistaId == Guid.Empty)
            {
                throw new CheckingAccountDomainException("CorrentistaId da conta corrente é obrigatório");
            }

            Id = id;
            CorrentistaId = correntistaId;
            this.lancamentos.AddRange(lancamentos);
        }

        public Guid Id { get; protected set; }
        
        public Guid CorrentistaId { get; protected set; }

        public void AdicionarLancamento(
            TipoLancamentoEnum tipo,
            decimal valor,
            DateTime data)
        {
            lancamentos.Add(new Lancamento(
                tipo,
                data,
                valor));
        }

        public decimal Saldo => lancamentos.Sum(l =>
        {
            if (l.TipoLancamento == TipoLancamentoEnum.Debito)
            {
                return (l.Valor * -1);
            }
            else
            {
                return l.Valor;
            }
        });
    }
}
