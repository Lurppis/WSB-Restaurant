using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class AddToBucketWithExtra : Form
    {
        private Product product;
        private decimal price = 1;

        public AddToBucketWithExtra()
        {
            InitializeComponent();
        }

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

        private void Button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.AmountLabel.Text);
            number++;
            this.AmountLabel.Text = number.ToString();
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.AmountLabel.Text);
            if (number > 1)
                number--;
            this.AmountLabel.Text = number.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            product.Count = int.Parse(this.AmountLabel.Text);
            product.Price = price;

            Bucket.Products.Add(product);
            this.Close();
            this.Hide();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(label3.Text, out this.price);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(label4.Text, out this.price);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(label5.Text, out this.price);
        }
    }
}
