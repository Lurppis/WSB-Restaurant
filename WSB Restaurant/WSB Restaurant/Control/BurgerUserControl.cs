using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class BurgerUserControl : UserControl
    {
        public BurgerUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product hamburger = new Burger("Hamburger", "IMAGE", "DESCT", 1, 8.99m);
            OnlyAmount om = new OnlyAmount(hamburger);
            om.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product hambucheeseburgerrger = new Burger("Cheeseburger", "IMAGE", "DESCT", 1, 8.99m);
            OnlyAmount om = new OnlyAmount(hambucheeseburgerrger);
            om.Show();
        }
    }
}
