using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using log4net;
using log4net.Config;

namespace ContactForm
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            XmlConfigurator.Configure();

            ILog _log = LogManager.GetLogger(this.GetType());

            if(_log != null && _log.IsInfoEnabled)
            {
                _log.Info("Application start");
            }
        }

        protected void Application_End()
        {
            ILog _log = LogManager.GetLogger(this.GetType());

            if (_log != null && _log.IsInfoEnabled)
            {
                _log.Info("Application end");
            }
        }
    }
}
