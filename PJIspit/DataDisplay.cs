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

namespace PJIspit
{
    public partial class DataDisplay : Form
    {
        public DataDisplay()
        {
            InitializeComponent();
            try
            {
                FetchData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }


     private void FetchData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-64IL438\DEVSQL;Initial Catalog=PJstudents;Integrated Security=True");
            con.Open();
            string query = "SELECT * FROM students";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            con.Close();

        }


    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
