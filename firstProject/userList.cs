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
    public partial class userList : Form
    {
        public userList()
        {
            InitializeComponent();
        }

        private void userList_Load(object sender, EventArgs e)
        {
            Filluserlist();
        }

        void Filluserlist()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter list = new SqlDataAdapter("select id,first,last,username,phone,usertype from users ", conn);
            DataTable dtlist = new DataTable();
            list.Fill(dtlist);
            users_list.DataSource = dtlist;
        }

        private void del_item_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && typecomboTxt.Text != "" && textBox6.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\firstProject\firstProject\inventoryMgmt.mdf;Integrated Security=True;Connect Timeout=30;");
                    string query = "delete from users where id= '" + textBox6.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The user has been successfully deleted!");
                    textBox6.Clear();
                    textBox6.Enabled = false;
                    textBox6.Text = "Id Auto Number";
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    typecomboTxt.SelectedIndex = -1;
                    Filluserlist();
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

        private void users_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.users_list.Rows[e.RowIndex];
                textBox6.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                typecomboTxt.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
