using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.Domain.Repositories
{
    public interface ISampleRepository
    {
        SampleEntity GetSample();
    }
}
