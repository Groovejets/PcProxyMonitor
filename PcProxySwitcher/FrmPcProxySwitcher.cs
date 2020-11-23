using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebProxy;

namespace PcProxySwitcher
{
    public partial class FrmPcProxySwitcher : Form
    {

        #region Private Variables

        private string formatPcProxyStatus = "Computer [ {0} ] proxy server is set to [ {1} ] and it is {2}";
        private List<KeyValuePair<string, string>> webProxyServersList;

        private string thisComputerName = System.Environment.MachineName;
        private string lastProxyServerUri = string.Empty;
        private bool lastProxyEnabledState = false;

        #endregion

        public FrmPcProxySwitcher()
        {
            InitializeComponent();
        }

        #region Private Methods - Form Events

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmPcProxySwitcher_Shown(object sender, EventArgs e)
        {
            InitialiseApplication();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProxySettings();
        }

        #endregion

        #region Private Methods - Application General

        private void InitialiseApplication()
        {
            //TASK: Load the global SkyCity proxy server list
            webProxyServersList = WebProxyHelper.ReturnSkyCityWebProxyServerList();
            
            //TASK: Load the visible proxy list combo with proxy server entries
            InitializeProxyListControl();

            RefreshProxySettings();
        }

        #endregion

        #region Private Methods - Form Data & Update

        private void RefreshProxySettings()
        {
            SetProxyListControl(webProxyServersList, WebProxy.WebProxyHelper.GetProxyServer(), ref lastProxyServerUri);

            SetProxyEnabledStatusControl(ref lastProxyEnabledState);

            SetApplicationProxyStatusString();
        }

        private void InitializeProxyListControl()
        {
            foreach (var proxyServer in webProxyServersList)
            {
                cboWebProxyServers.Items.Add(proxyServer.Key);
            }

            //Initially default to No Proxy
            cboWebProxyServers.SelectedIndex = 0;
        }

        private void SetProxyListControl(List<KeyValuePair<string, string>> proxyList, string proxyUri, ref string lastProxyServerUri)
        {
            foreach(var proxyEntry in proxyList)
            {
                if(proxyEntry.Value.ToLower() == proxyUri.ToLower())
                {
                     cboWebProxyServers.SelectedItem = proxyEntry.Key;
                    lastProxyServerUri = proxyEntry.Value;
                    break;
                }
            }
        }

        private void SetProxyEnabledStatusControl(ref bool lastProxyEnabledState)
        {
            chkIsSelectedProxyEnabled.Checked = WebProxyHelper.IsProxyEnabled();
            lastProxyEnabledState = chkIsSelectedProxyEnabled.Checked;
        }

        private void SetApplicationProxyStatusString()
        {
            string proxyEnabledStateString = "disabled";

            if (lastProxyEnabledState) proxyEnabledStateString = "enabled";
            SetStatus(string.Format(formatPcProxyStatus, thisComputerName, lastProxyServerUri, proxyEnabledStateString));
        }

        private void SetStatus(string status)
        {
            txtProxySwitcherStatus.Text = status;
        }

        private void AppendStatus(string status)
        {
            txtProxySwitcherStatus.Text = txtProxySwitcherStatus.Text + status;
        }

        #endregion
    }
}
