
using Utility_001.Models;
using Utility_001.Repository;

namespace Utility_001.Services
{
    public class SampleIPService : ISampleIPService

    {

        private readonly ISampleIPRepository _isampleIPRepository;

        public SampleIPService(ISampleIPRepository isampleIPRepository)
        {
            _isampleIPRepository = isampleIPRepository;
        }

        public int AddIP(SampleIPModel sampleIPModel)
        {
            try { 
                if(sampleIPModel == null)
                    throw new ArgumentNullException(nameof(sampleIPModel), "Sample IP cannot be null");

                return _isampleIPRepository.AddSampleIP(sampleIPModel);

            } catch(Exception ex) {
                throw new Exception("Error occurred while adding Sample IP data.", ex);
            }
        }


        public  List<SampleIPModel> GetAllIP()
        {
            try
            {
                return  _isampleIPRepository.GetAllSampleIPs();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while fetching Sample IP data.", ex);
            }
        }
    }
}
