using CheckingAccount.Domain.Aggregates.CorrentistaAggregate;
using CheckingAccount.Domain.Exceptions;
using System;
using Xunit;

namespace CheckingAccount.UnitTests.Domain
{
    public class ContaCorrenteAggregateTest
    {
        public ContaCorrenteAggregateTest()
        {
        }

        [Fact]
        public void Criar_Correntista_Sucesso()
        {
            //Arrange 
            var id = Guid.NewGuid();
            var nome = "Fulano de tal";

            //Act
            var correntista = new Correntista(id, nome);

            //Assert 
            Assert.NotNull(correntista);
        }

        [Fact]
        public void Criar_Correntista_Id_Invalido_Falha()
        {
            //Arrange 
            Guid id = Guid.Empty;
            var nome = "Fulano de tal";

            //Act - Assert
            Assert.Throws<CheckingAccountDomainException>(() => 
                new Correntista(id, nome));
        }

        [Fact]
        public void Criar_Correntista_Nome_Invalido_Falha()
        {
            //Arrange 
            Guid id = Guid.NewGuid();
            var nome = string.Empty;

            //Act - Assert
            Assert.Throws<CheckingAccountDomainException>(() =>
                new Correntista(id, nome));
        }
    }
}
