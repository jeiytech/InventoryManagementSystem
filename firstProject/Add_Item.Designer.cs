
namespace firstProject
{
    partial class Add_Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Item));
            this.additem_panel = new System.Windows.Forms.Panel();
            this.itemlist = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparepartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMgmtDataSet4 = new firstProject.inventoryMgmtDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.additem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instock = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.part = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.itemcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sparepartsTableAdapter = new firstProject.inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.additem_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // additem_panel
            // 
            this.additem_panel.Controls.Add(this.itemlist);
            this.additem_panel.Controls.Add(this.button1);
            this.additem_panel.Controls.Add(this.label14);
            this.additem_panel.Controls.Add(this.additem);
            this.additem_panel.Controls.Add(this.comboBox1);
            this.additem_panel.Controls.Add(this.instock);
            this.additem_panel.Controls.Add(this.price);
            this.additem_panel.Controls.Add(this.part);
            this.additem_panel.Controls.Add(this.model);
            this.additem_panel.Controls.Add(this.itemcode);
            this.additem_panel.Controls.Add(this.label8);
            this.additem_panel.Controls.Add(this.label7);
            this.additem_panel.Controls.Add(this.label6);
            this.additem_panel.Controls.Add(this.label5);
            this.additem_panel.Controls.Add(this.label4);
            this.additem_panel.Controls.Add(this.label3);
            this.additem_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additem_panel.Location = new System.Drawing.Point(0, 0);
            this.additem_panel.Margin = new System.Windows.Forms.Padding(2);
            this.additem_panel.Name = "additem_panel";
            this.additem_panel.Size = new System.Drawing.Size(1012, 577);
            this.additem_panel.TabIndex = 70;
            // 
            // itemlist
            // 
            this.itemlist.AutoGenerateColumns = false;
            this.itemlist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.itemlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.instockDataGridViewTextBoxColumn});
            this.itemlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemlist.DataSource = this.sparepartsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemlist.DefaultCellStyle = dataGridViewCellStyle8;
            this.itemlist.Location = new System.Drawing.Point(334, 63);
            this.itemlist.Margin = new System.Windows.Forms.Padding(2);
            this.itemlist.Name = "itemlist";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemlist.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.itemlist.RowTemplate.Height = 24;
            this.itemlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemlist.Size = new System.Drawing.Size(644, 491);
            this.itemlist.TabIndex = 104;
            this.itemlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemlist_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDataGridViewTextBoxColumn.DataPropertyName = "part";
            this.partDataGridViewTextBoxColumn.HeaderText = "part";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // instockDataGridViewTextBoxColumn
            // 
            this.instockDataGridViewTextBoxColumn.DataPropertyName = "instock";
            this.instockDataGridViewTextBoxColumn.HeaderText = "instock";
            this.instockDataGridViewTextBoxColumn.Name = "instockDataGridViewTextBoxColumn";
            // 
            // sparepartsBindingSource
            // 
            this.sparepartsBindingSource.DataMember = "spareparts";
            this.sparepartsBindingSource.DataSource = this.inventoryMgmtDataSet4;
            // 
            // inventoryMgmtDataSet4
            // 
            this.inventoryMgmtDataSet4.DataSetName = "inventoryMgmtDataSet4";
            this.inventoryMgmtDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 55);
            this.button1.TabIndex = 100;
            this.button1.Text = "Generate Item List PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 18);
            this.label14.TabIndex = 99;
            this.label14.Text = "Add Item Form";
            // 
            // additem
            // 
            this.additem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.additem.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.additem.FlatAppearance.BorderSize = 2;
            this.additem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additem.Image = ((System.Drawing.Image)(resources.GetObject("additem.Image")));
            this.additem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.additem.Location = new System.Drawing.Point(52, 319);
            this.additem.Margin = new System.Windows.Forms.Padding(2);
            this.additem.Name = "additem";
            this.additem.Padding = new System.Windows.Forms.Padding(4);
            this.additem.Size = new System.Drawing.Size(212, 61);
            this.additem.TabIndex = 98;
            this.additem.Text = "Add Item";
            this.additem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.additem.UseVisualStyleBackColor = false;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "imported",
            "manufactured"});
            this.comboBox1.Location = new System.Drawing.Point(148, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 96;
            // 
            // instock
            // 
            this.instock.Location = new System.Drawing.Point(148, 271);
            this.instock.Margin = new System.Windows.Forms.Padding(2);
            this.instock.Name = "instock";
            this.instock.Size = new System.Drawing.Size(137, 20);
            this.instock.TabIndex = 95;
            this.instock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(148, 230);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(137, 20);
            this.price.TabIndex = 94;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part
            // 
            this.part.Location = new System.Drawing.Point(148, 149);
            this.part.Margin = new System.Windows.Forms.Padding(2);
            this.part.Name = "part";
            this.part.Size = new System.Drawing.Size(137, 20);
            this.part.TabIndex = 92;
            this.part.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(148, 108);
            this.model.Margin = new System.Windows.Forms.Padding(2);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(137, 20);
            this.model.TabIndex = 91;
            this.model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemcode
            // 
            this.itemcode.Location = new System.Drawing.Point(148, 67);
            this.itemcode.Margin = new System.Windows.Forms.Padding(2);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(137, 20);
            this.itemcode.TabIndex = 90;
            this.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Item Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "In-Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Part";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Model";
            // 
            // sparepartsTableAdapter
            // 
            this.sparepartsTableAdapter.ClearBeforeFill = true;
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
            // Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 577);
            this.Controls.Add(this.additem_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Item";
            this.Text = "Add_Item";
            this.Load += new System.EventHandler(this.Add_Item_Load);
            this.additem_panel.ResumeLayout(false);
            this.additem_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel additem_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox instock;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox part;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox itemcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView itemlist;
        private inventoryMgmtDataSet4 inventoryMgmtDataSet4;
        private System.Windows.Forms.BindingSource sparepartsBindingSource;
        private inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter sparepartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instockDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}