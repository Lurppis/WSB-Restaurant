namespace Server
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="ProductUserControl" />
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUserControl"/> class.
        /// </summary>
        /// <param name="clientType">The <see cref="string"/></param>
        public ProductUserControl(string clientType)
        {
            if (clientType == "Local")
                this.BackColor = Color.DeepSkyBlue;
            else
                this.BackColor = Color.GreenYellow;
            InitializeComponent();
        }

        /// <summary>
        /// The Button1_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="System.EventArgs"/></param>
        private void Button1_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <param name="dec">The <see cref="string"/></param>
        public void Update(string name, string dec)
        {
            this.label1.Text = name;
            this.textBox1.Text = dec;
        }
    }
}
