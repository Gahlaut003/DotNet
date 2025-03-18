
using Utility_001.Models;
using Utility_001.SpConstants;


using Utility_001.Libs.DAL;
using System.Data;

namespace Utility_001.Repository
{
    public class SampleIPRepository : Repository<SampleIPModel>,ISampleIPRepository
    {
        private readonly AdoDBContext DbContext;
        public SampleIPRepository(AdoDBContext context) : base(context)
        {
            DbContext = context;
        }

        public SampleIPModel GetAllSampleIP()
        {
            throw new NotImplementedException();
        }

        public int AddSampleIP(SampleIPModel sampleIPModel)
        {
            try {
                using (var command = DbContext.CreateCommand()) {
                    command.CommandText = SPConsant.ADD_IP;
                  
                    command.Parameters.Add(command.CreateParameter("ip_address",sampleIPModel.IpAddress));
                    command.CommandType = CommandType.StoredProcedure;
                    var temp = this.ExecuteDataSet(command);
                     this.ExecuteNonQuery(command);
                    return 1;
                   
                }
            } catch(Exception ex) {
                throw new Exception("Error adding sample data", ex);
            }
        }
        public List<SampleIPModel> GetAllSampleIPs()
        {
            try
            {
                using (var command = DbContext.CreateCommand())
                {
                    command.CommandText = SPConsant.GET_ALL_IP;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var table = this.ExecuteDataTable(command);
                    var sampleIPs = new List<SampleIPModel>();
                    if (table.Rows.Count > 0)
                    {
                        foreach (System.Data.DataRow row in table.Rows)
                        {
                            var sampleIP = new SampleIPModel
                            {
                       
                                Id = Convert.ToInt32(row["Id"]),
                                IpAddress = row["IpAddress"].ToString(),
                            };

                            sampleIPs.Add(sampleIP);
                        }
                    }
                    return sampleIPs;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching SampleIP data", ex);
            }
        }



    }
}
