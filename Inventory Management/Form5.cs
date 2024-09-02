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
    public partial class Form5 : Form
    {
        private int id_rec;
        private string status;
        private string connectionString = "Persist Security Info=True;Initial Catalog=Inventory;Data Source=localhost\\SQLEXPRESS01; MultipleActiveResultSets=True; User ID=sa;password=Pass@sql20";

        public Form5()
        {
            InitializeComponent();
            Load += Form5_Load;
        }
        public Form5(int id, string status)
        {
            id_rec = id;
            InitializeComponent();
            this.status = status;
            Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        public void fillgrid()
        {
            string query = $"select ID,Item_ID,Name,Rate,Weight from Add_product where ID= {id_rec}";
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
        private void button1_Click(object sender, EventArgs e)
        {
            
            string qty = Qty_remove.Text;
            string date = dateTimePicker1.Text;
            string updatequery = $"update Add_product set QTY = Isnull(QTY,0.00) - {qty} , Entrydate ='{dateTimePicker1.Value}' , Total_Cost= Rate * (Isnull(QTY,0.00) - {qty}) where ID ={id_rec}";
            string insertquery = "Insert into Entries (Qty,Date,Entry_ID,Status) values (@Qty_add, @dateTimePicker1, @id_rec ,@status)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty_add", qty);
                        cmd.Parameters.AddWithValue("@dateTimePicker1", date);
                        cmd.Parameters.AddWithValue("@id_rec", id_rec);
                        cmd.ExecuteNonQuery();

                    }

                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty_add", qty);
                        cmd.Parameters.AddWithValue("@dateTimePicker1", date);
                        cmd.Parameters.AddWithValue("@id_rec", id_rec);
                        cmd.Parameters.AddWithValue("status", status);
                        cmd.ExecuteNonQuery();
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            /*Form1 form1 = new Form1();
            form1.fillgrid();
            form1.Refresh();*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
