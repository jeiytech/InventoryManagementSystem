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
using System.Globalization;

namespace firstProject
{
    public partial class Unpaid_Order : Form
    {
        public Unpaid_Order()
        {
            InitializeComponent();
        }

        private void Unpaid_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMgmtDataSet4.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.inventoryMgmtDataSet4.orders);
            unp_orderidTxt.Enabled = false;
            unp_orderidTxt.Text = "Id Auto Number";
            unp_order_detailsTxt.Clear();
            unp_partTxt.Clear();
            unp_order_priceTxt.Clear();
            unp_order_paidTxt.Clear();
            FillUnpaidGridView();
        }

        /*The function that fills Unpaid orders datagridview*/
        void FillUnpaidGridView()
        {
            String status = "no";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter unp_sda = new SqlDataAdapter("select * from orders where paid = '" + status + "' ", conn);
            DataTable unp_dt = new DataTable();
            unp_sda.Fill(unp_dt);
            unp_dataGridView.DataSource = unp_dt;
        }

        private void unp_dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.unp_dataGridView.Rows[e.RowIndex];
                unp_orderidTxt.Text = row.Cells[0].Value.ToString();
                unp_order_detailsTxt.Text = row.Cells[1].Value.ToString();
                unp_partTxt.Text = row.Cells[2].Value.ToString();
                unp_order_priceTxt.Text = row.Cells[3].Value.ToString();
                unp_order_paidTxt.Text = row.Cells[4].Value.ToString();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (unp_orderidTxt.Text != "" && unp_order_detailsTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf; Integrated Security = True; Connect Timeout = 30; ");
                    string query = "update orders set paid= '" + "yes" + "'where id= '" + unp_orderidTxt.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The Order was marked as Paid & sent to the paid order table !");
                    unp_orderidTxt.Clear();
                    unp_orderidTxt.Enabled = false;
                    unp_orderidTxt.Text = "Id Auto Number";
                    unp_order_detailsTxt.Clear();
                    unp_partTxt.Clear();
                    unp_order_priceTxt.Clear();
                    unp_order_paidTxt.Clear();
                    FillUnpaidGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("First...u should select an order to make changes !");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (unp_orderidTxt.Text != "" && unp_order_detailsTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "update orders set paid= '" + "cancelled" + "'where id= '" + unp_orderidTxt.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The Order was marked as Cancelled & sent to the Cancelled orders table !");
                    unp_orderidTxt.Clear();
                    unp_orderidTxt.Enabled = false;
                    unp_orderidTxt.Text = "Id Auto Number";
                    unp_order_detailsTxt.Clear();
                    unp_partTxt.Clear();
                    unp_order_priceTxt.Clear();
                    unp_order_paidTxt.Clear();
                    FillUnpaidGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("First... you should select an order to cancel !");
            }
        }



        Bitmap bmp;
        private void button4_Click(object sender, EventArgs e)
        {

            int height = unp_dataGridView.Height;
            unp_dataGridView.Height = unp_dataGridView.RowCount + unp_dataGridView.RowTemplate.Height + 2;
            bmp = new Bitmap(unp_dataGridView.Width, unp_dataGridView.Height);
            unp_dataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, unp_dataGridView.Width, unp_dataGridView.Height));
            unp_dataGridView.Height = height;
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
