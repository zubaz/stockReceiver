namespace stockDataReceiver
{
    partial class Form1
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.dataGprice = new System.Windows.Forms.DataGridView();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Changes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lbTUpdate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTPLcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEASystemsPlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intertekGroupPlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbConnection.SuspendLayout();
            this.gbPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGprice)).BeginInit();
            this.gbSummary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.tbPort);
            this.gbConnection.Controls.Add(this.tbIP);
            this.gbConnection.Controls.Add(this.btnDisconnect);
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.lbPort);
            this.gbConnection.Controls.Add(this.lbIP);
            this.gbConnection.Location = new System.Drawing.Point(13, 41);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(547, 64);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(226, 22);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 5;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(70, 22);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 4;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(455, 18);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(360, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(194, 25);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 13);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port:";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(7, 25);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(61, 13);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP Address:";
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.dataGprice);
            this.gbPrice.Location = new System.Drawing.Point(13, 132);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(547, 208);
            this.gbPrice.TabIndex = 1;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Current Prices:";
            // 
            // dataGprice
            // 
            this.dataGprice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGprice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.Price,
            this.Changes});
            this.dataGprice.Location = new System.Drawing.Point(10, 19);
            this.dataGprice.Name = "dataGprice";
            this.dataGprice.Size = new System.Drawing.Size(524, 183);
            this.dataGprice.TabIndex = 0;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 160;
            // 
            // Price
            // 
            this.Price.HeaderText = "price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 160;
            // 
            // Changes
            // 
            this.Changes.HeaderText = "Changes";
            this.Changes.Name = "Changes";
            this.Changes.ReadOnly = true;
            this.Changes.Width = 160;
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lbTUpdate);
            this.gbSummary.Controls.Add(this.lbTime);
            this.gbSummary.Controls.Add(this.lbUpdate);
            this.gbSummary.Controls.Add(this.lbReceived);
            this.gbSummary.Location = new System.Drawing.Point(17, 372);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(543, 80);
            this.gbSummary.TabIndex = 2;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Connection Summary:";
            // 
            // lbTUpdate
            // 
            this.lbTUpdate.AutoSize = true;
            this.lbTUpdate.Location = new System.Drawing.Point(403, 33);
            this.lbTUpdate.Name = "lbTUpdate";
            this.lbTUpdate.Size = new System.Drawing.Size(0, 13);
            this.lbTUpdate.TabIndex = 3;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(278, 33);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(106, 13);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Time of Last Update:";
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(179, 33);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(0, 13);
            this.lbUpdate.TabIndex = 1;
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Location = new System.Drawing.Point(21, 34);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(151, 13);
            this.lbReceived.TabIndex = 0;
            this.lbReceived.Text = "Number of Updates Received:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectDataToolStripMenuItem
            // 
            this.selectDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.bTPLcToolStripMenuItem,
            this.hSBCToolStripMenuItem,
            this.adToolStripMenuItem,
            this.bEASystemsPlcToolStripMenuItem,
            this.intertekGroupPlcToolStripMenuItem});
            this.selectDataToolStripMenuItem.Name = "selectDataToolStripMenuItem";
            this.selectDataToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.selectDataToolStripMenuItem.Text = "Select Data";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // bTPLcToolStripMenuItem
            // 
            this.bTPLcToolStripMenuItem.Name = "bTPLcToolStripMenuItem";
            this.bTPLcToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bTPLcToolStripMenuItem.Text = "BT Plc";
            this.bTPLcToolStripMenuItem.Click += new System.EventHandler(this.bTPLcToolStripMenuItem_Click_1);
            // 
            // hSBCToolStripMenuItem
            // 
            this.hSBCToolStripMenuItem.Name = "hSBCToolStripMenuItem";
            this.hSBCToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.hSBCToolStripMenuItem.Text = "HSBC holdings Plc";
            this.hSBCToolStripMenuItem.Click += new System.EventHandler(this.bTPLcToolStripMenuItem_Click_1);
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.adToolStripMenuItem.Text = "Admiral Group";
            this.adToolStripMenuItem.Click += new System.EventHandler(this.bTPLcToolStripMenuItem_Click_1);
            // 
            // bEASystemsPlcToolStripMenuItem
            // 
            this.bEASystemsPlcToolStripMenuItem.Name = "bEASystemsPlcToolStripMenuItem";
            this.bEASystemsPlcToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bEASystemsPlcToolStripMenuItem.Text = "BAE Systems Plc";
            this.bEASystemsPlcToolStripMenuItem.Click += new System.EventHandler(this.bTPLcToolStripMenuItem_Click_1);
            // 
            // intertekGroupPlcToolStripMenuItem
            // 
            this.intertekGroupPlcToolStripMenuItem.Name = "intertekGroupPlcToolStripMenuItem";
            this.intertekGroupPlcToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.intertekGroupPlcToolStripMenuItem.Text = "Intertek Group Plc";
            this.intertekGroupPlcToolStripMenuItem.Click += new System.EventHandler(this.bTPLcToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 458);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stock Receiver";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGprice)).EndInit();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bTPLcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSBCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEASystemsPlcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intertekGroupPlcToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbTUpdate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.DataGridView dataGprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Changes;
    }
}

