using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;


namespace ZXY_IMS.BLL
{
    public class ProductCategory
    {
        public bool AddProductCategory(Models.ProductCategory productCategory)
        {
            Repository.ProductCatalog productCatalog = new Repository.ProductCatalog();
            return productCatalog.AddProductCategory(productCategory);
        }

        public DataTable GetProductCategories()
        {
            Repository.ProductCatalog productCatalog = new Repository.ProductCatalog();
            return productCatalog.GetProductCategories();
        }
    }
}
