namespace Edgias.Elections.ApplicationCore.Entities
{
    public class Candidate : Person
    {
        public Candidate(string firstName, string lastName, string mobileNumber, string email, string nationalId) 
            : base(firstName, lastName, mobileNumber, email, nationalId)
        {
        }
    }
}
