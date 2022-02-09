#nullable disable

using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class Constituency : BaseEntity
    {
        public string Name { get; private set; }

        public Guid ProvinceId { get; private set; }

        public Province Province { get; private set; }

        public Constituency(string name, Guid provinceId)
        {   
            Name = name;
            ProvinceId = provinceId;
        }

        public void ChangeProvince(Guid provinceId)
        {
            ProvinceId = provinceId;
        }

        public void Update(string name)
        {
            Name = name;
        }
    }
}
