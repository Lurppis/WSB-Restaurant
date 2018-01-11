namespace WSB_Restaurant.Control
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="DrinksUserControl1" />
    /// </summary>
    public partial class DrinksUserControl1 : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrinksUserControl1"/> class.
        /// </summary>
        public DrinksUserControl1()
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
            Product iceCream = new Drink("Coca Cola", "IMAGE", "DESCT", 1, 3.99m);
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
            Product iceCream = new Drink("Ice Tea", "IMAGE", "DESCT", 1, 3.99m);
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
            Product iceCream = new Drink("Sprite", "IMAGE", "DESCT", 1, 3.99m);
            AddToBucketWithExtra addToBucketWithExtra = new AddToBucketWithExtra(iceCream);
            addToBucketWithExtra.Show();
        }
    }
}
