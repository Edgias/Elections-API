using Edgias.Elections.ApplicationCore.SharedKernel;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class Contestant : BaseEntity
    {
        public Guid? CandidateId { get; private set; }

        public Candidate Candidate { get; private set; }

        public Guid ElectionPeriodId { get; private set; }

        public ElectionPeriod ElectionPeriod { get; private set; }

        public Guid? PartyId { get; private set; }

        public Party Party { get; private set; }

        public Guid PositionId { get; private set; }

        public Position Position { get; private set; }

        public Contestant(Guid? candidateId, Guid electionPeriodId, Guid? partyId, Guid positionId)
        {
            CandidateId = candidateId;
            ElectionPeriodId = electionPeriodId;
            PartyId = partyId;
            PositionId = positionId;
        }
    }
}
