using Utility_001.Data;
using Utility_001.Models;

namespace Utility_001.Services
{
    public interface ISampleIPService
    {
        List<SampleIPModel> GetAllIP();

        int AddIP(SampleIPModel sampleIPModel);

    }
}
