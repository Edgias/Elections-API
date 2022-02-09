using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class Party : BaseEntity
    {
        public string Name { get; private set; }

        public Party(string name)
        {
            Name = name;
        }
    }
}
