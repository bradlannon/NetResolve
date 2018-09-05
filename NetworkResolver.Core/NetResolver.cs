using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


using System.Runtime.InteropServices;
using Microsoft.Win32;



namespace NetworkResolver
{
    public class NetResolver
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        bool settingsReturn, refreshReturn;


        public static void asdf()
        {
            /*
            Registry.SetValue("ProxyServer", "10.100.0.254:3128");
            Registry.SetValue("ProxyEnable", 1);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update

            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            */
        }

        public static void EnableProxy()
        {
            try {
                const string userRoot = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";    
                Registry.SetValue(userRoot, "ProxyEnable", 1);
                Registry.SetValue(userRoot, "ProxyOverride", "<local>");
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }     
        }

        public static void DisableProxy()
        {
            try
            {
                const string userRoot = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
                Registry.SetValue(userRoot, "ProxyEnable", 0);
                Registry.SetValue(userRoot, "ProxyOverride", "<local>");
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }     
        }

        public static bool CheckIfProxyIsEnabled()
        {
            try
            {
                const string keyName = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
                int isEnabled = (int)Registry.GetValue(keyName, "ProxyEnable", "No Proxy Set");
                if (isEnabled == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                return false;
            }
        }

        public static void EnableRemoteSettings()
        {
            try
            {
                const string userRoot = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server";
                const string subkey = "fDenyTSConnections";
                Registry.SetValue(userRoot, subkey, 0);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        public static string GetProxyFromRegistry()
        {
            try
            {
                const string keyName = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
                string proxyAddress = (string)Microsoft.Win32.Registry.GetValue(keyName, "ProxyServer", "No Proxy Set");

                return proxyAddress;
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                return "";
            }
        }

        public static void ChangeProxy(string newAddress, int newPort)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("[ultimate destination of your request]");
                WebProxy myproxy = new WebProxy(newAddress, newPort);
                myproxy.BypassProxyOnLocal = false;
                request.Proxy = myproxy;
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        public static bool CheckIfRemoteIsEnabled()
        {
            try
            {
                const string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server";
                int isEnabled = (int)Registry.GetValue(keyName, "fDenyTSConnections", "No Remote Options");
                if (isEnabled == 0)  // 0 is enabled
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetConfigSettings(string settingName)
        {
            string settingVal = System.Configuration.ConfigurationManager.AppSettings[settingName];
            return settingVal;
        }

        public static List<string> GetLocalIPAddress()
        {
            try
            {
                 var host = Dns.GetHostEntry(Dns.GetHostName());
                 List<string> myIPs = new List<string>();
                 foreach (var ip in host.AddressList)
                 {
                     if (ip.AddressFamily == AddressFamily.InterNetwork)
                     {
                         myIPs.Add(ip.ToString());
                     }
                 }
                List<string> ipList = new List<string> { "AdditionalCardPersonAdressType", /* rest of elements */ };
                return myIPs;
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                return new List<string> { "List" };
            }
        }

        public static void CloseProcesses()
        {
            try
            {
                Process[] AllProcesses = Process.GetProcesses();
                foreach (var process in AllProcesses)
                {
                    if (process.MainWindowTitle != "")
                    {
                        string s = process.ProcessName.ToLower();
                        if (s == "iexplore" || s == "iexplorer" || s == "chrome" || s == "firefox")
                        {
                            process.Kill();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }
    }
}
