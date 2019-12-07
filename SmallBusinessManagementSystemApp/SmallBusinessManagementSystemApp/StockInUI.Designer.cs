namespace SmallBusinessManagementSystemApp
{
    partial class StockInUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.lostCheckBox = new System.Windows.Forms.CheckBox();
            this.damageCheckBox = new System.Windows.Forms.CheckBox();
            this.expiredCheckBox = new System.Windows.Forms.CheckBox();
            this.reorderCheckBox = new System.Windows.Forms.CheckBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.categoryValidLabel = new System.Windows.Forms.Label();
            this.productValidLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stockInDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockInDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockShowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.lostCheckBox);
            this.groupBox1.Controls.Add(this.damageCheckBox);
            this.groupBox1.Controls.Add(this.expiredCheckBox);
            this.groupBox1.Controls.Add(this.reorderCheckBox);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(185, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Search by: Category, Product";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(61, 49);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(522, 26);
            this.searchTextBox.TabIndex = 36;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(496, 127);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            // 
            // lostCheckBox
            // 
            this.lostCheckBox.AutoSize = true;
            this.lostCheckBox.Location = new System.Drawing.Point(415, 131);
            this.lostCheckBox.Name = "lostCheckBox";
            this.lostCheckBox.Size = new System.Drawing.Size(46, 17);
            this.lostCheckBox.TabIndex = 34;
            this.lostCheckBox.Text = "Lost";
            this.lostCheckBox.UseVisualStyleBackColor = true;
            this.lostCheckBox.Visible = false;
            // 
            // damageCheckBox
            // 
            this.damageCheckBox.AutoSize = true;
            this.damageCheckBox.Location = new System.Drawing.Point(297, 131);
            this.damageCheckBox.Name = "damageCheckBox";
            this.damageCheckBox.Size = new System.Drawing.Size(66, 17);
            this.damageCheckBox.TabIndex = 34;
            this.damageCheckBox.Text = "Damage";
            this.damageCheckBox.UseVisualStyleBackColor = true;
            this.damageCheckBox.Visible = false;
            // 
            // expiredCheckBox
            // 
            this.expiredCheckBox.AutoSize = true;
            this.expiredCheckBox.Location = new System.Drawing.Point(179, 131);
            this.expiredCheckBox.Name = "expiredCheckBox";
            this.expiredCheckBox.Size = new System.Drawing.Size(61, 17);
            this.expiredCheckBox.TabIndex = 34;
            this.expiredCheckBox.Text = "Expired";
            this.expiredCheckBox.UseVisualStyleBackColor = true;
            this.expiredCheckBox.Visible = false;
            // 
            // reorderCheckBox
            // 
            this.reorderCheckBox.AutoSize = true;
            this.reorderCheckBox.Location = new System.Drawing.Point(61, 131);
            this.reorderCheckBox.Name = "reorderCheckBox";
            this.reorderCheckBox.Size = new System.Drawing.Size(98, 17);
            this.reorderCheckBox.TabIndex = 34;
            this.reorderCheckBox.Text = "Re-Order Level";
            this.reorderCheckBox.UseVisualStyleBackColor = true;
            this.reorderCheckBox.Visible = false;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(455, 19);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(126, 24);
            this.endDateTimePicker.TabIndex = 32;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(136, 19);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(126, 24);
            this.startDateTimePicker.TabIndex = 33;
            this.startDateTimePicker.Value = new System.DateTime(2019, 10, 8, 11, 36, 11, 0);
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(364, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "End Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Start Date";
            // 
            // categoryValidLabel
            // 
            this.categoryValidLabel.AutoSize = true;
            this.categoryValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryValidLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryValidLabel.Location = new System.Drawing.Point(258, 476);
            this.categoryValidLabel.Name = "categoryValidLabel";
            this.categoryValidLabel.Size = new System.Drawing.Size(0, 16);
            this.categoryValidLabel.TabIndex = 36;
            this.categoryValidLabel.Visible = false;
            // 
            // productValidLabel
            // 
            this.productValidLabel.AutoSize = true;
            this.productValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productValidLabel.ForeColor = System.Drawing.Color.Red;
            this.productValidLabel.Location = new System.Drawing.Point(260, 507);
            this.productValidLabel.Name = "productValidLabel";
            this.productValidLabel.Size = new System.Drawing.Size(0, 16);
            this.productValidLabel.TabIndex = 37;
            this.productValidLabel.Visible = false;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(123, 507);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(126, 21);
            this.productComboBox.TabIndex = 18;
            this.productComboBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Products";
            this.label9.Visible = false;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(123, 476);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(126, 21);
            this.categoryComboBox.TabIndex = 19;
            this.categoryComboBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Category";
            this.label8.Visible = false;
            // 
            // stockInDataGridView
            // 
            this.stockInDataGridView.AllowUserToAddRows = false;
            this.stockInDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockInDataGridView.AutoGenerateColumns = false;
            this.stockInDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockInDataGridView.ColumnHeadersHeight = 30;
            this.stockInDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.codeDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.reorderDataGridViewTextBoxColumn,
            this.openingBalanceDataGridViewTextBoxColumn,
            this.quantityInDataGridViewTextBoxColumn,
            this.quantityOutDataGridViewTextBoxColumn,
            this.closingBalanceDataGridViewTextBoxColumn});
            this.stockInDataGridView.DataSource = this.stockShowBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockInDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.stockInDataGridView.Location = new System.Drawing.Point(185, 246);
            this.stockInDataGridView.Name = "stockInDataGridView";
            this.stockInDataGridView.ReadOnly = true;
            this.stockInDataGridView.Size = new System.Drawing.Size(639, 206);
            this.stockInDataGridView.TabIndex = 7;
            this.stockInDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stockInDataGridView_RowPostPaint);
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reorderDataGridViewTextBoxColumn
            // 
            this.reorderDataGridViewTextBoxColumn.DataPropertyName = "Reorder";
            this.reorderDataGridViewTextBoxColumn.HeaderText = "Reorder";
            this.reorderDataGridViewTextBoxColumn.Name = "reorderDataGridViewTextBoxColumn";
            this.reorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openingBalanceDataGridViewTextBoxColumn
            // 
            this.openingBalanceDataGridViewTextBoxColumn.DataPropertyName = "OpeningBalance";
            this.openingBalanceDataGridViewTextBoxColumn.HeaderText = "Opening";
            this.openingBalanceDataGridViewTextBoxColumn.Name = "openingBalanceDataGridViewTextBoxColumn";
            this.openingBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInDataGridViewTextBoxColumn
            // 
            this.quantityInDataGridViewTextBoxColumn.DataPropertyName = "QuantityIn";
            this.quantityInDataGridViewTextBoxColumn.HeaderText = "In";
            this.quantityInDataGridViewTextBoxColumn.Name = "quantityInDataGridViewTextBoxColumn";
            this.quantityInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityOutDataGridViewTextBoxColumn
            // 
            this.quantityOutDataGridViewTextBoxColumn.DataPropertyName = "QuantityOut";
            this.quantityOutDataGridViewTextBoxColumn.HeaderText = "Out";
            this.quantityOutDataGridViewTextBoxColumn.Name = "quantityOutDataGridViewTextBoxColumn";
            this.quantityOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closingBalanceDataGridViewTextBoxColumn
            // 
            this.closingBalanceDataGridViewTextBoxColumn.DataPropertyName = "ClosingBalance";
            this.closingBalanceDataGridViewTextBoxColumn.HeaderText = "Closing";
            this.closingBalanceDataGridViewTextBoxColumn.Name = "closingBalanceDataGridViewTextBoxColumn";
            this.closingBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockShowBindingSource
            // 
            this.stockShowBindingSource.DataSource = typeof(SmallBusinessManagementSystemApp.Model.StockShow);
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.categoryValidLabel);
            this.Controls.Add(this.stockInDataGridView);
            this.Controls.Add(this.productValidLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.productComboBox);
            this.Name = "StockInUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockInDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockShowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox lostCheckBox;
        private System.Windows.Forms.CheckBox damageCheckBox;
        private System.Windows.Forms.CheckBox expiredCheckBox;
        private System.Windows.Forms.CheckBox reorderCheckBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView stockInDataGridView;
        private System.Windows.Forms.Label categoryValidLabel;
        private System.Windows.Forms.Label productValidLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockShowBindingSource;
    }
}