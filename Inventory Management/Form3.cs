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
    public partial class Form3 : Form
    {
        private string connectionString = "Persist Security Info=True;Initial Catalog=Inventory;Data Source=localhost\\SQLEXPRESS01; MultipleActiveResultSets=True; User ID=sa;password=Pass@sql20";
        public Form3()  
        {
            InitializeComponent();
            Load += Form3_Load;
            fillgrid();
            
         //   dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet1.Add_product' table. You can move, or remove it, as needed.
           // this.add_productTableAdapter.Fill(this.inventoryDataSet1.Add_product);
            // TODO: This line of code loads data into the 'inventoryDataSet.Add_product' table. You can move, or remove it, as needed.
            //   this.add_productTableAdapter.Fill(this.inventoryDataSet.Add_product);
            fillgrid();
            
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

        

        
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            if (e.RowIndex >= 0)
            {
                string status;
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
               

                //Row Click, ID Column value collect
                if (e.ColumnIndex == 0)
                {
                    //  string s1 = "IN";
                    status = "IN";
                    Form4 form4 = new Form4(id,status);
                    
                    form4.ShowDialog();
                    fillgrid();
                    
                }
                else
                {
                    status = "OUT";
                        Form5 form5 = new Form5(id, status);
                   
                        form5.ShowDialog();
                    fillgrid();
                }
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
