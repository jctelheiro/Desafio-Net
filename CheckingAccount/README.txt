Considera��es
=============

A solution foi criada levando em considera��o o m�nimo valor do produto, 
para atender a necessidade dos requisitos propostos utilizando o conceito de API para 
Microservice, DDD, CleanCode, SOLID.

Utilizei seguran�a m�nima na API atrav�s de secret-key que est� configurada no arquivo: 
	appsettings.Development.json (a chave secreta � 'teste')

Utilizei uma implementa��o de CQRS (parcial) n�o utilizei as Queries

O swagger foi configurado para intera��o se desej�vel.

Implementei um reposit�rio in memory para fins de simplicidade

No DDD tentei demonstrar os conceitos t�cnicod de AggregateRoot, Entity e ValueObject, 
neste caso n�o utilizei os domain events.

Melhorias: 

Poderia implementar eventsourcing com domain events, mas o tempo n�o foi suficiente e 
	acho que para o teste pr�tico deve atender.

N�o implementei um gateway de api e nem health check pelos motivos anteriores.

Os testes unit�rios do DomainModel est�o cobertos plenamente, 
	e coloquei somente um teste no controller.

Ao executar o projeto em modo 'Development' a extens�o 'SeedWorkLoadRepositoryExtension' 
	� executada e duas contas correntes ser�o criadas para auxiliar.