namespace WSB_Restaurant.Control
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="frenchFriesUserControl" />
    /// </summary>
    public partial class frenchFriesUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frenchFriesUserControl"/> class.
        /// </summary>
        public frenchFriesUserControl()
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
            Product box1 = new Fries("Small fries", "IMAGE", "DESCT", 1, 3.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        /// <summary>
        /// The Button2_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Product box1 = new Fries("Medium fries", "IMAGE", "DESCT", 1, 4.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }

        /// <summary>
        /// The Button3_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            Product box1 = new Fries("Large fries", "IMAGE", "DESCT", 1, 5.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }
    }
}
