using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace stockDataReceiver
{ 
    public partial class Form1 : Form
    {
        private string filter = "";
        private int updateCount = 0;
        DataReceiver dataReceiver = new DataReceiver();

        public Form1()
        {
            InitializeComponent();
            string hostName = Dns.GetHostName();
            IPHostEntry ipInfo = Dns.GetHostEntry(hostName);

            foreach (IPAddress ip in ipInfo.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    tbIP.Text = ip.ToString();
                }
            }

            dataReceiver.StockPriceChanged += DataReceiver_StockPriceChanged;
        }

        private void DataReceiver_StockPriceChanged(StockDetails stock)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { DataReceiver_StockPriceChanged(stock); }));
            }
            else
            {
                lbUpdate.Text = (++updateCount).ToString();
                lbTUpdate.Text = DateTime.Now.ToString();

                bool found = false;

                foreach(DataGridViewRow row in dataGprice.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == stock.StockName)
                    {
                        row.Cells[1].Value = stock.StockPrice.ToString("#.##");
                        row.Cells[2].Value = stock.StockChange.ToString("#.##");
                        found = true;
                    }
                }

                if (!found)
                {
                    if ((filter == "") || (filter != "" && filter == stock.StockName))
                    {
                        dataGprice.Rows.Add(stock.StockName, stock.StockPrice.ToString("#.##"), stock.StockChange.ToString("#.##"));
                    }
                }
            }
        }

        private void bTPLcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            dataReceiver.Connect(new IPEndPoint(IPAddress.Parse(tbIP.Text), Convert.ToInt16(tbPort.Text)));
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;

            dataReceiver.Close();
            dataGprice.Rows.Clear();
        }

        private void bTPLcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            filter = ((ToolStripMenuItem)sender).Text;
            dataGprice.Rows.Clear();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = "";
            dataGprice.Rows.Clear();
        }
    }
}
