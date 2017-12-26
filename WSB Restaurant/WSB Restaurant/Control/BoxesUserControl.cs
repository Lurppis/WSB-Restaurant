using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class BoxesUserControl : UserControl
    {
        public BoxesUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product box1 = new Box("Chicken Box", "IMAGE", "DESCT", 1, 14.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product box1 = new Box("Nuget Box", "IMAGE", "DESCT", 1, 24.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product box1 = new Box("Extra mix Box", "IMAGE", "DESCT", 1, 32.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }
    }
}
