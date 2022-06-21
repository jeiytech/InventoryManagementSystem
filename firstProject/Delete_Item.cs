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
    public partial class Delete_Item : Form
    {
        public Delete_Item()
        {
            InitializeComponent();
        }

        private void Delete_Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMgmtDataSet4.spareparts' table. You can move, or remove it, as needed.
            this.sparepartsTableAdapter.Fill(this.inventoryMgmtDataSet4.spareparts);
            d_itemcodeTxt.Enabled = false;
            d_itemcodeTxt.Text = "Id Auto Number";
            FilldeleteGridView();
            d_modelTxt.Clear();
            d_partTxt.Clear();
            d_priceTxt.Clear();
            d_instockTxt.Clear();
            d_typeCombo.SelectedIndex = -1;
        }

        void FilldeleteGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter d_sda = new SqlDataAdapter("select * from spareparts ", conn);
            DataTable d_dt = new DataTable();
            d_sda.Fill(d_dt);
            d_item_dataGridView.DataSource = d_dt;
        }


        private void d_item_dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.d_item_dataGridView.Rows[e.RowIndex];
                d_itemcodeTxt.Text = row.Cells[0].Value.ToString();
                d_modelTxt.Text = row.Cells[1].Value.ToString();
                d_partTxt.Text = row.Cells[2].Value.ToString();
                d_typeCombo.Text = row.Cells[3].Value.ToString();
                d_priceTxt.Text = row.Cells[4].Value.ToString();
                d_instockTxt.Text = row.Cells[5].Value.ToString();
            }
        }

        private void del_item_btn_Click(object sender, EventArgs e)
        {
            if (d_modelTxt.Text != "" && d_partTxt.Text != "" && d_typeCombo.Text != "" && d_priceTxt.Text != "" && d_instockTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "delete from spareparts where id= '" + d_itemcodeTxt.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item has been successfully deleted!");
                    d_itemcodeTxt.Clear();
                    d_itemcodeTxt.Enabled = false;
                    d_itemcodeTxt.Text = "Id Auto Number";
                    d_modelTxt.Clear();
                    d_partTxt.Clear();
                    d_priceTxt.Clear();
                    d_instockTxt.Clear();
                    d_typeCombo.SelectedIndex = -1;
                    FilldeleteGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should select a row before deleting !");
            }
        }
    }
}
