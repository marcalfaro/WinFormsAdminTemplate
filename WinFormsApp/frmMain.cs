using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnMenuBar_Click(object sender, EventArgs e)
        {
            toggleLeftPane();                      
        }


        private void toggleLeftPane()
        {
            bool shrink = (pnlLeft.Width == 310) ? true : false;

            foreach (Control c in pnlLeft.Controls)
            {
                if (c is Button btn)
                {
                    btn.Text = shrink ? string.Empty: btn.Tag!.ToString();
                }
            }

            btnLogoSmall.ImageAlign = shrink ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            btnLogoSmall.Text = shrink ? string.Empty : btnLogoSmall.Tag!.ToString();
            btnLogoSmall.Padding = shrink ? new Padding(0): new Padding(20,0,0,0);
            pnlLeft.Width = shrink ? 100 : 310;
        }




    }
}