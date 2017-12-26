using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant.Control
{
    public partial class DrinksUserControl1 : UserControl
    {
        public DrinksUserControl1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product iceCream = new Drink("Coca Cola", "IMAGE", "DESCT", 1, 3.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product iceCream = new Drink("Ice Tea", "IMAGE", "DESCT", 1, 3.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product iceCream = new Drink("Sprite", "IMAGE", "DESCT", 1, 3.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }
    }
}
