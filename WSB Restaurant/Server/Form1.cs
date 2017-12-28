using Newtonsoft.Json;
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
            _serverSocket.Listen(1);
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

        private static void ReciveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int recived = socket.EndReceive(ar);
            byte[] dataBuff = new byte[recived];
            Array.Copy(_buffer, dataBuff, recived);

            var result = Encoding.ASCII.GetString(dataBuff);
            Console.WriteLine("Text recived: " + result);

            dynamic jsonObj = JsonConvert.DeserializeObject(result);
            foreach (var item in jsonObj.ListOfProducts)
            {
                Console.WriteLine(item.Name);
            }

            var response = false;
            var response2 = "";

            if(result != string.Empty)
            {
                response = true;

                //Add order number.
            }
            else
            {
                response = false;
            }

            byte[] date = Encoding.ASCII.GetBytes(response.ToString());
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
