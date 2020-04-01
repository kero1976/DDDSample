using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.Domain.src.ValueObjects
{
    public sealed class SampleValue : ValueObject<SampleValue>
    {
        protected override bool EqualsCore(SampleValue other)
        {
            return this.Value == other.Value;
        }
        public string Value { get; }

        public SampleValue(string value)
        {
            Value = value;
        }
    }
}
