using RadioMovil.Domain.Common.Models;
using RadioMovil.Domain.TaxiAggregate.Events;
using RadioMovil.Domain.TaxiAggregate.ValueObjects;

namespace RadioMovil.Domain.TaxiAggregate
{
    public sealed class Taxi : AggregateRoot<TaxiId>
    {
        public string LicensePlate { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public bool IsAvailable { get; private set; }
        public Location CurrentLocation { get; private set; }

        private Taxi(
            TaxiId taxiId,
            string licensePlate,
            string brand,
            string model,
            string color,
            bool isAvailable,
            Location currentLocation
        ) : base(taxiId)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Color = color;
            IsAvailable = isAvailable;
            CurrentLocation = currentLocation;
        }

        public static Taxi Create(
            string licensePlate,
            string brand,
            string model,
            string color,
            Location currentLocation
        )
        {
            var taxi = new Taxi(
                TaxiId.CreateUnique(),
                licensePlate,
                brand,
                model,
                color,
                true,
                currentLocation
            );


            return taxi;
        }


#pragma warning disable CS8618
        private Taxi()
        {
            // Constructor privado requerido por EF Core u otras herramientas ORM.
        }
#pragma warning restore CS8618
    }
}