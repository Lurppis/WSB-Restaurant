namespace WSB_Restaurant
{
    using System;
    using System.Windows.Forms;
    using WSB_Restaurant.Model;

    /// <summary>
    /// Defines the <see cref="AddToBucketWithExtra" />
    /// </summary>
    public partial class AddToBucketWithExtra : Form
    {
        /// <summary>
        /// Defines the product
        /// </summary>
        private Product product;

        /// <summary>
        /// Defines the price
        /// </summary>
        private decimal price = 1;

        /// <summary>
        /// Defines the type
        /// </summary>
        private string type;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToBucketWithExtra"/> class.
        /// </summary>
        public AddToBucketWithExtra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddToBucketWithExtra"/> class.
        /// </summary>
        /// <param name="product">The <see cref="object"/></param>
        public AddToBucketWithExtra(object product)
        {
            InitializeComponent();
            this.product = (Product)product;
            label1.Text = this.product.Name;
            label3.Text = this.product.Price.ToString();
            var mediumPrice = ((double)this.product.Price + (double)this.product.Price * 0.25);
            label4.Text = mediumPrice.ToString("0.00");
            var largePrice = ((double)this.product.Price + (double)this.product.Price * 0.45);
            label5.Text = largePrice.ToString("0.00");
            decimal.TryParse(label3.Text, out this.price);
        }

        /// <summary>
        /// The Button1_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button1_Click(object sender, EventArgs e)
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
        /// The Button5_Click
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void Button5_Click(object sender, EventArgs e)
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
            product.Price = price;
            product.Name += " " + type;

            Bucket.Products.Add(product);
            this.Close();
            this.Hide();
        }

        /// <summary>
        /// The RadioButton1_CheckedChanged
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(label3.Text, out this.price);
            type = "small";
        }

        /// <summary>
        /// The RadioButton2_CheckedChanged
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(label4.Text, out this.price);
            type = "medium";
        }

        /// <summary>
        /// The RadioButton3_CheckedChanged
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(label5.Text, out this.price);
            type = "large";
        }
    }
}
