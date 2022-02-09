using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class ElectionPeriod : BaseEntity
    {
        public string Name { get; private set; }

        public DateTime ElectionDate { get; private set; }

        public ElectionPeriod(string name, DateTime electionDate)
        {
            Name = name;
            ElectionDate = electionDate;
        }

        public void Update(string name)
        {
            Name = name;
        }

    }
}
