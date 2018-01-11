namespace WSB_Restaurant
{
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="HomeUserControl" />
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeUserControl"/> class.
        /// </summary>
        public HomeUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Button1_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
        private void Button1_Click(object sender, System.EventArgs e)
        {
            Product wiesmac = new Burger("WiesMac", "IMAGE", "DESCT", 1, 12.99m);
            OnlyAmount om = new OnlyAmount(wiesmac);
            om.Show();
        }
    }
}
