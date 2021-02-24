using System;
using DataAccess.Interface;

namespace DomainService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly double _gst = 1.18;
        private readonly double _rollBackGst = 1/1.18;

        public ProductService(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public Tuple<string, double> GetProductInfo()
        {
            var productInfo = _repository.GetProductInfo();
            productInfo = ApplyGst(productInfo);
            return productInfo;
        }

        public void SetProductInfo(Tuple<string, double> product)
        {
            product = RollBackGst(product);
            _repository.SetProduct(product);
        }

        private Tuple<string, double> ApplyGst(Tuple<string, double> productInfo)
        {
            return new Tuple<string, double>(productInfo.Item1, productInfo.Item2 * _gst);
        }

        private Tuple<string, double> RollBackGst(Tuple<string, double> productInfo)
        {
            return new Tuple<string, double>(productInfo.Item1, productInfo.Item2 * _rollBackGst);
        }
    }
}