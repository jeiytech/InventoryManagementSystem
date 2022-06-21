using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.IO;

namespace firstProject
{
    public partial class Paid_Order : Form
    {
        public Paid_Order()
        {
            InitializeComponent();
        }

        private void Paid_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMgmtDataSet4.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.inventoryMgmtDataSet4.orders);
            p_order_idTxt.Enabled = false;
            p_order_idTxt.Text = "Id Auto Number";
            p_order_detailsTxt.Clear();
            p_order_priceTxt.Clear();
            p_order_paidTxt.Clear();
            FillPaidGridView();
        }

        void FillPaidGridView()
        {
            String status = "yes";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter p_sda = new SqlDataAdapter("select * from orders where paid = '" + status + "' ", conn);
            DataTable p_dt = new DataTable();
            p_sda.Fill(p_dt);
            paid_dataGridView1.DataSource = p_dt;
        }

        private void make_unPaid_btn_Click(object sender, EventArgs e)
        {
            if (p_order_idTxt.Text != "" && p_order_detailsTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "update orders set paid= '" + "no" + "'where id= '" + p_order_idTxt.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The Order was marked as Unpaid & sent to the Unpaid table !");
                    p_order_idTxt.Clear();
                    p_order_idTxt.Enabled = false;
                    p_order_idTxt.Text = "Id Auto Number";
                    p_order_detailsTxt.Clear();
                    p_partTxt.Clear();
                    p_order_priceTxt.Clear();
                    p_order_paidTxt.Clear();
                    FillPaidGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("First...u should select an order to make changes");
            }
        }

        private void cancel_order_btn_Click_1(object sender, EventArgs e)
        {
            if (p_order_idTxt.Text != "" && p_order_detailsTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "update orders set paid= '" + "cancelled" + "'where id= '" + p_order_idTxt.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The Order was marked as Cancelled & sent to the Cancelled orders table !");
                    p_order_idTxt.Clear();
                    p_order_idTxt.Enabled = false;
                    p_order_idTxt.Text = "Id Auto Number";
                    p_order_detailsTxt.Clear();
                    p_partTxt.Clear();
                    p_order_priceTxt.Clear();
                    p_order_paidTxt.Clear();
                    FillPaidGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("First...You should select an order to cancel !");
            }
        }

        private void paid_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.paid_dataGridView1.Rows[e.RowIndex];
                p_order_idTxt.Text = row.Cells[0].Value.ToString();
                p_order_detailsTxt.Text = row.Cells[1].Value.ToString();
                p_partTxt.Text = row.Cells[2].Value.ToString();
                p_order_priceTxt.Text = row.Cells[3].Value.ToString();
                p_order_paidTxt.Text = row.Cells[4].Value.ToString();
            }
        }

        Bitmap bmp;

        private void button3_Click(object sender, EventArgs e)
        {
            int height = paid_dataGridView1.Height;
            paid_dataGridView1.Height = paid_dataGridView1.RowCount + paid_dataGridView1.RowTemplate.Height + 2;
            bmp = new Bitmap(paid_dataGridView1.Width, paid_dataGridView1.Height);
            paid_dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, paid_dataGridView1.Width, paid_dataGridView1.Height));
            paid_dataGridView1.Height = height;
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
