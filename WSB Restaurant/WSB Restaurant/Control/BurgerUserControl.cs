namespace WSB_Restaurant
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="BurgerUserControl" />
    /// </summary>
    public partial class BurgerUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BurgerUserControl"/> class.
        /// </summary>
        public BurgerUserControl()
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
            Product hamburger = new Burger("Hamburger", "IMAGE", "DESCT", 1, 8.99m);
            OnlyAmount om = new OnlyAmount(hamburger);
            om.Show();
        }

        /// <summary>
        /// The Button2_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Product hambucheeseburgerrger = new Burger("Cheeseburger", "IMAGE", "DESCT", 1, 8.99m);
            OnlyAmount om = new OnlyAmount(hambucheeseburgerrger);
            om.Show();
        }
    }
}
