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
    public partial class Home : Form
    {

        public string ItemList = "";
        public float TotalPrice = 0;
        public string UpdateQuery = "";
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            FillPartslist();
            FillComboBox();
            ItemList = "";
            TotalPrice = 0;
            UpdateQuery = "";

            userdetail user = new userdetail();
            label9.Text = user.getUname();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyOrders orders = new MyOrders();
            this.Hide();
            orders.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                SqlDataAdapter sda = new SqlDataAdapter("select * from spareparts where model='" + comboBox1.Text.Trim() + "' and part='" + comboBox2.Text.Trim() + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox6.Text) >= int.Parse(textBox7.Text))
                {
                    ItemList += textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + "*" + textBox7.Text + Environment.NewLine;
                    TotalPrice += float.Parse(textBox5.Text) * float.Parse(textBox7.Text);
                    UpdateQuery += "update spareparts set instock='" + (int.Parse(textBox6.Text) - int.Parse(textBox7.Text)) + "' where id='" + textBox1.Text + "';";
                    String msg = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + "*" + textBox7.Text;
                    MessageBox.Show(msg + Environment.NewLine + "Added to Cart");
                    textBox7.Clear();
                }
                else
                {
                    MessageBox.Show("Not Enough Items in Stock");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter in Correct Format");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ItemList == "")
            {
                MessageBox.Show("No Items Selected");
            }
            else
            {
                var childform = new Confirm();
                childform.MyParent = this;
                childform.Show();
                this.Enabled = false;
            }
        }

        void FillComboBox()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("select DISTINCT model from spareparts", conn);
            DataSet dt = new DataSet();
            sda.Fill(dt);

            comboBox1.DataSource = dt.Tables[0];
            comboBox1.DisplayMember = "model";
            comboBox1.ValueMember = "model";

            SqlDataAdapter sda1 = new SqlDataAdapter("select DISTINCT part from spareparts", conn);
            DataSet dt1 = new DataSet();
            sda1.Fill(dt1);

            comboBox2.DataSource = dt1.Tables[0];
            comboBox2.DisplayMember = "part";
            comboBox2.ValueMember = "part";

            conn.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
            }
        }

        void FillPartslist()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter list = new SqlDataAdapter("select id, model, part, type, price, instock from spareparts ", conn);
            DataTable dtlist = new DataTable();
            list.Fill(dtlist);
            dataGridView1.DataSource = dtlist;
        }
    }
}
