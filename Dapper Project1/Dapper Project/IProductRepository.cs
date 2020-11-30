using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_Project
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
    }
}
