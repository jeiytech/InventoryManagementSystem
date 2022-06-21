
namespace firstProject
{
    partial class Delete_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Item));
            this.deleteitem_panel = new System.Windows.Forms.Panel();
            this.d_item_dataGridView = new System.Windows.Forms.DataGridView();
            this.sparepartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMgmtDataSet4 = new firstProject.inventoryMgmtDataSet4();
            this.label16 = new System.Windows.Forms.Label();
            this.del_item_btn = new System.Windows.Forms.Button();
            this.d_typeCombo = new System.Windows.Forms.ComboBox();
            this.d_instockTxt = new System.Windows.Forms.TextBox();
            this.d_priceTxt = new System.Windows.Forms.TextBox();
            this.d_partTxt = new System.Windows.Forms.TextBox();
            this.d_modelTxt = new System.Windows.Forms.TextBox();
            this.d_itemcodeTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.sparepartsTableAdapter = new firstProject.inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteitem_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_item_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteitem_panel
            // 
            this.deleteitem_panel.Controls.Add(this.d_item_dataGridView);
            this.deleteitem_panel.Controls.Add(this.label16);
            this.deleteitem_panel.Controls.Add(this.del_item_btn);
            this.deleteitem_panel.Controls.Add(this.d_typeCombo);
            this.deleteitem_panel.Controls.Add(this.d_instockTxt);
            this.deleteitem_panel.Controls.Add(this.d_priceTxt);
            this.deleteitem_panel.Controls.Add(this.d_partTxt);
            this.deleteitem_panel.Controls.Add(this.d_modelTxt);
            this.deleteitem_panel.Controls.Add(this.d_itemcodeTxt);
            this.deleteitem_panel.Controls.Add(this.label17);
            this.deleteitem_panel.Controls.Add(this.label18);
            this.deleteitem_panel.Controls.Add(this.label19);
            this.deleteitem_panel.Controls.Add(this.label20);
            this.deleteitem_panel.Controls.Add(this.label21);
            this.deleteitem_panel.Controls.Add(this.label22);
            this.deleteitem_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteitem_panel.Location = new System.Drawing.Point(0, 0);
            this.deleteitem_panel.Margin = new System.Windows.Forms.Padding(2);
            this.deleteitem_panel.Name = "deleteitem_panel";
            this.deleteitem_panel.Size = new System.Drawing.Size(1035, 599);
            this.deleteitem_panel.TabIndex = 72;
            // 
            // d_item_dataGridView
            // 
            this.d_item_dataGridView.AutoGenerateColumns = false;
            this.d_item_dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.d_item_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d_item_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d_item_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.d_item_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_item_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.instockDataGridViewTextBoxColumn});
            this.d_item_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_item_dataGridView.DataSource = this.sparepartsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_item_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_item_dataGridView.Location = new System.Drawing.Point(366, 67);
            this.d_item_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.d_item_dataGridView.Name = "d_item_dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.d_item_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.d_item_dataGridView.RowTemplate.Height = 24;
            this.d_item_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d_item_dataGridView.Size = new System.Drawing.Size(645, 499);
            this.d_item_dataGridView.TabIndex = 100;
            this.d_item_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_item_dataGridView_CellContentClick_1);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(86, 19);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 18);
            this.label16.TabIndex = 99;
            this.label16.Text = "Delete Item Form";
            // 
            // del_item_btn
            // 
            this.del_item_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.del_item_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.del_item_btn.FlatAppearance.BorderSize = 2;
            this.del_item_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_item_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_item_btn.Image = ((System.Drawing.Image)(resources.GetObject("del_item_btn.Image")));
            this.del_item_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_item_btn.Location = new System.Drawing.Point(52, 333);
            this.del_item_btn.Margin = new System.Windows.Forms.Padding(2);
            this.del_item_btn.Name = "del_item_btn";
            this.del_item_btn.Padding = new System.Windows.Forms.Padding(4);
            this.del_item_btn.Size = new System.Drawing.Size(212, 74);
            this.del_item_btn.TabIndex = 98;
            this.del_item_btn.Text = "Delete Item";
            this.del_item_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.del_item_btn.UseVisualStyleBackColor = false;
            this.del_item_btn.Click += new System.EventHandler(this.del_item_btn_Click);
            // 
            // d_typeCombo
            // 
            this.d_typeCombo.FormattingEnabled = true;
            this.d_typeCombo.Items.AddRange(new object[] {
            "imported",
            "manufactured"});
            this.d_typeCombo.Location = new System.Drawing.Point(148, 186);
            this.d_typeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.d_typeCombo.Name = "d_typeCombo";
            this.d_typeCombo.Size = new System.Drawing.Size(137, 21);
            this.d_typeCombo.TabIndex = 96;
            // 
            // d_instockTxt
            // 
            this.d_instockTxt.Location = new System.Drawing.Point(148, 271);
            this.d_instockTxt.Margin = new System.Windows.Forms.Padding(2);
            this.d_instockTxt.Name = "d_instockTxt";
            this.d_instockTxt.Size = new System.Drawing.Size(137, 20);
            this.d_instockTxt.TabIndex = 95;
            this.d_instockTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_priceTxt
            // 
            this.d_priceTxt.Location = new System.Drawing.Point(148, 230);
            this.d_priceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.d_priceTxt.Name = "d_priceTxt";
            this.d_priceTxt.Size = new System.Drawing.Size(137, 20);
            this.d_priceTxt.TabIndex = 94;
            this.d_priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_partTxt
            // 
            this.d_partTxt.Location = new System.Drawing.Point(148, 149);
            this.d_partTxt.Margin = new System.Windows.Forms.Padding(2);
            this.d_partTxt.Name = "d_partTxt";
            this.d_partTxt.Size = new System.Drawing.Size(137, 20);
            this.d_partTxt.TabIndex = 92;
            this.d_partTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_modelTxt
            // 
            this.d_modelTxt.Location = new System.Drawing.Point(148, 108);
            this.d_modelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.d_modelTxt.Name = "d_modelTxt";
            this.d_modelTxt.Size = new System.Drawing.Size(137, 20);
            this.d_modelTxt.TabIndex = 91;
            this.d_modelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_itemcodeTxt
            // 
            this.d_itemcodeTxt.Location = new System.Drawing.Point(148, 67);
            this.d_itemcodeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.d_itemcodeTxt.Name = "d_itemcodeTxt";
            this.d_itemcodeTxt.Size = new System.Drawing.Size(137, 20);
            this.d_itemcodeTxt.TabIndex = 90;
            this.d_itemcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 63);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 81;
            this.label17.Text = "Item code";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 274);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 80;
            this.label18.Text = "In-Stock";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(34, 232);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 20);
            this.label19.TabIndex = 79;
            this.label19.Text = "Price";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(34, 189);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 20);
            this.label20.TabIndex = 78;
            this.label20.Text = "Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(34, 147);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 20);
            this.label21.TabIndex = 77;
            this.label21.Text = "Part";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(34, 105);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 20);
            this.label22.TabIndex = 76;
            this.label22.Text = "Model";
            // 
            // sparepartsTableAdapter
            // 
            this.sparepartsTableAdapter.ClearBeforeFill = true;
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
            // Delete_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 599);
            this.Controls.Add(this.deleteitem_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Item";
            this.Text = "Delete_Item";
            this.Load += new System.EventHandler(this.Delete_Item_Load);
            this.deleteitem_panel.ResumeLayout(false);
            this.deleteitem_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_item_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel deleteitem_panel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button del_item_btn;
        private System.Windows.Forms.ComboBox d_typeCombo;
        private System.Windows.Forms.TextBox d_instockTxt;
        private System.Windows.Forms.TextBox d_priceTxt;
        private System.Windows.Forms.TextBox d_partTxt;
        private System.Windows.Forms.TextBox d_modelTxt;
        private System.Windows.Forms.TextBox d_itemcodeTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView d_item_dataGridView;
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