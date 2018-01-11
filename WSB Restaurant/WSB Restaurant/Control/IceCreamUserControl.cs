namespace WSB_Restaurant.Control
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="IceCreamUserControl" />
    /// </summary>
    public partial class IceCreamUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IceCreamUserControl"/> class.
        /// </summary>
        public IceCreamUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Button1_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Product iceCream = new IceCream("Chocolte Crunch", "IMAGE", "DESCT", 1, 3.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }

        /// <summary>
        /// The Button2_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Product iceCream = new IceCream("Speciuloos", "IMAGE", "DESCT", 1, 5.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }

        /// <summary>
        /// The Button3_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            Product iceCream = new IceCream("McFlurry Fruits", "IMAGE", "DESCT", 1, 4.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }
    }
}
