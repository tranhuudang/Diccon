using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class release : Form
    {
        public release()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void release_Load(object sender, System.EventArgs e)
        {
            topPanel.BackColor = DicconProp.AccentColor;

        }
    }
}
