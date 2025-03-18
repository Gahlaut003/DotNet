using Utility_001.Data;
using Utility_001.Models;

namespace Utility_001.Repository
{
    public interface ISampleIPRepository
    {
        SampleIPModel GetAllSampleIP();
        List<SampleIPModel> GetAllSampleIPs();
        int AddSampleIP(SampleIPModel sampleIPModel);
    }
}

