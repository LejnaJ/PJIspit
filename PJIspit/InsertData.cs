using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PJIspit
{
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-64IL438\DEVSQL;Initial Catalog=PJstudents;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into students values('" +
                    textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.");
                con.Close();
                OpenDataDisplayForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void OpenDataDisplayForm()
        {
            DataDisplay dataDisplayForm = new DataDisplay();

            dataDisplayForm.Show();
        }
    }
}
