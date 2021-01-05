using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TableServers
    {
        private static readonly TableServers _instance = new();
        private List<string> servers = new();
        private int nextServer = 0;
        private TableServers()
        {
            servers.Add("Server1");
            servers.Add("Server2");
            servers.Add("Server3");
            servers.Add("Server4");
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;
            if(nextServer >=servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
