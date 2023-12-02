
namespace StoreTask.Views
{
    partial class HomeView
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
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.numericFilterTotal = new System.Windows.Forms.NumericUpDown();
            this.numericFilterStock = new System.Windows.Forms.NumericUpDown();
            this.comboFilterCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewGroup = new System.Windows.Forms.GroupBox();
            this.numericAddTotal = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericAddStock = new System.Windows.Forms.NumericUpDown();
            this.comboAddCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.filterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterStock)).BeginInit();
            this.addNewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.SuspendLayout();
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.numericFilterTotal);
            this.filterGroup.Controls.Add(this.numericFilterStock);
            this.filterGroup.Controls.Add(this.comboFilterCategory);
            this.filterGroup.Controls.Add(this.label4);
            this.filterGroup.Controls.Add(this.label3);
            this.filterGroup.Controls.Add(this.label2);
            this.filterGroup.Controls.Add(this.lblFilterName);
            this.filterGroup.Controls.Add(this.label1);
            this.filterGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterGroup.ForeColor = System.Drawing.Color.Black;
            this.filterGroup.Location = new System.Drawing.Point(12, 12);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(776, 113);
            this.filterGroup.TabIndex = 0;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Filter by";
            // 
            // numericFilterTotal
            // 
            this.numericFilterTotal.Location = new System.Drawing.Point(582, 60);
            this.numericFilterTotal.Name = "numericFilterTotal";
            this.numericFilterTotal.Size = new System.Drawing.Size(172, 34);
            this.numericFilterTotal.TabIndex = 10;
            // 
            // numericFilterStock
            // 
            this.numericFilterStock.Location = new System.Drawing.Point(394, 60);
            this.numericFilterStock.Name = "numericFilterStock";
            this.numericFilterStock.Size = new System.Drawing.Size(172, 34);
            this.numericFilterStock.TabIndex = 9;
            // 
            // comboFilterCategory
            // 
            this.comboFilterCategory.FormattingEnabled = true;
            this.comboFilterCategory.Location = new System.Drawing.Point(202, 60);
            this.comboFilterCategory.Name = "comboFilterCategory";
            this.comboFilterCategory.Size = new System.Drawing.Size(172, 36);
            this.comboFilterCategory.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(584, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Cost of Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(394, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // lblFilterName
            // 
            this.lblFilterName.Location = new System.Drawing.Point(15, 60);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(172, 34);
            this.lblFilterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // addNewGroup
            // 
            this.addNewGroup.Controls.Add(this.numericAddTotal);
            this.addNewGroup.Controls.Add(this.btnSave);
            this.addNewGroup.Controls.Add(this.lblAddDescription);
            this.addNewGroup.Controls.Add(this.label9);
            this.addNewGroup.Controls.Add(this.numericAddStock);
            this.addNewGroup.Controls.Add(this.comboAddCategory);
            this.addNewGroup.Controls.Add(this.label5);
            this.addNewGroup.Controls.Add(this.label6);
            this.addNewGroup.Controls.Add(this.label7);
            this.addNewGroup.Controls.Add(this.lblAddName);
            this.addNewGroup.Controls.Add(this.label8);
            this.addNewGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewGroup.ForeColor = System.Drawing.Color.Black;
            this.addNewGroup.Location = new System.Drawing.Point(12, 131);
            this.addNewGroup.Name = "addNewGroup";
            this.addNewGroup.Size = new System.Drawing.Size(776, 189);
            this.addNewGroup.TabIndex = 10;
            this.addNewGroup.TabStop = false;
            this.addNewGroup.Text = "Add New";
            // 
            // numericAddTotal
            // 
            this.numericAddTotal.Location = new System.Drawing.Point(202, 133);
            this.numericAddTotal.Name = "numericAddTotal";
            this.numericAddTotal.Size = new System.Drawing.Size(172, 34);
            this.numericAddTotal.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(584, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.Location = new System.Drawing.Point(394, 59);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(360, 34);
            this.lblAddDescription.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(394, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Description";
            // 
            // numericAddStock
            // 
            this.numericAddStock.Location = new System.Drawing.Point(204, 60);
            this.numericAddStock.Name = "numericAddStock";
            this.numericAddStock.Size = new System.Drawing.Size(172, 34);
            this.numericAddStock.TabIndex = 9;
            // 
            // comboAddCategory
            // 
            this.comboAddCategory.FormattingEnabled = true;
            this.comboAddCategory.Location = new System.Drawing.Point(15, 133);
            this.comboAddCategory.Name = "comboAddCategory";
            this.comboAddCategory.Size = new System.Drawing.Size(172, 36);
            this.comboAddCategory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(202, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Cost of Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(204, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Category";
            // 
            // lblAddName
            // 
            this.lblAddName.Location = new System.Drawing.Point(15, 60);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(172, 34);
            this.lblAddName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Category,
            this.Stock,
            this.Total,
            this.Print});
            this.productList.GridColor = System.Drawing.Color.Gainsboro;
            this.productList.Location = new System.Drawing.Point(12, 326);
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersWidth = 35;
            this.productList.RowTemplate.Height = 29;
            this.productList.Size = new System.Drawing.Size(776, 389);
            this.productList.TabIndex = 11;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Print
            // 
            this.Print.HeaderText = "Print";
            this.Print.MinimumWidth = 6;
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.BackColor = System.Drawing.Color.DarkGray;
            this.btnPrintAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.btnPrintAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintAll.ForeColor = System.Drawing.Color.White;
            this.btnPrintAll.Location = new System.Drawing.Point(27, 721);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(170, 40);
            this.btnPrintAll.TabIndex = 13;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(216, 721);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 802);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.addNewGroup);
            this.Controls.Add(this.filterGroup);
            this.Text = "HomeView";
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterStock)).EndInit();
            this.addNewGroup.ResumeLayout(false);
            this.addNewGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblFilterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboFilterCategory;
        private System.Windows.Forms.NumericUpDown numericFilterStock;
        private System.Windows.Forms.GroupBox addNewGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox lblAddDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericAddStock;
        private System.Windows.Forms.ComboBox comboAddCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblAddName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.NumericUpDown numericFilterTotal;
        private System.Windows.Forms.NumericUpDown numericAddTotal;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Print;
    }
}