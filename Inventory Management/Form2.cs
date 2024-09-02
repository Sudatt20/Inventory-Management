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
    public partial class Form2 : Form
    {
        private string connectionString = "Persist Security Info=True;Initial Catalog=Inventory;Data Source=localhost\\SQLEXPRESS01; MultipleActiveResultSets=True; User ID=sa;password=Pass@sql20";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_p_Click(object sender, EventArgs e)
        {
            string id = Item_id.Text;
            string name = Name_tb.Text;
            string desc = Desc.Text;
            string rate = Rate.Text;
            string weight = Weight.Text;
            string insertquery = "insert into Add_product (Item_ID,Name,Description,Rate,Weight) values (@Item_id, @Name_tb, @Desc, @Rate, @Weight) " +
               "SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {

                        cmd.Parameters.AddWithValue("@Item_id", id);
                        cmd.Parameters.AddWithValue("@Name_tb", name);
                        cmd.Parameters.AddWithValue("@Desc", desc);
                        cmd.Parameters.AddWithValue("@Rate", rate);
                        cmd.Parameters.AddWithValue("@Weight", weight);
                        cmd.ExecuteNonQuery();
                    }
                }
               // fillgrid(); // Refresh the grid after insertion
            }   
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            {
                ClearForm();
            }

        }

        private void ClearForm()
        {
            Item_id.Text = string.Empty;
            Name_tb.Text = string.Empty;
            Desc.Text = string.Empty;
            Rate.Text = string.Empty; // If Rate is a TextBox
            Weight.Text = string.Empty;
        }
        private void Item_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

