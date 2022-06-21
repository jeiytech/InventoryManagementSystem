
namespace firstProject
{
    partial class Unpaid_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unpaid_Order));
            this.unp_order_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.unp_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMgmtDataSet4 = new firstProject.inventoryMgmtDataSet4();
            this.unp_order_paidTxt = new System.Windows.Forms.TextBox();
            this.unp_order_priceTxt = new System.Windows.Forms.TextBox();
            this.unp_partTxt = new System.Windows.Forms.TextBox();
            this.unp_order_detailsTxt = new System.Windows.Forms.TextBox();
            this.unp_orderidTxt = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new firstProject.inventoryMgmtDataSet4TableAdapters.ordersTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.unp_order_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unp_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // unp_order_panel
            // 
            this.unp_order_panel.Controls.Add(this.button4);
            this.unp_order_panel.Controls.Add(this.button5);
            this.unp_order_panel.Controls.Add(this.label35);
            this.unp_order_panel.Controls.Add(this.button6);
            this.unp_order_panel.Controls.Add(this.unp_dataGridView);
            this.unp_order_panel.Controls.Add(this.unp_order_paidTxt);
            this.unp_order_panel.Controls.Add(this.unp_order_priceTxt);
            this.unp_order_panel.Controls.Add(this.unp_partTxt);
            this.unp_order_panel.Controls.Add(this.unp_order_detailsTxt);
            this.unp_order_panel.Controls.Add(this.unp_orderidTxt);
            this.unp_order_panel.Controls.Add(this.label36);
            this.unp_order_panel.Controls.Add(this.label37);
            this.unp_order_panel.Controls.Add(this.label38);
            this.unp_order_panel.Controls.Add(this.label39);
            this.unp_order_panel.Controls.Add(this.label40);
            this.unp_order_panel.Location = new System.Drawing.Point(0, 0);
            this.unp_order_panel.Margin = new System.Windows.Forms.Padding(2);
            this.unp_order_panel.Name = "unp_order_panel";
            this.unp_order_panel.Size = new System.Drawing.Size(945, 518);
            this.unp_order_panel.TabIndex = 74;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(123, 429);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 55);
            this.button4.TabIndex = 101;
            this.button4.Text = "Generate Order-List PDF";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(123, 350);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(4);
            this.button5.Size = new System.Drawing.Size(186, 63);
            this.button5.TabIndex = 100;
            this.button5.Text = "Cancel Order";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(86, 19);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(203, 18);
            this.label35.TabIndex = 99;
            this.label35.Text = "Unpaid-Order Details Form";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(123, 273);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(4);
            this.button6.Size = new System.Drawing.Size(186, 63);
            this.button6.TabIndex = 98;
            this.button6.Text = "Mark as Paid";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // unp_dataGridView
            // 
            this.unp_dataGridView.AllowUserToAddRows = false;
            this.unp_dataGridView.AutoGenerateColumns = false;
            this.unp_dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.unp_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unp_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unp_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.unp_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unp_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.unp_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unp_dataGridView.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.unp_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.unp_dataGridView.Location = new System.Drawing.Point(344, 19);
            this.unp_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.unp_dataGridView.MinimumSize = new System.Drawing.Size(590, 499);
            this.unp_dataGridView.Name = "unp_dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unp_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.unp_dataGridView.RowTemplate.Height = 24;
            this.unp_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unp_dataGridView.Size = new System.Drawing.Size(590, 499);
            this.unp_dataGridView.TabIndex = 97;
            this.unp_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.unp_dataGridView_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 46;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 63;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 68;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.Width = 64;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.inventoryMgmtDataSet4;
            // 
            // inventoryMgmtDataSet4
            // 
            this.inventoryMgmtDataSet4.DataSetName = "inventoryMgmtDataSet4";
            this.inventoryMgmtDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unp_order_paidTxt
            // 
            this.unp_order_paidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unp_order_paidTxt.Location = new System.Drawing.Point(123, 229);
            this.unp_order_paidTxt.Margin = new System.Windows.Forms.Padding(2);
            this.unp_order_paidTxt.Name = "unp_order_paidTxt";
            this.unp_order_paidTxt.Size = new System.Drawing.Size(186, 22);
            this.unp_order_paidTxt.TabIndex = 95;
            this.unp_order_paidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unp_order_priceTxt
            // 
            this.unp_order_priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unp_order_priceTxt.Location = new System.Drawing.Point(123, 188);
            this.unp_order_priceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.unp_order_priceTxt.Name = "unp_order_priceTxt";
            this.unp_order_priceTxt.Size = new System.Drawing.Size(186, 22);
            this.unp_order_priceTxt.TabIndex = 94;
            this.unp_order_priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unp_partTxt
            // 
            this.unp_partTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unp_partTxt.Location = new System.Drawing.Point(123, 149);
            this.unp_partTxt.Margin = new System.Windows.Forms.Padding(2);
            this.unp_partTxt.Name = "unp_partTxt";
            this.unp_partTxt.Size = new System.Drawing.Size(186, 22);
            this.unp_partTxt.TabIndex = 92;
            this.unp_partTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unp_order_detailsTxt
            // 
            this.unp_order_detailsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unp_order_detailsTxt.Location = new System.Drawing.Point(123, 108);
            this.unp_order_detailsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.unp_order_detailsTxt.Name = "unp_order_detailsTxt";
            this.unp_order_detailsTxt.Size = new System.Drawing.Size(186, 22);
            this.unp_order_detailsTxt.TabIndex = 91;
            this.unp_order_detailsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unp_orderidTxt
            // 
            this.unp_orderidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unp_orderidTxt.Location = new System.Drawing.Point(123, 67);
            this.unp_orderidTxt.Margin = new System.Windows.Forms.Padding(2);
            this.unp_orderidTxt.Name = "unp_orderidTxt";
            this.unp_orderidTxt.Size = new System.Drawing.Size(186, 22);
            this.unp_orderidTxt.TabIndex = 90;
            this.unp_orderidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(34, 63);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 20);
            this.label36.TabIndex = 81;
            this.label36.Text = "Order Id";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(34, 232);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 20);
            this.label37.TabIndex = 80;
            this.label37.Text = "Is-Paid ?";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(34, 190);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 20);
            this.label38.TabIndex = 79;
            this.label38.Text = "Price";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(34, 147);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(38, 20);
            this.label39.TabIndex = 77;
            this.label39.Text = "Part";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(34, 105);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 20);
            this.label40.TabIndex = 76;
            this.label40.Text = "Details";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Unpaid_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 518);
            this.Controls.Add(this.unp_order_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unpaid_Order";
            this.Text = "Unpaid_Order";
            this.Load += new System.EventHandler(this.Unpaid_Order_Load);
            this.unp_order_panel.ResumeLayout(false);
            this.unp_order_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unp_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel unp_order_panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView unp_dataGridView;
        private System.Windows.Forms.TextBox unp_order_paidTxt;
        private System.Windows.Forms.TextBox unp_order_priceTxt;
        private System.Windows.Forms.TextBox unp_partTxt;
        private System.Windows.Forms.TextBox unp_order_detailsTxt;
        private System.Windows.Forms.TextBox unp_orderidTxt;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private inventoryMgmtDataSet4 inventoryMgmtDataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private inventoryMgmtDataSet4TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}