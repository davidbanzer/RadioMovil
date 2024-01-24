using System;
using System.Collections.Generic;
using RadioMovil.Domain.Common.Models;
using RadioMovil.Domain.StandAggregate.ValueObjects;

namespace RadioMovil.Domain.StandAggregate
{
    public sealed class Stand : Entity<StandId>
    {
        public string Name { get; private set; }
        public Location StandLocation { get; private set; }

        private Stand(StandId standId, string name, Location standLocation) : base(standId)
        {
            Name = name;
            StandLocation = standLocation;
        }

        public static Stand Create(string name, Location standLocation)
        {
            return new Stand(StandId.CreateUnique(), name, standLocation);
        }

        public void UpdateLocation(Location newLocation)
        {
            StandLocation = newLocation;
        }
    }
}
