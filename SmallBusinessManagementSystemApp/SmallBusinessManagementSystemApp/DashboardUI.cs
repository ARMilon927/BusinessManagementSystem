using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBusinessManagementSystemApp
{
    public partial class DashboardUI : Form
    {
        public DashboardUI()
        {
            InitializeComponent();
        }
        private HomeUI _home = new HomeUI();
        private CategoryUI _category ;
        private ProductUI _product;
        private CustomerUI _customer;
        private SupplierUI _supplier;
        private PurchaseUI _purchase;
        private SalesUI _sales;
        private ReportOnPurchase _reportOnPurchase;
        private ReportOnSales _reportOnSales;
        private PurchaseShowUI _purchaseShow;
        private SalesViewUI _salesViewUi;
        private StockInUI _stockInUi;


        private void Dashboard_Load(object sender, EventArgs e)
        {
            _home.MdiParent = this;
           // _home.FormClosed += new FormClosedEventHandler(_home_FormClosed);
            _home.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            _home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _home.Dock = DockStyle.Fill;
            _home.Show();
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_home == null)
            {
                _home = new HomeUI();
                OpenForm(_home);
            }

        }
        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_category == null)
            {
                _category = new CategoryUI();
                OpenForm(_category);
            }
        }
        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_product == null)
            {
                _product = new ProductUI();
                OpenForm(_product);
            }
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_customer == null)
            {
                _customer = new CustomerUI();
                OpenForm(_customer);
            }
        }
        private void newSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_supplier == null)
            {
                _supplier = new SupplierUI();
                OpenForm(_supplier);
            }
        }
        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_purchase == null)
            {
                _purchase = new PurchaseUI();
                OpenForm(_purchase);
            }
        }
        private void newSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_sales == null)
            {
                _sales = new SalesUI();
                OpenForm(_sales);
            }
        }
        private void profitOnSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_reportOnSales == null)
            {
                _reportOnSales = new ReportOnSales();
                OpenForm(_reportOnSales);
            }
        }
        private void profitReportOnPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            _stockInUi = null;
            if (_reportOnPurchase == null)
            {
                _reportOnPurchase = new ReportOnPurchase();
                OpenForm(_reportOnPurchase);
            }
        }
        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"This functionality does not available at this moment", @"Error", MessageBoxButtons.OK,
            //    MessageBoxIcon.Error);
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnPurchase = null;
            _reportOnSales = null;
            _purchaseShow = null;
            _salesViewUi = null;
            if (_stockInUi == null)
            {
                _stockInUi = new StockInUI();
                OpenForm(_stockInUi);
            }
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This functionality does not available at this moment", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This functionality does not available at this moment", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private void OpenForm(Form form)
        {
            form.MdiParent = this;
           // form.FormClosed += new FormClosedEventHandler(category_FormClosed);
            form.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal ;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void showPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnSales = null;
            _reportOnPurchase = null;
            _salesViewUi = null;
            if (_purchaseShow == null)
            {
                _purchaseShow = new PurchaseShowUI();
                OpenForm(_purchaseShow);
            }
        }

        private void showSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _home = null;
            _category = null;
            _product = null;
            _customer = null;
            _supplier = null;
            _purchase = null;
            _sales = null;
            _reportOnSales = null;
            _reportOnPurchase = null;
            _purchaseShow = null;
            if (_salesViewUi == null)
            {
                _salesViewUi = new SalesViewUI();
                OpenForm(_salesViewUi);
            }
        }
    }
}
