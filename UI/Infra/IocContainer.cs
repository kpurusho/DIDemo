using DataAccess.Interface;
using SimpleInjector;
using DomainService;
using SqlDataAccess;

namespace DI.Infra
{
    static class IocContainer
    {
        private static readonly Container _container;

        static IocContainer()
        {
            _container = new Container();
            SetupContainer();
        }

        private static void SetupContainer()
        {
            _container.RegisterSingleton<MainWindow>();
            _container.RegisterSingleton<MainWindowViewModel>();
            _container.RegisterSingleton<ProductController>();
            _container.RegisterSingleton<IProductService, ProductService>();
            _container.RegisterSingleton<IProductRepository, SqlProductRepository>();
            _container.Verify();
        }

        public static T GetInstance<T>() where T : class
        {
            return _container.GetInstance<T>();
        }
    }
}
