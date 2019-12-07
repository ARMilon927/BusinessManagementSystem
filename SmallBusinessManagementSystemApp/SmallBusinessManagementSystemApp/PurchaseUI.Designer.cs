namespace SmallBusinessManagementSystemApp
{
    partial class PurchaseUI
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
            this.supplierValidLabel = new System.Windows.Forms.Label();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateValidLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billValidLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remarksTextBox = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufacturedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityValidLabel = new System.Windows.Forms.Label();
            this.categoryValidLabel = new System.Windows.Forms.Label();
            this.productValidLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.previousMrpTextBox = new System.Windows.Forms.TextBox();
            this.previousUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mrpValidLabel = new System.Windows.Forms.Label();
            this.unitPriceValidLabel = new System.Windows.Forms.Label();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.supplierValidLabel);
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.billTextBox);
            this.groupBox1.Controls.Add(this.purchaseDateTimePicker);
            this.groupBox1.Controls.Add(this.dateValidLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.billValidLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(248, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Supplier";
            // 
            // supplierValidLabel
            // 
            this.supplierValidLabel.AutoSize = true;
            this.supplierValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierValidLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierValidLabel.Location = new System.Drawing.Point(265, 78);
            this.supplierValidLabel.Name = "supplierValidLabel";
            this.supplierValidLabel.Size = new System.Drawing.Size(0, 16);
            this.supplierValidLabel.TabIndex = 30;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(123, 77);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(126, 21);
            this.supplierComboBox.TabIndex = 3;
            this.supplierComboBox.ValueMember = "Id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(SmallBusinessManagementSystemApp.Model.Supplier);
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(123, 49);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(126, 20);
            this.billTextBox.TabIndex = 2;
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.purchaseDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.purchaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(123, 16);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(126, 24);
            this.purchaseDateTimePicker.TabIndex = 29;
            this.purchaseDateTimePicker.Value = new System.DateTime(2019, 10, 8, 11, 36, 11, 0);
            // 
            // dateValidLabel
            // 
            this.dateValidLabel.AutoSize = true;
            this.dateValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValidLabel.ForeColor = System.Drawing.Color.Red;
            this.dateValidLabel.Location = new System.Drawing.Point(265, 17);
            this.dateValidLabel.Name = "dateValidLabel";
            this.dateValidLabel.Size = new System.Drawing.Size(0, 16);
            this.dateValidLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // billValidLabel
            // 
            this.billValidLabel.AutoSize = true;
            this.billValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billValidLabel.ForeColor = System.Drawing.Color.Red;
            this.billValidLabel.Location = new System.Drawing.Point(265, 50);
            this.billValidLabel.Name = "billValidLabel";
            this.billValidLabel.Size = new System.Drawing.Size(0, 16);
            this.billValidLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill/Invoice No";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.remarksTextBox);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.expireDateTimePicker);
            this.groupBox2.Controls.Add(this.manufacturedDateTimePicker);
            this.groupBox2.Controls.Add(this.quantityValidLabel);
            this.groupBox2.Controls.Add(this.categoryValidLabel);
            this.groupBox2.Controls.Add(this.productValidLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.productCodeTextBox);
            this.groupBox2.Controls.Add(this.mrpTextBox);
            this.groupBox2.Controls.Add(this.previousMrpTextBox);
            this.groupBox2.Controls.Add(this.previousUnitPriceTextBox);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.unitPriceTextBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mrpValidLabel);
            this.groupBox2.Controls.Add(this.unitPriceValidLabel);
            this.groupBox2.Controls.Add(this.productsComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(180, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 319);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(153, 218);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(464, 62);
            this.remarksTextBox.TabIndex = 31;
            this.remarksTextBox.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(76, 243);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "Remarks";
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expireDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.expireDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDateTimePicker.Location = new System.Drawing.Point(153, 184);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(126, 24);
            this.expireDateTimePicker.TabIndex = 28;
            // 
            // manufacturedDateTimePicker
            // 
            this.manufacturedDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.manufacturedDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturedDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.manufacturedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufacturedDateTimePicker.Location = new System.Drawing.Point(153, 150);
            this.manufacturedDateTimePicker.Name = "manufacturedDateTimePicker";
            this.manufacturedDateTimePicker.Size = new System.Drawing.Size(126, 24);
            this.manufacturedDateTimePicker.TabIndex = 29;
            this.manufacturedDateTimePicker.Value = new System.DateTime(2019, 10, 19, 0, 0, 0, 0);
            // 
            // quantityValidLabel
            // 
            this.quantityValidLabel.AutoSize = true;
            this.quantityValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityValidLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityValidLabel.Location = new System.Drawing.Point(630, 28);
            this.quantityValidLabel.Name = "quantityValidLabel";
            this.quantityValidLabel.Size = new System.Drawing.Size(0, 16);
            this.quantityValidLabel.TabIndex = 25;
            // 
            // categoryValidLabel
            // 
            this.categoryValidLabel.AutoSize = true;
            this.categoryValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryValidLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryValidLabel.Location = new System.Drawing.Point(294, 28);
            this.categoryValidLabel.Name = "categoryValidLabel";
            this.categoryValidLabel.Size = new System.Drawing.Size(0, 16);
            this.categoryValidLabel.TabIndex = 25;
            // 
            // productValidLabel
            // 
            this.productValidLabel.AutoSize = true;
            this.productValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productValidLabel.ForeColor = System.Drawing.Color.Red;
            this.productValidLabel.Location = new System.Drawing.Point(294, 59);
            this.productValidLabel.Name = "productValidLabel";
            this.productValidLabel.Size = new System.Drawing.Size(0, 16);
            this.productValidLabel.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(426, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(61, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "Expire Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Manufactured Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Available Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Code";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(496, 28);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 27;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Enabled = false;
            this.availableQuantityTextBox.Location = new System.Drawing.Point(153, 120);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(126, 20);
            this.availableQuantityTextBox.TabIndex = 27;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Enabled = false;
            this.productCodeTextBox.Location = new System.Drawing.Point(153, 90);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(126, 20);
            this.productCodeTextBox.TabIndex = 27;
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Enabled = false;
            this.mrpTextBox.Location = new System.Drawing.Point(496, 188);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(121, 20);
            this.mrpTextBox.TabIndex = 21;
            this.mrpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mrpTextBox_KeyPress);
            // 
            // previousMrpTextBox
            // 
            this.previousMrpTextBox.Enabled = false;
            this.previousMrpTextBox.Location = new System.Drawing.Point(496, 156);
            this.previousMrpTextBox.Name = "previousMrpTextBox";
            this.previousMrpTextBox.Size = new System.Drawing.Size(121, 20);
            this.previousMrpTextBox.TabIndex = 21;
            // 
            // previousUnitPriceTextBox
            // 
            this.previousUnitPriceTextBox.Enabled = false;
            this.previousUnitPriceTextBox.Location = new System.Drawing.Point(496, 124);
            this.previousUnitPriceTextBox.Name = "previousUnitPriceTextBox";
            this.previousUnitPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.previousUnitPriceTextBox.TabIndex = 22;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(542, 288);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(496, 92);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalPriceTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Unit Price (Tk)";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(496, 60);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.unitPriceTextBox.TabIndex = 24;
            this.unitPriceTextBox.TextChanged += new System.EventHandler(this.unitPriceTextBox_TextChanged);
            this.unitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitPriceTextBox_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(417, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "MRP (Tk)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Price (Tk)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(361, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Previous MRP (Tk)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Previous Unit Price (Tk)";
            // 
            // mrpValidLabel
            // 
            this.mrpValidLabel.AutoSize = true;
            this.mrpValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrpValidLabel.ForeColor = System.Drawing.Color.Red;
            this.mrpValidLabel.Location = new System.Drawing.Point(630, 188);
            this.mrpValidLabel.Name = "mrpValidLabel";
            this.mrpValidLabel.Size = new System.Drawing.Size(0, 16);
            this.mrpValidLabel.TabIndex = 17;
            // 
            // unitPriceValidLabel
            // 
            this.unitPriceValidLabel.AutoSize = true;
            this.unitPriceValidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceValidLabel.ForeColor = System.Drawing.Color.Red;
            this.unitPriceValidLabel.Location = new System.Drawing.Point(630, 60);
            this.unitPriceValidLabel.Name = "unitPriceValidLabel";
            this.unitPriceValidLabel.Size = new System.Drawing.Size(0, 16);
            this.unitPriceValidLabel.TabIndex = 17;
            // 
            // productsComboBox
            // 
            this.productsComboBox.DataSource = this.productBindingSource;
            this.productsComboBox.DisplayMember = "Name";
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(153, 59);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(126, 21);
            this.productsComboBox.TabIndex = 15;
            this.productsComboBox.ValueMember = "Id";
            this.productsComboBox.TextChanged += new System.EventHandler(this.productsComboBox_TextChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SmallBusinessManagementSystemApp.Model.Product);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Products";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(153, 28);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(126, 21);
            this.categoryComboBox.TabIndex = 15;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.TextChanged += new System.EventHandler(this.categoryComboBox_TextChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SmallBusinessManagementSystemApp.Model.Category);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Category";
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AllowUserToAddRows = false;
            this.purchaseDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.purchaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseDataGridView.Location = new System.Drawing.Point(180, 506);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(700, 105);
            this.purchaseDataGridView.TabIndex = 14;
            this.purchaseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDataGridView_CellClick);
            this.purchaseDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.purchaseDataGridView_CellFormatting);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(805, 617);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 25);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(177, 120);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "-1";
            this.idLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 30);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Purchase";
            // 
            // PurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label dateValidLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label billValidLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox previousMrpTextBox;
        private System.Windows.Forms.TextBox previousUnitPriceTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label unitPriceValidLabel;
        private System.Windows.Forms.ComboBox productsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label productValidLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label quantityValidLabel;
        private System.Windows.Forms.Label categoryValidLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.DateTimePicker expireDateTimePicker;
        private System.Windows.Forms.DateTimePicker manufacturedDateTimePicker;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox remarksTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label supplierValidLabel;
        private System.Windows.Forms.Label mrpValidLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}