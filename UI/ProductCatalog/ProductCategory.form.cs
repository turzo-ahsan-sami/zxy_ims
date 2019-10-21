using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ZXY_IMS.Models;
//using ZXY_IMS.BLL;

namespace ZXY_IMS.UI.ProductCatalog
{
    public partial class ProductCategory : Form
    {
        public ProductCategory()
        {
            InitializeComponent();
            DisplayProductCategories();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string code = codeTextBox.Text.Trim();
            string name = nameTextBox.Text.Trim();
            if (!CheckValidation(code, name)) MessageBox.Show("Invalid Inputs");

            Models.ProductCategory productCategory = new Models.ProductCategory();
            productCategory.Code = code;
            productCategory.CategoryName = name;

            BLL.ProductCategory _productCategory = new BLL.ProductCategory();
            if (!_productCategory.AddProductCategory(productCategory)) return;

            DisplayProductCategories();
        }      

        private void DisplayProductCategories()
        {
            BLL.ProductCategory _productCategory = new BLL.ProductCategory();
            categoriesDataGridView.DataSource = _productCategory.GetProductCategories();
        }

        private bool CheckValidation(string code, string name)
        {
            if (string.IsNullOrEmpty(code)) return false;
            if (string.IsNullOrEmpty(name)) return false;
            return true;
        }
    }
}
