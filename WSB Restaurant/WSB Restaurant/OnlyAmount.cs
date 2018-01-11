namespace WSB_Restaurant
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="OnlyAmount" />
    /// </summary>
    public partial class OnlyAmount : Form
    {
        /// <summary>
        /// Defines the product
        /// </summary>
        public Product product;

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlyAmount"/> class.
        /// </summary>
        public OnlyAmount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlyAmount"/> class.
        /// </summary>
        /// <param name="product">The <see cref="object"/></param>
        public OnlyAmount(object product)
        {
            InitializeComponent();
            this.product = (Product)product;
            this.label1.Text = this.product.Name;
        }

        /// <summary>
        /// The BtnUp_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void BtnUp_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.AmountLabel.Text);
            number++;
            this.AmountLabel.Text = number.ToString();
        }

        /// <summary>
        /// The BtnDown_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void BtnDown_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.AmountLabel.Text);
            if (number > 1)
                number--;
            this.AmountLabel.Text = number.ToString();
        }

        /// <summary>
        /// The Button4_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// The Button3_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            product.Count = int.Parse(this.AmountLabel.Text);

            Bucket.Products.Add(product);
            this.Close();
            this.Hide();
        }
    }
}
