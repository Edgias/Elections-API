using Zuva.Payments.ApplicationCore.Entities;

namespace Zuva.Payments.ApplicationCore.Specifications
{
    public class PaymentApprovalSpecification : BaseSpecification<PaymentApproval>
    {
        public PaymentApprovalSpecification(string userId, int skip, int take) 
            : base(pa => pa.ApproverId.Equals(userId))
        {
            AddInclude(pa => pa.Payment);
            ApplyOrderByDescending(pa => pa.DateApproved);
            ApplyPaging(skip, take);
        }
    }
}
