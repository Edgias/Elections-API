#nullable disable

using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class PollingStation : BaseEntity
    {
        public string Name { get; private set; }

        public Guid WardId { get; private set; }

        public Ward Ward { get; private set; }

        public PollingStation(string name, Guid wardId)
        {
            Name = name;
            WardId = wardId;
        }

        public void Update(string name)
        {
            Name = name;
        }

        public void ChangeWard(Guid wardId)
        {
            WardId = wardId;
        }
    }
}
