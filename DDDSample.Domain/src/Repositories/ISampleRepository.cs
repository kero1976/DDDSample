using DDDSample.Domain.src.Entities;

namespace DDDSample.Domain.src.Repositories
{
    public interface ISampleRepository
    {
        SampleEntity GetSample();
    }
}
