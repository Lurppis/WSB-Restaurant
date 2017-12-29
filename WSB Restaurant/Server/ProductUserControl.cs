using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(string clientType)
        {
            if (clientType == "Local")
                this.BackColor = Color.DeepSkyBlue;
            else
                this.BackColor = Color.GreenYellow;
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        public void Update(string name, string dec)
        {
            this.label1.Text = name;
            this.textBox1.Text = dec;
        }
    }
}
