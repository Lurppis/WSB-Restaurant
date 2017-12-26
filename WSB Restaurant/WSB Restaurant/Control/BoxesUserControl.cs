using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Product box1 = new Box("Chicken Box", "IMAGE", "DESCT", 1, 14.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product box1 = new Box("Nuget Box", "IMAGE", "DESCT", 1, 24.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product box1 = new Box("Extra mix Box", "IMAGE", "DESCT", 1, 32.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }
    }
}
