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
            throw new NotImplementedException();
        }
    }
}
