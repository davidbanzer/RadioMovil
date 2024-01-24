using System;
using RadioMovil.Domain.Common.Models;

namespace RadioMovil.Domain.AssignmentAggregate.ValueObjects
{
    public sealed class AssignmentId : ValueObject
    {
        public Guid Value { get; }

        private AssignmentId(Guid value)
        {
            Value = value;
        }

        public static AssignmentId CreateUnique()
        {
            return new AssignmentId(Guid.NewGuid());
        }

        public static AssignmentId Create(Guid value)
        {
            return new AssignmentId(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
