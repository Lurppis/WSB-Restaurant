namespace WSB_Restaurant
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="ClientType" />
    /// </summary>
    public partial class ClientType : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientType"/> class.
        /// </summary>
        public ClientType()
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
            Form1 form = new Form1();
            Bucket.Type = "Drive";
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// The Button2_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Bucket.Type = "Local";
            form.Show();
            this.Hide();
        }
    }
}
