using System;

namespace DataAccess.Interface
{
    public interface IProductRepository
    {
        Tuple<string,double> GetProductInfo();
        void SetProduct(Tuple<string, double> product);
    }
}
