using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;
using System.IO;

namespace thethelast
{
    public partial class Login : Form
    {
        public static string Username = "";
        
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" +
                       @"Data Source=C:\Users\ptmwi\OneDrive\Documents\cpe363\final\project\thethelast\thethelast\bin\Debug\my_sub.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void label6_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string login = "SELECT * FROM tbl_user WHERE Username ='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, conn);
            adapter = new OleDbDataAdapter(cmd);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                Username = txtUsername.Text;
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password,Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtUsername.Text = "";
                txtUsername.Focus();
            }
            
        }


    }
}
