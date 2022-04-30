using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCapable.Models
{
    public static class ConfigurationSettings
    {
        public static string serviceClientUrl { get; set; }
        public static string clientId { get; set; }
        public static string clientSecret { get; set; }
        public static string loginUrl { get; set; }

    }
}
