using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class Form1 : Form
    {
        Bucket bucket = new Bucket();
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Form1()
        {
            InitializeComponent();
            SidePanel.Location = bntHome.Location;
            honeUserControl1.BringToFront();
        }

        private void BntHome_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = bntHome.Location;
            honeUserControl1.BringToFront();
            honeUserControl1.Show();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
        }

        private void BtnBoxes_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnBoxes.Location;
            boxesUserControl1.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Show();
            burgerUserControl1.Hide();
        }

        private void BtnBurgers_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnBurgers.Location;
            burgerUserControl1.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Show();
        }

        private void BtnFries_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnFries.Location;
            frenchFriesUserControl1.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Show();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
        }

        private void BtnDrinks_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnDrinks.Location;
            drinksUserControl11.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Show();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
        }

        private void BtnIceCreams_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnIceCreams.Location;
            honeUserControl1.Hide();
            iceCreamUserControl1.Show();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
            iceCreamUserControl1.BringToFront();
        }

        private void BtnPayment_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnPayment.Location;
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();

            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;

            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            var bindingList = new BindingList<Product>(Bucket.Products);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Bucket.Products.Clear();
            var bindingList = new BindingList<Product>(Bucket.Products);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    Console.WriteLine(attempts);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            Console.WriteLine("Connected");
            Send();
        }

        private void Send()
        {
            var JSONData = JsonConvert.SerializeObject(Bucket.Products);
            byte[] buffer = Encoding.ASCII.GetBytes(JSONData);
            _clientSocket.Send(buffer);

            byte[] recivedBuf = new byte[1024];
            int rec = _clientSocket.Receive(recivedBuf);

            byte[] data = new byte[rec];
            Array.Copy(recivedBuf, data, rec);
            Console.WriteLine("Recived: " + Encoding.ASCII.GetString(data));
            var answer = Convert.ToBoolean(Encoding.ASCII.GetString(data));
            if (answer == true)
            {
                //_clientSocket.Close();
                SidePanel.Location = bntHome.Location;
                honeUserControl1.Show();
                honeUserControl1.BringToFront();
                Bucket.Products.Clear();
                MessageBox.Show("THX. Your number is XXX");
            }

            else
            {
                MessageBox.Show("We were not able to send your request");
            }
        }
    }
}
