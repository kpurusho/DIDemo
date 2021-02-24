using System;

namespace DomainService
{
    public interface IProductService
    {
        Tuple<string, double> GetProductInfo();
        void SetProductInfo(Tuple<string, double> product);
    }
}