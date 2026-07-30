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
    public partial class Login : Form
    {
        public static string cPwd;
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = "Admin";
            string pwd = "1234";
            string txtUser = UserName.Text;
            string txtPwd = Password.Text;

            if (txtUser == User & txtPwd == pwd)
            {
                MessageBox.Show("Successfully loged in");
                //after successful it will redirect  to next page .  
                Welcome index = new Welcome();
                cPwd = pwd;
                index.Show();

                Hide(); // Hide the current form
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
