using ClassLibrary1;
using DI.Infra;
using DomainService;
using System.Windows;

namespace DI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //FileProductRepository productRepository = new FileProductRepository();
            //ProductService service = new ProductService(productRepository);
            //ProductController controller = new ProductController(service);

            //new MainWindow(new MainWindowViewModel(controller)).Show();
            IocContainer.GetInstance<MainWindow>().Show();
        }
    }
}
