using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class ClientType : Form
    {
        public ClientType()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Bucket.Type = "Drive";
            form.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Bucket.Type = "Local";
            form.Show();
            this.Hide();
        }
    }
}
