using Newtonsoft.Json;
using Server.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private List<Order> ListOfOrders = new List<Order>();

        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
            SetupServer();
        }

        private void SetupServer()
        {
            Console.WriteLine("Setting up server..");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(10);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Socket socket = _serverSocket.EndAccept(ar);
            _clientSockets.Add(socket);
            Console.WriteLine("Client connected");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReciveCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void ReciveCallback(IAsyncResult ar)
        {
            var response = "";
            Socket socket = (Socket)ar.AsyncState;
            int recived = socket.EndReceive(ar);
            byte[] dataBuff = new byte[recived];
            Array.Copy(_buffer, dataBuff, recived);

            var result = Encoding.ASCII.GetString(dataBuff);

            if (result != string.Empty)
            {
                var order = Order.FromJson(result);
                Random rnd = new Random();
                order.ID = rnd.Next(0, 100);

                ListOfOrders.Add(order);

                ProductUserControl puc = new ProductUserControl(order.ClientType);
                var prod = "";
                foreach (var item in order.ListOfProducts)
                {
                    prod += item.Name + " (" + item.Count + ")" + Environment.NewLine;
                }
                puc.Update(order.ID.ToString(), prod);
                flowLayoutPanel.Invoke(new Action(() => flowLayoutPanel.Controls.Add(puc)));

                response = JsonConvert.SerializeObject(new
                {
                    order.ID,
                    Response = true
                }, Formatting.None);
            }
            else
            {
                response = JsonConvert.SerializeObject(new
                {     
                    ID = -99,
                    Response = false
                }, Formatting.None);
            }

            byte[] date = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(date, 0, date.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReciveCallback), socket);
        }


        private static void SendCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }
    }
}
