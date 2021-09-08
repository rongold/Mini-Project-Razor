using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace RazorPagesCovidTests
{
    public class AppConfigReader
    {
        public static readonly string HomePageUrl = ConfigurationManager.AppSettings["home_url"];
        public static readonly string UsersURL = ConfigurationManager.AppSettings["users_url"];
        public static readonly string AppointmentsURL = ConfigurationManager.AppSettings["appointments_url"];
        public static readonly string VaccinesURL = ConfigurationManager.AppSettings["vaccines_url"];
        public static readonly string PrivacyURL = ConfigurationManager.AppSettings["privacy_url"];
    }
}
