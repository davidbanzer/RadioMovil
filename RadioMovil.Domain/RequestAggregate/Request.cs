using System;
using RadioMovil.Domain.Common.Models;
using RadioMovil.Domain.UserAggregate.ValueObjects;

namespace RadioMovil.Domain.RequestAggregate
{
    public sealed class Request : Entity<RequestId>
    {
        public ClientId ClientId { get; private set; }
        public ServiceType RequestedService { get; private set; }
        public Location PickupLocation { get; private set; }
        public Location DestinationLocation { get; private set; }
        public DateTime RequestDateTime { get; private set; }

        private Request(
            RequestId requestId,
            ClientId clientId,
            ServiceType requestedService,
            Location pickupLocation,
            Location destinationLocation,
            DateTime requestDateTime
        ) : base(requestId)
        {
            ClientId = clientId;
            RequestedService = requestedService;
            PickupLocation = pickupLocation;
            DestinationLocation = destinationLocation;
            RequestDateTime = requestDateTime;
        }

        public static Request Create(
            ClientId clientId,
            ServiceType requestedService,
            Location pickupLocation,
            Location destinationLocation,
            DateTime requestDateTime
        )
        {
            return new Request(
                RequestId.CreateUnique(),
                clientId,
                requestedService,
                pickupLocation,
                destinationLocation,
                requestDateTime
            );
        }

        public void UpdatePickupLocation(Location newLocation)
        {
            PickupLocation = newLocation;
        }

        public void UpdateDestinationLocation(Location newLocation)
        {
            DestinationLocation = newLocation;
        }
    }
}
