using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class Form1 : Form
    {
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
        }

        private void btnBoxes_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnBoxes.Location;
            boxesUserControl1.BringToFront();
        }

        private void btnBurgers_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnBurgers.Location;
            burgerUserControl1.BringToFront();
        }

        private void btnFries_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnFries.Location;
            frenchFriesUserControl1.BringToFront();
        }

        private void btnDrinks_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnDrinks.Location;
            drinksUserControl11.BringToFront();
        }

        private void btnIceCreams_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnIceCreams.Location;
            iceCreamUserControl1.BringToFront();
        }

        private void btnPayment_Click(object sender, System.EventArgs e)
        {
            SidePanel.Location = btnPayment.Location;
            purchaseUserControl1.BringToFront();
        }
    }
}
