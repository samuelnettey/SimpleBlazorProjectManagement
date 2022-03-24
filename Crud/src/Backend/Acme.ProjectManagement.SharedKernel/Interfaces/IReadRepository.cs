using Ardalis.Specification;

namespace Acme.ProjectManagement.SharedKernel.Interfaces
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}