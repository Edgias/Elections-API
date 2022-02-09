#nullable disable

using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class Ward : BaseEntity
    {
        public string Name { get; private set; }

        public Guid ConstituencyId { get; private set; }

        public Constituency Constituency { get; private set; }

        private readonly List<PollingStation> _pollingStations = new();

        public IReadOnlyCollection<PollingStation> PollingStations => _pollingStations.AsReadOnly();

        public Ward(string name, Guid constituencyId)
        {
            Name = name;
            ConstituencyId = constituencyId;
        }

        public void Update(string name)
        {
            Name = name;
        }

        public void ChangeConstituency(Guid constituencyId)
        {
            ConstituencyId = constituencyId;
        }
    }
}
