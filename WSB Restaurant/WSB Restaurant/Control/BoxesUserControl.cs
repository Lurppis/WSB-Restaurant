namespace WSB_Restaurant
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="BoxesUserControl" />
    /// </summary>
    public partial class BoxesUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxesUserControl"/> class.
        /// </summary>
        public BoxesUserControl()
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
            Product box1 = new Box("Chicken Box", "IMAGE", "DESCT", 1, 14.99m);
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
            Product box1 = new Box("Nuget Box", "IMAGE", "DESCT", 1, 24.99m);
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
            Product box1 = new Box("Extra mix Box", "IMAGE", "DESCT", 1, 32.99m);
            OnlyAmount om = new OnlyAmount(box1);
            om.Show();
        }
    }
}
