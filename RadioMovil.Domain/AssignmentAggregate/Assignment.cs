using System;
using RadioMovil.Domain.Common.Models;
using RadioMovil.Domain.RequestAggregate;
using RadioMovil.Domain.UserAggregate.ValueObjects;

namespace RadioMovil.Domain.AssignmentAggregate
{
    public sealed class Assignment : Entity<AssignmentId>
    {
        public RequestId RequestId { get; private set; }
        public TaxiId TaxiId { get; private set; }
        public Location Destination { get; private set; }

        private Assignment(AssignmentId assignmentId, RequestId requestId, TaxiId taxiId, Location destination)
            : base(assignmentId)
        {
            RequestId = requestId;
            TaxiId = taxiId;
            Destination = destination;
        }

        public static Assignment Create(RequestId requestId, TaxiId taxiId, Location destination)
        {
            return new Assignment(AssignmentId.CreateUnique(), requestId, taxiId, destination);
        }


#pragma warning disable CS8618
        private Assignment()
        {
        }
#pragma warning restore CS8618
    }
}
