using System.Windows.Forms;
using WSB_Restaurant.Model;

namespace WSB_Restaurant
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Product wiesmac = new Burger("WiesMac", "IMAGE", "DESCT", 1, 12.99m);
            OnlyAmount om = new OnlyAmount(wiesmac);
            om.Show();
        }
    }
}
