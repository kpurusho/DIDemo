using System;
using DataAccess.Interface;

namespace SqlDataAccess
{
    public class SqlProductRepository : IProductRepository
    {
        private string _productName = "Laptop";
        private double _productCost = 50000;

        public Tuple<string, double> GetProductInfo()
        {
            return new Tuple<string, double>(_productName, _productCost);
        }

        public void SetProduct(Tuple<string, double> product)
        {
            _productName = product.Item1;
            _productCost = product.Item2;
        }
    }
}
