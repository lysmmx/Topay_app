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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" +
                       @"Data Source=C:\Users\ptmwi\OneDrive\Documents\cpe363\final\project\thethelast\thethelast\bin\Debug\my_sub.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Contactus().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Mysubscriptions().Show();
            this.Hide();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtPrice.Text == "")
            {
                MessageBox.Show("Please add your subscription name and price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string database = "INSERT INTO data_user VALUES('" + txtName.Text + "','" + dateTimePicker1.Text + "','" + txtPrice.Text +"','"+ lblname.Text + "')";
                cmd = new OleDbCommand(database, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Your subscription has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Mysubscriptions().Show();
                this.Hide();
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            lblname.Text = Login.Username;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
