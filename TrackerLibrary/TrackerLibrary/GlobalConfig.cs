using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections{ get; private set; } = new List<IDataConnection> ();

        public static void InitializeConnection(bool database, bool textFile)
        {
            // TODO : setup sql obj properly
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFile)
            {
                // TODO : setup text obj properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
