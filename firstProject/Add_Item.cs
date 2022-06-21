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
    public partial class Add_Item : Form
    {
        public Add_Item()
        {
            InitializeComponent();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMgmtDataSet4.spareparts' table. You can move, or remove it, as needed.
            this.sparepartsTableAdapter.Fill(this.inventoryMgmtDataSet4.spareparts);
            itemcode.Enabled = false;
            itemcode.Text = "Id Auto Number";
            FillGridView();
            model.Clear();
            part.Clear();
            price.Clear();
            instock.Clear();
            comboBox1.SelectedIndex = -1;
        }

        /*The function tht fills the datagridview*/
        void FillGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from spareparts ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            itemlist.DataSource = dt;
        }

        private void additem_Click(object sender, EventArgs e)
        {
            if (model.Text != "" && part.Text != "" && comboBox1.Text != "" && price.Text != "" && instock.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "insert into spareparts(model,part,type,price,instock) values('" + model.Text.Trim() + "','" + part.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + price.Text.Trim() + "','" + instock.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item has been added successfully!");
                    model.Clear();
                    part.Clear();
                    price.Clear();
                    instock.Clear();
                    comboBox1.SelectedIndex = -1;
                    FillGridView();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Details Exists", ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should fill the all fields");
            }
        }

        private void itemlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.itemlist.Rows[e.RowIndex];
                itemcode.Text = row.Cells[0].Value.ToString();
                model.Text = row.Cells[1].Value.ToString();
                part.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                price.Text = row.Cells[4].Value.ToString();
                instock.Text = row.Cells[5].Value.ToString();
            }
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            int height = itemlist.Height;
            itemlist.Height = itemlist.RowCount + itemlist.RowTemplate.Height + 2;
            bmp = new Bitmap(itemlist.Width, itemlist.Height);
            itemlist.DrawToBitmap(bmp, new Rectangle(0, 0, itemlist.Width, itemlist.Height));
            itemlist.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String d = DateTime.Now.ToString();
            e.Graphics.DrawString("Unpaid Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("Print Time: " + d, new Font("Century", 10, FontStyle.Regular), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawImage(bmp, 80, 200);
        }
    }
}
