using System;
using Zuva.Payments.ApplicationCore.Entities;

namespace Zuva.Payments.ApplicationCore.Specifications
{
    public class PaymentSpecification : BaseSpecification<Payment>
    {
        public PaymentSpecification()
            : base(p => p.Status == Status.PendingFirstApproval || p.Status == Status.PendingFinalApproval)
        {
            AddInclude(p => p.PaymentApprovals);
            AddInclude(p => p.PaymentHistories);
            ApplyOrderBy(p => p.LastModifiedDate);
        }

        public PaymentSpecification(Status status)
            : base(p => p.Status == status)
        {
            AddInclude(p => p.PaymentApprovals);
            AddInclude(p => p.PaymentHistories);
            ApplyOrderBy(p => p.LastModifiedDate);
        }

        public PaymentSpecification(Status approved, Status paid, Status faulted, int skip, int take, string searchQuery = null)
            : base(p => p.Status == approved || p.Status == paid || p.Status == faulted && 
            string.IsNullOrEmpty(searchQuery) || p.SysProReferenceNumber.Contains(searchQuery) || 
            p.CreditorName.Contains(searchQuery) ||
            p.Amount.ToString().Contains(searchQuery) )
        {
            ApplyOrderBy(p => p.LastModifiedDate);
            ApplyPaging(skip, take);
        }

        public PaymentSpecification(string referenceNumber)
            : base(p => p.SysProReferenceNumber.Equals(referenceNumber))
        {
            AddInclude(p => p.PaymentApprovals);
            AddInclude(p => p.PaymentHistories);
        }

        public PaymentSpecification(Guid bankId, string referenceNumber) 
            : base(p => p.BankId == bankId && string.IsNullOrEmpty(referenceNumber) || p.SysProReferenceNumber.Equals(referenceNumber))
        {
        }

        public PaymentSpecification(DateTime date)
            : base(p => p.PaymentDate == date)
        {
        }

        public PaymentSpecification(DateTime startDate, DateTime endDate)
            : base(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate)
        {
        }

        public PaymentSpecification(Status status, DateTime startDate, DateTime endDate)
            : base(p => p.Status == status && p.LastModifiedDate >= startDate && p.LastModifiedDate <= endDate)
        {
        }

        public PaymentSpecification(Status approved, Status paid, Status faulted, DateTime startDate, DateTime endDate)
            : base(p => p.LastModifiedDate >= startDate && p.LastModifiedDate <= endDate &&
            p.Status == approved || p.Status == paid || p.Status == faulted
            )
        {
            ApplyOrderBy(p => p.LastModifiedDate);
        }
    }
}
