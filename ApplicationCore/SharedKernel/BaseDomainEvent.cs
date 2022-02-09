using MediatR;

namespace Edgias.Elections.ApplicationCore.SharedKernel
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
    }
}
