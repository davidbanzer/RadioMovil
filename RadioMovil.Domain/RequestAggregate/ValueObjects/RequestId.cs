using System;
using RadioMovil.Domain.Common.Models;

namespace RadioMovil.Domain.RequestAggregate.ValueObjects
{
    public sealed class RequestId : ValueObject
    {
        public Guid Value { get; }

        private RequestId(Guid value)
        {
            Value = value;
        }

        public static RequestId CreateUnique()
        {
            return new RequestId(Guid.NewGuid());
        }

        public static RequestId Create(Guid value)
        {
            return new RequestId(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
