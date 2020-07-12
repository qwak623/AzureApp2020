using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AzureApp2020
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            string instrumentationKey = (string)System.Configuration.ConfigurationManager.AppSettings["ApplicationInsights"];
            if (!string.IsNullOrEmpty(instrumentationKey))
                Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = instrumentationKey;
        }
    }
}