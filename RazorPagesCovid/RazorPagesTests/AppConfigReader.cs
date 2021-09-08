using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWalkthrough
{
    public class AppConfigReader
    {
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string InventoryPageUrl = ConfigurationManager.AppSettings["inventory_url"];
    }
}
