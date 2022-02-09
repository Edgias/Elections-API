namespace Edgias.Elections.ApplicationCore.Entities
{
    public class PollingAgent : Person
    {
        public PollingAgent(string firstName, string lastName, string mobileNumber, string email, string nationalId)
            : base(firstName, lastName, mobileNumber, email, nationalId)
        {
        }
    }
}
