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

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        private string connectionString = "Persist Security Info=True;Initial Catalog=Inventory;Data Source=localhost\\SQLEXPRESS01; MultipleActiveResultSets=True; User ID=sa;password=Pass@sql20";
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillgrid();
            fillgrid1();
        } 
        public void fillgrid()
        {
            string query = "select ID,Item_ID,Name,Description,Rate,Weight,QTY,Total_Cost from Add_product";
            // fetch data frm sql db
            DataTable dataTable = new DataTable(); //assign data from qry

            dataGridView1.DataSource = dataTable;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    //  DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // execute
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        public void fillgrid1()
        {
            string query = "select Item_ID,QTY from Add_product where QTY < 100";
            // fetch data frm sql db
            DataTable dataTable = new DataTable(); //assign data from qry

            dataGridView2.DataSource = dataTable;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    //  DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // execute
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
