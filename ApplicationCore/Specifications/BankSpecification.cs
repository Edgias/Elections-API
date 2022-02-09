using Zuva.Payments.ApplicationCore.Entities;

namespace Zuva.Payments.ApplicationCore.Specifications
{
    public class BankSpecification : BaseSpecification<Bank>
    {
        public BankSpecification(BankType bankType) 
            : base(b => b.BankType == bankType)
        {
        }
    }
}
