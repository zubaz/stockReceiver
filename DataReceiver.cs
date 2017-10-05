using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace stockDataReceiver
{
    public class DataReceiver
    {
        public delegate void StockPriceChangedHandler(StockDetails stock);
        public event StockPriceChangedHandler StockPriceChanged;
        
        private Socket socket;
        private byte[] buffer = new byte[256];

        public void Connect(IPEndPoint endpoint)
        {
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);                   // opens a connection to the server
            socket.BeginConnect(endpoint, ConnectCallback, null);
        }

        public void Close()
        {
            socket.Close();
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                socket.EndConnect(ar);
                Read();                                        // once we're connnected to the server, we can start reading data from the stream
            }
            catch (SocketException e)
            {
                // could not connect for some reason
            }
            catch
            {
                // Something else dark and mysterious is going on.
            }
        }

        private void Read()
        {
            if (socket.Connected)
            {
                buffer = new byte[256];
                try
                {
                    socket.BeginReceive(buffer, 0, 256, SocketFlags.None, ReadCallback, null);               //recives data from the socket stream asynchronously
                }
                catch
                {
                    // Connection was lost somehow. Maybe the server went down.
                    // Nothing we can do.
                    return;
                }
            }
        }

        private void ReadCallback(IAsyncResult ar)
        {
            if (socket.Connected)
            {
                int len = 0;
                try
                {
                    len = socket.EndReceive(ar);
                }
                catch
                {
                    // Connection was lost somehow. Maybe the server went down.
                    // Nothing we can do.
                    return;
                }
                string data = Encoding.UTF8.GetString(buffer, 0, len);

                JavaScriptSerializer json = new JavaScriptSerializer();
                StockDetails stock = json.Deserialize<StockDetails>(data);                      // deserializes the JSON string into a StockDetails object, then raises an event that the form can use.
                StockPriceChanged?.Invoke(stock);

                Read();
            }
        }
    }
}
