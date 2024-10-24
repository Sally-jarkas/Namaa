using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namaa
{
    internal class ConfigurationProvider
    {
        public static ConfigurationManager configuration;

        public static ConfigurationManager Configuration
        {

            get
            {
                if (configuration == null)
                {
                    configuration = new ConfigurationManager();
                    configuration.AddJsonFile("appsettings.json", false, false);
                }
                return configuration;
            }
        }
    }
}