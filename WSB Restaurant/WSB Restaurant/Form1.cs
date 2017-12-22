using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class Form1 : Form
    {
        Bucket bucket = new Bucket();
        public Form1()
        {
            InitializeComponent();
            SidePanel.Location = bntHome.Location;
            honeUserControl1.BringToFront();
        }

        private void bntHome_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = bntHome.Location;
            honeUserControl1.BringToFront();
            honeUserControl1.Show();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
        }

        private void btnBoxes_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnBoxes.Location;
            boxesUserControl1.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Show();
            burgerUserControl1.Hide();
        }

        private void btnBurgers_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnBurgers.Location;
            burgerUserControl1.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Show();
        }

        private void btnFries_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnFries.Location;
            frenchFriesUserControl1.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Show();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
        }

        private void btnDrinks_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnDrinks.Location;
            drinksUserControl11.BringToFront();
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Show();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
        }

        private void btnIceCreams_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnIceCreams.Location;
            honeUserControl1.Hide();
            iceCreamUserControl1.Show();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();
            iceCreamUserControl1.BringToFront();
        }

        private void btnPayment_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnPayment.Location;
            honeUserControl1.Hide();
            iceCreamUserControl1.Hide();
            drinksUserControl11.Hide();
            frenchFriesUserControl1.Hide();
            boxesUserControl1.Hide();
            burgerUserControl1.Hide();

            // Dummy data
            var bindingList = new BindingList<Product>(bucket.Products);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
