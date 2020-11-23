using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WebProxy
{
    public static class WebProxyHelper
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        public static void SetProxyServer(string proxyhost)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            Registry.SetValue(keyName, "ProxyServer", proxyhost);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public static void SetProxyState(bool enabledState)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;
            Int32 proxyEnabled = 0;

            if (enabledState)
            {
                proxyEnabled = 1;
            }

            Registry.SetValue(keyName, "ProxyEnable", proxyEnabled);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public static void SetProxy(string proxyhost, bool proxyEnabled)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            Registry.SetValue(keyName, "ProxyServer", proxyhost);
            Registry.SetValue(keyName, "ProxyEnable", proxyEnabled ? "1" : "0");

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public static string GetProxyServer()
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            string proxyServerString = (string)Registry.GetValue(keyName, "ProxyServer", String.Empty);

            //TASK: Do a quick simple string cleanup
            proxyServerString = proxyServerString.Replace(" ", string.Empty);
            proxyServerString = proxyServerString.ToLower();
            return proxyServerString;
        }

        public static bool IsProxyEnabled()
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            var proxyStatus = (Int32)Registry.GetValue(keyName, "ProxyEnable", 0);
            if (proxyStatus == 0) return false;

            return true;
        }

        public static List<KeyValuePair<string, string>> ReturnSkyCityWebProxyServerList()
        {
            var webProxyList = new List<KeyValuePair<string, string>>();
            webProxyList.Add(new KeyValuePair<string, string>("No Proxy", "none"));
            webProxyList.Add(new KeyValuePair<string, string>("Auckland Proxy", "aklproxy.sceg.com:8080"));
            webProxyList.Add(new KeyValuePair<string, string>("Server Proxy", "srvproxygw.sceg.com:8080"));
            return webProxyList;
        }
    }
}