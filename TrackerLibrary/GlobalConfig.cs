using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textfile)
        {
            if (database)
            {
                //TODO: database connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textfile)
            {
                //TODO: textfile connection
            }
        }
    }
}
