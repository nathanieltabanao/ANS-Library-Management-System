using System.Windows.Forms;

namespace ANS_Library_Management_System
{
    public partial class AdminForm : Form
    {
        public AdminForm() => InitializeComponent();

        private void accountsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.MdiParent = this;
            register.Show();
        }
    }
}
