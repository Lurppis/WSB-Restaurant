using System.Windows.Forms;

namespace WSB_Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = bntHome.Height;
            honeUserControl1.BringToFront();

        }

        private void bntHome_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = bntHome.Height;
            honeUserControl1.BringToFront();
        }
    }
}
