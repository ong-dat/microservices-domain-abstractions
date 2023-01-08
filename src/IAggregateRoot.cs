namespace Ongdat.Microservices.Domain;

/// <summary>
/// Apply this marker interface only to aggregate root entities.
/// Repositories will only work with aggregate roots, not their children
/// </summary>
/// <see href="https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/microservice-domain-model" />
/// <see href="https://martinfowler.com/bliki/DDD_Aggregate.html"/>
public interface IAggregateRoot
{
}