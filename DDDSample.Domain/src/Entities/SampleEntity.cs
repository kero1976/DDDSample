using DDDSample.Domain.src.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.Domain.src.Entities
{
    public sealed class SampleEntity
    {
        public SampleEntity()
        {

        }
        SampleValue sample { get; }
    }
}
