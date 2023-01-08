namespace Ongdat.Microservices.Domain;

public interface IEntity
{
  Guid Id { get; }
}

public interface IEntity<TKey> : IEntity
{
  new TKey Id { get; }
}