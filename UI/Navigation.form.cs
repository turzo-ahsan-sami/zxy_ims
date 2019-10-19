using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXY_IMS.UI
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        public void NavigateToForm(Form form, Panel panel)
        {
            form.TopLevel = false;
            //form.Size = panel.Size;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            NavigateToForm(home, navFlowLayoutPanel);
        }

        private void productcategoryButton_Click(object sender, EventArgs e)
        {
            ProductCatalog.ProductCategory category = new ProductCatalog.ProductCategory();
            NavigateToForm(category, navFlowLayoutPanel);
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ProductCatalog.Product product = new ProductCatalog.Product();
            NavigateToForm(product, navFlowLayoutPanel);
        }

    }

}
