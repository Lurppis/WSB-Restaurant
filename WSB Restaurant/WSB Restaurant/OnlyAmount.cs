using System;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class OnlyAmount : Form
    {
        Product product;
        public OnlyAmount()
        {
            InitializeComponent();
        }
        public OnlyAmount(object product)
        {
            InitializeComponent();
            this.product = (Product)product;
        }

        private void btnUp_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.OK;
            product.Count = int.Parse(this.AmountLabel.Text);

            Bucket.Products.Add(product);
            this.Close();
            this.Hide();
        }
    }
}
