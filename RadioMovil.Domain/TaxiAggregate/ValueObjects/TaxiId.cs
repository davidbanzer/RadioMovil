using RadioMovil.Domain.Common.Models;

namespace RadioMovil.Domain.TaxiAggregate.ValueObjects
{
    public sealed class TaxiId : ValueObject
    {
        public Guid Value { get; }

        private TaxiId(Guid value)
        {
            Value = value;
        }

        public static TaxiId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static TaxiId Create(Guid value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
