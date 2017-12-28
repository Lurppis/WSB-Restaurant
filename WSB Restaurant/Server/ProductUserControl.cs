using System.Windows.Forms;

namespace Server
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {

        }

        public void Update(string name, string dec, int count)
        {
            this.label1.Text = name;
            this.label2.Text = count.ToString();
            this.textBox1.Text = dec;
        }
    }
}
