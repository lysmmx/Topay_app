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
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Mysubscriptions().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Contactus().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblname.Text = Login.Username;
            
            
            
            
        }

    }
}
