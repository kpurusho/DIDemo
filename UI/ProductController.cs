using System;
using DomainService;

namespace DI
{
    public class ProductController
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        public Tuple<string, double> GetProduct()
        {
            return _service.GetProductInfo();
        }

        public void SetProduct(Tuple<string, double> product)
        {
            _service.SetProductInfo(product);
        }
    }
}