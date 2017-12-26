using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant.Control
{
    public partial class IceCreamUserControl : UserControl
    {
        public IceCreamUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product iceCream = new IceCream("Chocolte Crunch", "IMAGE", "DESCT", 1, 3.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Product iceCream = new IceCream("Speciuloos", "IMAGE", "DESCT", 1, 5.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product iceCream = new IceCream("McFlurry Fruits", "IMAGE", "DESCT", 1, 4.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }
    }
}
