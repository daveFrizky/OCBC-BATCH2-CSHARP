using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesi7
{
    public partial class FrmLogin : Form
    {
        Config db = new Config();
        public FrmLogin()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("select * from user_info where username='"+tbUsername.Text+"' and password='"+tbPassword.Text+"'");
            if (db.Count()==1)
            {
                MessageBox.Show("Success You will login as "+db.Results(0,"names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.ShowDialog();
        }

     
    }
}
