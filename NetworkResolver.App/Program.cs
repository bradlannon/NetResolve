using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;







[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace NetworkResolver
{

    static class Program
    {

        private static ILog log = LogManager.GetLogger(typeof(Program));



 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
