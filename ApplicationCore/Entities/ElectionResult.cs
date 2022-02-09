using Edgias.Elections.ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgias.Elections.ApplicationCore.Entities
{
    public class ElectionResult : BaseEntity
    {
        public Guid ContestantId { get; private set; }

        public Contestant Contestant { get; private set; }

        public bool IsVerified { get; private set; }

        public int NumberOfVotes { get; private set; }

        public Guid PollingStationId { get; private set; }

        public PollingStation PollingStation { get; private set; }
    }
}
