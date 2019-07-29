Considerações
=============

A solution foi criada levando em consideração o mínimo valor do produto, 
para atender a necessidade dos requisitos propostos utilizando o conceito de API para 
Microservice, DDD, CleanCode, SOLID.

Utilizei segurança mínima na API através de secret-key que está configurada no arquivo: 
	appsettings.Development.json (a chave secreta é 'teste')

Utilizei uma implementação de CQRS (parcial) não utilizei as Queries

O swagger foi configurado para interação se desejável.

Implementei um repositório in memory para fins de simplicidade

No DDD tentei demonstrar os conceitos técnicod de AggregateRoot, Entity e ValueObject, 
neste caso não utilizei os domain events.

Melhorias: 

Poderia implementar eventsourcing com domain events, mas o tempo não foi suficiente e 
	acho que para o teste prático deve atender.

Não implementei um gateway de api e nem health check pelos motivos anteriores.

Os testes unitários do DomainModel estão cobertos plenamente, 
	e coloquei somente um teste no controller.

Ao executar o projeto em modo 'Development' a extensão 'SeedWorkLoadRepositoryExtension' 
	é executada e duas contas correntes serão criadas para auxiliar.