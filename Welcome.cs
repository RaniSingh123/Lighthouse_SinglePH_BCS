using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LH_RnD_New
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel1.Controls.Count > 0)
            { 
                this.mainPanel1.Controls.RemoveAt(0);
             }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel1.Controls.Add(f);
            this.mainPanel1.Tag=f;
            f.Show();

            
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDlms_Click(object sender, EventArgs e)
        {
            loadForm(new panelDLMS());
        }

        private void btnPrepay_Click(object sender, EventArgs e)
        {
            loadForm(new panelPrepay());
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            loadForm(new panelTimer());
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            loadForm(new panelModule());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

    }
}
