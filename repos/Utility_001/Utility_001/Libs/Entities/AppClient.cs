using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Utility_001.Libs.Entities;
namespace Utility_001.Libs.Entities
{
 
 
        public partial class AppClientConfig
        {
            public List<AppClient> Clients { get; set; } = new List<AppClient>();
            public DateTime LastChangedOn { get; set; } = DateTime.MinValue;
        }
        public partial class AppClient
        {
            public AppClient()
            {

                AppClientConnection = new HashSet<DBConnectionSetup>();
            }
            public virtual int Id { get; set; }
            public virtual string Code { get; set; }
            public virtual string ProductClientCode { get; set; }
            public virtual string ProductCode { get; set; }
            public virtual string ClientGuid { get; set; }
            public virtual string Name { get; set; }
            public virtual string Theme { get; set; }
            public virtual DateTime? RegDate { get; set; }
            public virtual byte? IsActive { get; set; }
            public virtual DateTime? CreatedDate { get; set; }
            public virtual byte? IsDBSettingsEncrypted { get; set; }
            public virtual int ConnectionType { get; set; }
            public virtual string ProviderName { get; set; }
            public virtual string MainDBServer { get; set; }
            public virtual string MainDBUser { get; set; }
            public virtual string MainDBPassword { get; set; }

            public virtual string MainDBPort { get; set; }
            public virtual string MainDatabase { get; set; }
            public virtual string ReportingDBServer { get; set; }
            public virtual string ReportingDBUser { get; set; }
            public virtual string ReportingDBPassword { get; set; }
            public virtual string ReportingDBPort { get; set; }
            public virtual string ReportingDatabase { get; set; }
            public virtual string YFAdminId { get; set; }
            public virtual string YFAdminPassword { get; set; }
            public virtual string YFAdminURL { get; set; }
            public virtual string YFServer { get; set; }
            public virtual string YFDatabase { get; set; }
            public virtual string YFUserId { get; set; }
            public virtual string YFPassword { get; set; }
            public virtual ICollection<DBConnectionSetup> AppClientConnection { get; set; }
        }
        public enum ConnectionType
        {
            DBMain = 1,
            DBReport = 2
        }
        public partial class DBConnectionSetup
        {
            public virtual int Id { get; set; }
            public virtual int? AppClientId { get; set; }
            public virtual int? ConnectionType { get; set; }
            public virtual string ProviderName { get; set; }
            public virtual string ServerName { get; set; }
            public virtual int Port { get; set; }

        public virtual string Dbname { get; set; }
        public virtual string UserId { get; set; }
            public virtual string Pwd { get; set; }

            public virtual string DBConnectionString
            {
                get
                {
                    return string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", ServerName, Port, Dbname, UserId, Pwd);
                }
            }
            public virtual AppClient _AppClient { get; set; }
        }
    }

