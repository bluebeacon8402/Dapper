using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_Project
{
    class DapperProductRepository : IProductRepository
    {
        public void CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

    }
}
