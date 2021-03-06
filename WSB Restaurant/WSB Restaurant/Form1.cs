﻿namespace WSB_Restaurant
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="Form1" />
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Defines the bucket
        /// </summary>
        public Bucket bucket = new Bucket();

        /// <summary>
        /// Defines the _clientSocket
        /// </summary>
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            SidePanel.Location = bntHome.Location;
            honeUserControl1.BringToFront();
        }

        /// <summary>
        /// The BntHome_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The BtnBoxes_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The BtnBurgers_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The BtnFries_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The BtnDrinks_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The BtnIceCreams_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The BtnPayment_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
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

        /// <summary>
        /// The Button2_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
        private void Button2_Click(object sender, System.EventArgs e)
        {
            Bucket.Products.Clear();
            var bindingList = new BindingList<Product>(Bucket.Products);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        /// <summary>
        /// The Button3_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
        private void Button3_Click(object sender, System.EventArgs e)
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
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            Console.WriteLine("Connected");
            Send();
        }

        /// <summary>
        /// The Send
        /// </summary>
        private void Send()
        {
            var result = JsonConvert.SerializeObject(new
            {
                ClientType = Bucket.Type,
                ListOfProducts = Bucket.Products
            }, Formatting.None);

            byte[] buffer = Encoding.ASCII.GetBytes(result);
            _clientSocket.Send(buffer);

            byte[] recivedBuf = new byte[1024];
            int rec = _clientSocket.Receive(recivedBuf);

            byte[] data = new byte[rec];
            Array.Copy(recivedBuf, data, rec);
            var answer = Encoding.ASCII.GetString(data);

            var dataRecived = OrderDetails.FromJson(Encoding.ASCII.GetString(data));

            if (dataRecived.Response == true)
            {
                SidePanel.Location = bntHome.Location;
                honeUserControl1.Show();
                honeUserControl1.BringToFront();
                Bucket.Products.Clear();
                MessageBox.Show("Your order number is " + dataRecived.Number);
            }

            else
            {
                MessageBox.Show("We were not able to send your request");
            }
        }
    }
}
