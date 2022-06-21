using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.Sql;

namespace firstProject
{
    public partial class Update_Item : Form
    {
        public Update_Item()
        {
            InitializeComponent();
        }

        private void Update_Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMgmtDataSet4.spareparts' table. You can move, or remove it, as needed.
            this.sparepartsTableAdapter.Fill(this.inventoryMgmtDataSet4.spareparts);
            u_itemcodeTxt.Enabled = false;
            u_itemcodeTxt.Text = "Id Auto Number";
            FillUpdateGridView();
            u_modelTxt.Clear();
            u_partTxt.Clear();
            u_priceTxt.Clear();
            u_stockTxt.Clear();
            u_typeCombo.SelectedIndex = -1;
        }

        private void u_itemBtn_Click(object sender, EventArgs e)
        {
            if (u_modelTxt.Text != "" && u_partTxt.Text != "" && u_typeCombo.Text != "" && u_priceTxt.Text != "" && u_stockTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "update spareparts set model= '" + u_modelTxt.Text + "',part= '" + u_partTxt.Text + "',type= '" + u_typeCombo.Text + "',price='" + u_priceTxt.Text + "', instock= '" + u_stockTxt.Text + "'where id= '" + u_itemcodeTxt.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item details are updated successfully!");
                    u_itemcodeTxt.Clear();
                    u_itemcodeTxt.Enabled = false;
                    u_itemcodeTxt.Text = "Id Auto Number";
                    u_modelTxt.Clear();
                    u_partTxt.Clear();
                    u_priceTxt.Clear();
                    u_stockTxt.Clear();
                    u_typeCombo.SelectedIndex = -1;
                    FillUpdateGridView();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should select an item before updating !");
            }
        }

        void FillUpdateGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter u_sda = new SqlDataAdapter("select * from spareparts ", conn);
            DataTable u_dt = new DataTable();
            u_sda.Fill(u_dt);
            u_dataGridView.DataSource = u_dt;
        }

        private void u_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.u_dataGridView.Rows[e.RowIndex];
                u_itemcodeTxt.Text = row.Cells[0].Value.ToString();
                u_modelTxt.Text = row.Cells[1].Value.ToString();
                u_partTxt.Text = row.Cells[2].Value.ToString();
                u_typeCombo.Text = row.Cells[3].Value.ToString();
                u_priceTxt.Text = row.Cells[4].Value.ToString();
                u_stockTxt.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
