using RadioMovil.Domain.Common.Models;

namespace RadioMovil.Domain.Common.ValueObjects;

public sealed class Location : ValueObject
{
    public double Latitude { get; }
    public double Longitude { get; }

    private Location(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public static Location Create(double latitude, double longitude)
    {
        return new Location(latitude, longitude);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Latitude;
        yield return Longitude;
    }
}