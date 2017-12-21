using System.Windows.Forms;

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
    }
}
