using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using NetworkResolver;
using System.Net.NetworkInformation;

namespace NetworkResolver
{
    public partial class FrmMain : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string MyProxyAddress { get; set; }

     //   public string MyProxyNode { get; set; }
        public string MyProxyPort { get; set; }
        public string EnableListener { get; set; }
        public string currentProxyAddress { get; set; }
        

        public List<string> localIPs;

        public bool isIPStatic;

        private string machineName { get; set; }
        private string userName { get; set; }
        private bool proxyStatus { get; set; }

        private string remoteStatus { get; set; }

        private delegate void EventArgsDelegate(object sender, EventArgs ea);

        public FrmMain()
        {
            InitializeComponent();
            EnableListener = ConfigurationManager.AppSettings["EnableListener"];
            if (Convert.ToBoolean(EnableListener)) NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(AddressChangedCallback);
            NetResolver.EnableRemoteSettings();
            getData();
        }

        void AddressChangedCallback(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventArgsDelegate(AddressChangedCallback), new object[] { sender, e });
                return;
            }

            string MyProxyNode = ConfigurationManager.AppSettings["MyProxyNode"];
            List<string> myIPs = NetResolver.GetLocalIPAddress();

            foreach (string ip in myIPs)
            {
               string  firstThreeOctets = ip.Substring(0, ip.LastIndexOf("."));
                lblLogstuff.Text = "network changed" + ip;
                log.Debug("Network status changed" );

                if (MyProxyNode == firstThreeOctets) // change to current ip address  
                {
                    lblLogstuff.Text = "Proxy enabled " + DateTime.Now;
                    log.Debug("IP on same subnet as Proxy...Enabling Proxy settings");
                    NetResolver.ChangeProxy(MyProxyAddress, Convert.ToInt32(MyProxyPort));
                    NetResolver.EnableProxy();
                    getData();
                    return;
                }
                else
                {
                    lblLogstuff.Text = "disabled at " + DateTime.Now;
                    NetResolver.DisableProxy();
                    getData();
                }
            } 
        }

        public  void getData()
        {
            currentProxyAddress = NetResolver.GetProxyFromRegistry();
            localIPs = null;     
            localIPs = NetResolver.GetLocalIPAddress();
            machineName = Environment.MachineName;
            userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            proxyStatus = NetResolver.CheckIfProxyIsEnabled();
            remoteStatus = NetResolver.CheckIfRemoteIsEnabled().ToString();
            displayData();
        }

        public void displayData()
        {
            lblProxyAddress.Text = currentProxyAddress;
            lblIPAddress.Text = "";
            btnTurnOn.Text = "Turn ON Proxy Settings " + NetResolver.GetConfigSettings("MyProxyAddress") + ":" + NetResolver.GetConfigSettings("MyProxyPort");
            foreach (string ip in localIPs)
            {
                lblIPAddress.Text = lblIPAddress.Text + "   " + ip.ToString();
            }


            lblComputerName.Text = machineName;
            lblUsername.Text = userName;
            lblProxyEnabled.Text = proxyStatus.ToString();

            if (proxyStatus)
            {
                btnTurnOff.Enabled = true;
                btnTurnOn.Enabled = false;
            }
            else
            {
                btnTurnOff.Enabled = false;
                btnTurnOn.Enabled = true;
            }

            lblRemoteDesktop.Text = remoteStatus;
            log.Debug("Refreshed");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            NetResolver.DisableProxy();
            getData();
        }

        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            NetResolver.ChangeProxy(MyProxyAddress, Convert.ToInt32(MyProxyPort));
            NetResolver.EnableProxy();
            getData();
        }
    }
}
