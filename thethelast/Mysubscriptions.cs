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
    public partial class Mysubscriptions : Form
    {
        public Mysubscriptions()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" +
                       @"Data Source=C:\Users\ptmwi\OneDrive\Documents\cpe363\final\project\thethelast\thethelast\bin\Debug\my_sub.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void Mysubscriptions_Load(object sender, EventArgs e)
        {
            lblname.Text = Login.Username;
            string constr = "Provider=Microsoft.Jet.OleDb.4.0;" +
            @"Data Source=C:\Users\ptmwi\OneDrive\Documents\cpe363\final\project\thethelast\thethelast\bin\Debug\my_sub.mdb";

            OleDbConnection conn = new OleDbConnection(constr);
            conn.Open();

            string sql = "select*from data_user where Username='" + lblname.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "cat");
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                dataGridView1.DataSource = ds.Tables["cat"];
                this.dataGridView1.Columns["Username"].Visible = false;
                conn.Close();
            }
            else
            {
                MessageBox.Show("No Subscriptions", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
        private void btnContact_Click(object sender, EventArgs e)
        {
            new Contactus().Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Add().Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }







      
    }
}
