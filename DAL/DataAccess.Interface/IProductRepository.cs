using System;

namespace DataAccess.Interface
{
    //public abstract class ProductRepository
    //{
    //    public virtual Tuple<string, double> GetProductInfo() 
    //    { 
    //        return new Tuple<string, double>("dummy", 0.0); 
    //    }
    //    public abstract void SetProduct(Tuple<string, double> product);
    //}

    //public class CloudRepo : ProductRepository
    //{
    //    public override Tuple<string, double> GetProductInfo()
    //    {
    //        return base.GetProductInfo();
    //    }
    //    public override void SetProduct(Tuple<string, double> product)
    //    {
    //        //implementation
    //    }
    //}

    //ProductService -> SqlRepo
    //      |
	//      V

    //ProductSerice -> Data.Interface<- SqlRepo
    //            <- FileRepo
    //            <- CloudRepo


    public interface IProductRepository
    {
        Tuple<string, double> GetProductInfo();
        void SetProduct(Tuple<string, double> product);
    }
}
