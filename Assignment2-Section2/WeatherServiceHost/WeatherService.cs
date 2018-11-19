using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WeatherServiceHost
{
    public partial class WeatherService : ServiceBase
    {
        ServiceHost host;
        public WeatherService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(Assignment2_Section2.WeatherService));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
                host.Close();
        }
    }
}
