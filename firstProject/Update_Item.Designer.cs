
namespace firstProject
{
    partial class Update_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Item));
            this.updateitems_panel = new System.Windows.Forms.Panel();
            this.u_dataGridView = new System.Windows.Forms.DataGridView();
            this.sparepartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMgmtDataSet4 = new firstProject.inventoryMgmtDataSet4();
            this.label15 = new System.Windows.Forms.Label();
            this.u_itemBtn = new System.Windows.Forms.Button();
            this.u_typeCombo = new System.Windows.Forms.ComboBox();
            this.u_stockTxt = new System.Windows.Forms.TextBox();
            this.u_priceTxt = new System.Windows.Forms.TextBox();
            this.u_partTxt = new System.Windows.Forms.TextBox();
            this.u_modelTxt = new System.Windows.Forms.TextBox();
            this.u_itemcodeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sparepartsTableAdapter = new firstProject.inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateitems_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // updateitems_panel
            // 
            this.updateitems_panel.Controls.Add(this.u_dataGridView);
            this.updateitems_panel.Controls.Add(this.label15);
            this.updateitems_panel.Controls.Add(this.u_itemBtn);
            this.updateitems_panel.Controls.Add(this.u_typeCombo);
            this.updateitems_panel.Controls.Add(this.u_stockTxt);
            this.updateitems_panel.Controls.Add(this.u_priceTxt);
            this.updateitems_panel.Controls.Add(this.u_partTxt);
            this.updateitems_panel.Controls.Add(this.u_modelTxt);
            this.updateitems_panel.Controls.Add(this.u_itemcodeTxt);
            this.updateitems_panel.Controls.Add(this.label1);
            this.updateitems_panel.Controls.Add(this.label9);
            this.updateitems_panel.Controls.Add(this.label10);
            this.updateitems_panel.Controls.Add(this.label11);
            this.updateitems_panel.Controls.Add(this.label12);
            this.updateitems_panel.Controls.Add(this.label13);
            this.updateitems_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateitems_panel.Location = new System.Drawing.Point(0, 0);
            this.updateitems_panel.Margin = new System.Windows.Forms.Padding(2);
            this.updateitems_panel.Name = "updateitems_panel";
            this.updateitems_panel.Size = new System.Drawing.Size(1013, 594);
            this.updateitems_panel.TabIndex = 71;
            // 
            // u_dataGridView
            // 
            this.u_dataGridView.AutoGenerateColumns = false;
            this.u_dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.u_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.u_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.u_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.u_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.u_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.instockDataGridViewTextBoxColumn});
            this.u_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.u_dataGridView.DataSource = this.sparepartsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.u_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.u_dataGridView.Location = new System.Drawing.Point(332, 66);
            this.u_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.u_dataGridView.Name = "u_dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.u_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.u_dataGridView.RowTemplate.Height = 24;
            this.u_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.u_dataGridView.Size = new System.Drawing.Size(644, 491);
            this.u_dataGridView.TabIndex = 114;
            this.u_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.u_dataGridView_CellContentClick);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(86, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 18);
            this.label15.TabIndex = 113;
            this.label15.Text = "Update Item Form";
            // 
            // u_itemBtn
            // 
            this.u_itemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.u_itemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.u_itemBtn.FlatAppearance.BorderSize = 3;
            this.u_itemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.u_itemBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_itemBtn.Image = ((System.Drawing.Image)(resources.GetObject("u_itemBtn.Image")));
            this.u_itemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.u_itemBtn.Location = new System.Drawing.Point(52, 333);
            this.u_itemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.u_itemBtn.Name = "u_itemBtn";
            this.u_itemBtn.Padding = new System.Windows.Forms.Padding(4);
            this.u_itemBtn.Size = new System.Drawing.Size(212, 74);
            this.u_itemBtn.TabIndex = 112;
            this.u_itemBtn.Text = "Update Item";
            this.u_itemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.u_itemBtn.UseVisualStyleBackColor = false;
            this.u_itemBtn.Click += new System.EventHandler(this.u_itemBtn_Click);
            // 
            // u_typeCombo
            // 
            this.u_typeCombo.FormattingEnabled = true;
            this.u_typeCombo.Items.AddRange(new object[] {
            "imported",
            "manufactured"});
            this.u_typeCombo.Location = new System.Drawing.Point(149, 187);
            this.u_typeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.u_typeCombo.Name = "u_typeCombo";
            this.u_typeCombo.Size = new System.Drawing.Size(137, 21);
            this.u_typeCombo.TabIndex = 110;
            // 
            // u_stockTxt
            // 
            this.u_stockTxt.Location = new System.Drawing.Point(149, 271);
            this.u_stockTxt.Margin = new System.Windows.Forms.Padding(2);
            this.u_stockTxt.Name = "u_stockTxt";
            this.u_stockTxt.Size = new System.Drawing.Size(137, 20);
            this.u_stockTxt.TabIndex = 109;
            this.u_stockTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // u_priceTxt
            // 
            this.u_priceTxt.Location = new System.Drawing.Point(149, 231);
            this.u_priceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.u_priceTxt.Name = "u_priceTxt";
            this.u_priceTxt.Size = new System.Drawing.Size(137, 20);
            this.u_priceTxt.TabIndex = 108;
            this.u_priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // u_partTxt
            // 
            this.u_partTxt.Location = new System.Drawing.Point(149, 150);
            this.u_partTxt.Margin = new System.Windows.Forms.Padding(2);
            this.u_partTxt.Name = "u_partTxt";
            this.u_partTxt.Size = new System.Drawing.Size(137, 20);
            this.u_partTxt.TabIndex = 107;
            this.u_partTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // u_modelTxt
            // 
            this.u_modelTxt.Location = new System.Drawing.Point(149, 109);
            this.u_modelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.u_modelTxt.Name = "u_modelTxt";
            this.u_modelTxt.Size = new System.Drawing.Size(137, 20);
            this.u_modelTxt.TabIndex = 106;
            this.u_modelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // u_itemcodeTxt
            // 
            this.u_itemcodeTxt.Location = new System.Drawing.Point(149, 66);
            this.u_itemcodeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.u_itemcodeTxt.Name = "u_itemcodeTxt";
            this.u_itemcodeTxt.Size = new System.Drawing.Size(137, 20);
            this.u_itemcodeTxt.TabIndex = 105;
            this.u_itemcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Item code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 103;
            this.label9.Text = "Edit-Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 232);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 102;
            this.label10.Text = "Edit-Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 101;
            this.label11.Text = "Change-Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 100;
            this.label12.Text = "Edit-Part";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 105);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 99;
            this.label13.Text = "Edit-Model";
            // 
            // sparepartsTableAdapter
            // 
            this.sparepartsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // Update_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 594);
            this.Controls.Add(this.updateitems_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Item";
            this.Text = "Update_Item";
            this.Load += new System.EventHandler(this.Update_Item_Load);
            this.updateitems_panel.ResumeLayout(false);
            this.updateitems_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateitems_panel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button u_itemBtn;
        private System.Windows.Forms.ComboBox u_typeCombo;
        private System.Windows.Forms.TextBox u_stockTxt;
        private System.Windows.Forms.TextBox u_priceTxt;
        private System.Windows.Forms.TextBox u_partTxt;
        private System.Windows.Forms.TextBox u_modelTxt;
        private System.Windows.Forms.TextBox u_itemcodeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView u_dataGridView;
        private inventoryMgmtDataSet4 inventoryMgmtDataSet4;
        private System.Windows.Forms.BindingSource sparepartsBindingSource;
        private inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter sparepartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instockDataGridViewTextBoxColumn;
    }
}