namespace Edgias.Elections.ApplicationCore.SharedKernel
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime LastModifiedDate { get; private set; }

        public List<BaseDomainEvent> Events { get; private set; } = new List<BaseDomainEvent>();

        public void AddDomainEvent(BaseDomainEvent domainEvent)
        {
            Events.Add(domainEvent);
        }

        public void RemoveDomainEvent(BaseDomainEvent domainEvent)
        {
            Events.Remove(domainEvent);
        }

        public void SetCreatedDate()
        {
            CreatedDate = DateTime.Now;
        }

        public void SetModifiedDate()
        {
            LastModifiedDate = DateTime.Now;
        }
    }
}
