using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var yoneticiSinif = new YoneticiSinif(new NetLoggerAdapter(), "NetLogger");
            yoneticiSinif.Kaydet();

            //var yoneticiSinif = new YoneticiSinif(new XLogger(), "XLogger");
            //yoneticiSinif.Kaydet();
            Console.ReadLine();
        }
    }

    public class YoneticiSinif
    {
        private readonly ILogger _logger;
        private readonly string _mesaj;

        public YoneticiSinif(ILogger logger, string mesaj)
        {
            _logger = logger;
            _mesaj = mesaj;
        }

        public void Kaydet()
        {
            _logger.Log(_mesaj);
        }
    }

    public interface ILogger
    {
        void Log(string mesaj);
    }

    public class XLogger : ILogger
    {
        public void Log(string mesaj)
        {
            Console.WriteLine("XLog Kaydedildi!");
        }
    }

    public class NetLogger
    {
        public void LogMessage(string mesaj)
        {
            Console.WriteLine("LognetMessage" + mesaj);
        }
    }

    public class NetLoggerAdapter : ILogger
    {
        public void Log(string mesaj)
        {
            NetLogger logNet = new NetLogger();
            logNet.LogMessage(mesaj);
        }
    }
}
