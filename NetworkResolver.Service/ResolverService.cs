using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using NetworkResolver;
using System.Net.NetworkInformation;
using System.Configuration;

namespace NetworkResolver
{
    public partial class ResolverService : ServiceBase
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string VesselProxyAddress { get; set; }

        //   public string VesselProxyNode { get; set; }
        public string VesselProxyPort { get; set; }
        public string EnableListener { get; set; }
        public string currentProxyAddress { get; set; }

        public List<string> localIPs;

        public bool isIPStatic;

        private string machineName { get; set; }
        private string userName { get; set; }
        private bool proxyStatus { get; set; }

        private string remoteStatus { get; set; }

        private delegate void EventArgsDelegate(object sender, EventArgs ea);

        public ResolverService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                log.Debug("Starting Service");
                NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(AddressChangedCallback);
                NetResolver.EnableRemoteSettings();
                getData();
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }

        }

        protected override void OnStop()
        {
            log.Debug("Stopping Service");
        }

        void AddressChangedCallback(object sender, EventArgs e)
        {
            try
            {
                log.Debug("AddressChangedCallback");
                string VesselProxyNode = ConfigurationManager.AppSettings["VesselProxyNode"];
                List<string> myIPs = NetResolver.GetLocalIPAddress();

                foreach (string ip in myIPs)
                {
                    string firstThreeOctets = ip.Substring(0, ip.LastIndexOf("."));

                    if (VesselProxyNode == firstThreeOctets) // change to current ip address  
                    {
                        log.Debug("IP on same subnet as Proxy...Enabling Proxy settings at " + DateTime.Now);
                        NetResolver.ChangeProxy(VesselProxyAddress, Convert.ToInt32(VesselProxyPort));
                        NetResolver.EnableProxy();
                        //   getData();
                        return;
                    }
                    else
                    {
                        log.Debug("Disabling Proxy at " + DateTime.Now);
                        NetResolver.DisableProxy();
                        //  getData();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            
        }

        public void getData()
        {
            try
            {
                log.Debug("Getting Data");
                currentProxyAddress = NetResolver.GetProxyFromRegistry();
                localIPs = null;

                localIPs = NetResolver.GetLocalIPAddress();

                machineName = Environment.MachineName;
                userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                proxyStatus = NetResolver.CheckIfProxyIsEnabled();

                remoteStatus = NetResolver.CheckIfRemoteIsEnabled().ToString();
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }         
        }
    }
}
