using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant.Control
{
    public partial class frenchFriesUserControl : UserControl
    {
        public frenchFriesUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product box1 = new Fries("Small fries", "IMAGE", "DESCT", 1, 3.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product box1 = new Fries("Medium fries", "IMAGE", "DESCT", 1, 4.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product box1 = new Fries("Large fries", "IMAGE", "DESCT", 1, 5.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }
    }
}
