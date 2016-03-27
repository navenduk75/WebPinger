using System;
using System.Net.NetworkInformation;
using log4net;

namespace WebPinger
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            var ping = new Ping();
            var result = ping.Send("webapi.swamaanshaadi.com");

            Log.Info("Status: " + result.Status.ToString());

            //if (result.Status != IPStatus.Success)
            //    return;
        }
    }
}
