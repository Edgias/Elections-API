using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public abstract class Person : BaseEntity
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string MobileNumber { get; private set; }

        public string Email { get; private set; }

        public string NationalId { get; private set; }

        public Person(string firstName, string lastName, string mobileNumber, string email, string nationalId)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Email = email;
            NationalId = nationalId;
        }

        public virtual void Update(string firstName, string lastName, string mobileNumber, string email, string nationalId)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Email = email;
            NationalId = nationalId;
        }
    }
}
