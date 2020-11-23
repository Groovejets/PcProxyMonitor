namespace PcProxySwitcher
{
    partial class FrmPcProxySwitcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbProxySwitcherOptions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkForceSelectedProxy = new System.Windows.Forms.CheckBox();
            this.lblAutoRefreshProxyStatus = new System.Windows.Forms.Label();
            this.chkAutoRefrehProxyStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboWebProxyServers = new System.Windows.Forms.ComboBox();
            this.txtProxySwitcherStatus = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblIsSelectedProxyEnabled = new System.Windows.Forms.Label();
            this.chkIsSelectedProxyEnabled = new System.Windows.Forms.CheckBox();
            this.lblAppStatus = new System.Windows.Forms.Label();
            this.gbProxySwitcherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(567, 350);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(491, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(401, 219);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // gbProxySwitcherOptions
            // 
            this.gbProxySwitcherOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProxySwitcherOptions.Controls.Add(this.lblIsSelectedProxyEnabled);
            this.gbProxySwitcherOptions.Controls.Add(this.chkIsSelectedProxyEnabled);
            this.gbProxySwitcherOptions.Controls.Add(this.btnRefresh);
            this.gbProxySwitcherOptions.Controls.Add(this.label3);
            this.gbProxySwitcherOptions.Controls.Add(this.chkForceSelectedProxy);
            this.gbProxySwitcherOptions.Controls.Add(this.lblAutoRefreshProxyStatus);
            this.gbProxySwitcherOptions.Controls.Add(this.chkAutoRefrehProxyStatus);
            this.gbProxySwitcherOptions.Controls.Add(this.label1);
            this.gbProxySwitcherOptions.Controls.Add(this.cboWebProxyServers);
            this.gbProxySwitcherOptions.Location = new System.Drawing.Point(12, 12);
            this.gbProxySwitcherOptions.Name = "gbProxySwitcherOptions";
            this.gbProxySwitcherOptions.Size = new System.Drawing.Size(554, 190);
            this.gbProxySwitcherOptions.TabIndex = 3;
            this.gbProxySwitcherOptions.TabStop = false;
            this.gbProxySwitcherOptions.Text = "Web Proxy Switcher Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Force Selected Proxy:";
            // 
            // chkForceSelectedProxy
            // 
            this.chkForceSelectedProxy.AutoSize = true;
            this.chkForceSelectedProxy.Location = new System.Drawing.Point(170, 136);
            this.chkForceSelectedProxy.Name = "chkForceSelectedProxy";
            this.chkForceSelectedProxy.Size = new System.Drawing.Size(15, 14);
            this.chkForceSelectedProxy.TabIndex = 5;
            this.chkForceSelectedProxy.UseVisualStyleBackColor = true;
            // 
            // lblAutoRefreshProxyStatus
            // 
            this.lblAutoRefreshProxyStatus.AutoSize = true;
            this.lblAutoRefreshProxyStatus.Location = new System.Drawing.Point(10, 101);
            this.lblAutoRefreshProxyStatus.Name = "lblAutoRefreshProxyStatus";
            this.lblAutoRefreshProxyStatus.Size = new System.Drawing.Size(134, 13);
            this.lblAutoRefreshProxyStatus.TabIndex = 4;
            this.lblAutoRefreshProxyStatus.Text = "Auto Refresh Proxy Status:";
            // 
            // chkAutoRefrehProxyStatus
            // 
            this.chkAutoRefrehProxyStatus.AutoSize = true;
            this.chkAutoRefrehProxyStatus.Location = new System.Drawing.Point(170, 101);
            this.chkAutoRefrehProxyStatus.Name = "chkAutoRefrehProxyStatus";
            this.chkAutoRefrehProxyStatus.Size = new System.Drawing.Size(15, 14);
            this.chkAutoRefrehProxyStatus.TabIndex = 3;
            this.chkAutoRefrehProxyStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current PC Web Proxy:";
            // 
            // cboWebProxyServers
            // 
            this.cboWebProxyServers.FormattingEnabled = true;
            this.cboWebProxyServers.Location = new System.Drawing.Point(170, 28);
            this.cboWebProxyServers.Name = "cboWebProxyServers";
            this.cboWebProxyServers.Size = new System.Drawing.Size(368, 21);
            this.cboWebProxyServers.TabIndex = 1;
            // 
            // txtProxySwitcherStatus
            // 
            this.txtProxySwitcherStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxySwitcherStatus.Location = new System.Drawing.Point(12, 259);
            this.txtProxySwitcherStatus.Name = "txtProxySwitcherStatus";
            this.txtProxySwitcherStatus.ReadOnly = true;
            this.txtProxySwitcherStatus.Size = new System.Drawing.Size(554, 20);
            this.txtProxySwitcherStatus.TabIndex = 0;
            this.txtProxySwitcherStatus.Text = "None";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(463, 151);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblIsSelectedProxyEnabled
            // 
            this.lblIsSelectedProxyEnabled.AutoSize = true;
            this.lblIsSelectedProxyEnabled.Location = new System.Drawing.Point(4, 68);
            this.lblIsSelectedProxyEnabled.Name = "lblIsSelectedProxyEnabled";
            this.lblIsSelectedProxyEnabled.Size = new System.Drawing.Size(140, 13);
            this.lblIsSelectedProxyEnabled.TabIndex = 9;
            this.lblIsSelectedProxyEnabled.Text = "Is Selected Proxy Enabled?:";
            // 
            // chkIsSelectedProxyEnabled
            // 
            this.chkIsSelectedProxyEnabled.AutoSize = true;
            this.chkIsSelectedProxyEnabled.Location = new System.Drawing.Point(170, 68);
            this.chkIsSelectedProxyEnabled.Name = "chkIsSelectedProxyEnabled";
            this.chkIsSelectedProxyEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkIsSelectedProxyEnabled.TabIndex = 8;
            this.chkIsSelectedProxyEnabled.UseVisualStyleBackColor = true;
            // 
            // lblAppStatus
            // 
            this.lblAppStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAppStatus.AutoSize = true;
            this.lblAppStatus.Location = new System.Drawing.Point(13, 240);
            this.lblAppStatus.Name = "lblAppStatus";
            this.lblAppStatus.Size = new System.Drawing.Size(40, 13);
            this.lblAppStatus.TabIndex = 4;
            this.lblAppStatus.Text = "Status:";
            // 
            // FrmPcProxySwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 291);
            this.ControlBox = false;
            this.Controls.Add(this.lblAppStatus);
            this.Controls.Add(this.gbProxySwitcherOptions);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtProxySwitcherStatus);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPcProxySwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Web Proxy Switcher";
            this.Shown += new System.EventHandler(this.frmPcProxySwitcher_Shown);
            this.gbProxySwitcherOptions.ResumeLayout(false);
            this.gbProxySwitcherOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbProxySwitcherOptions;
        private System.Windows.Forms.TextBox txtProxySwitcherStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkForceSelectedProxy;
        private System.Windows.Forms.Label lblAutoRefreshProxyStatus;
        private System.Windows.Forms.CheckBox chkAutoRefrehProxyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboWebProxyServers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblIsSelectedProxyEnabled;
        private System.Windows.Forms.CheckBox chkIsSelectedProxyEnabled;
        private System.Windows.Forms.Label lblAppStatus;
    }
}

