using System;
using Zuva.Payments.ApplicationCore.Entities;

namespace Zuva.Payments.ApplicationCore.Specifications
{
    public class ReconciliationSpecification : BaseSpecification<Reconciliation>
    {
        public ReconciliationSpecification(string owner)
            : base(r => r.Owner.Equals(owner))
        {
            ApplyOrderBy(r => r.CreatedDate);
        }

        public ReconciliationSpecification(Guid reconciliationId)
            : base(r => r.Id == reconciliationId)
        {
            AddInclude(r => r.ReconciliationTransactions);
        }

        public ReconciliationSpecification(Guid reconciliationId, DateTime startDate, DateTime endDate)
            : base(r => r.Id == reconciliationId && r.StartDate == startDate && r.EndDate == endDate)
        {
            AddInclude(r => r.ReconciliationTransactions);
        }
    }
}
