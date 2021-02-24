using System;
using System.Windows.Input;

namespace DI
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _productName;
        private double _productCost;

        public MainWindowViewModel(ProductController controller)
        {
            Controller = controller;
            SetCommand = new RelayCommand(ExecuteSetCommand);
            GetCommand = new RelayCommand(ExecuteGetCommand);
            ClearCommand = new RelayCommand(ExecuteClearCommand);
        }

        public ProductController Controller { get; set; }

        private void ExecuteClearCommand()
        {
            ProductName = string.Empty;
            ProductCost = 0.0;
        }

        private void ExecuteGetCommand()
        {
            var response = Controller.GetProduct();
            ProductName = response.Item1;
            ProductCost = response.Item2;
        }

        private void ExecuteSetCommand()
        {
            Controller.SetProduct(new Tuple<string, double>(ProductName, ProductCost));
        }

        public string ProductName
        {
            get => _productName;
            set => SetProperty(ref _productName, value, "ProductName");
        }

        public double ProductCost
        {
            get => _productCost;
            set => SetProperty(ref _productCost, value, "ProductCost");
        }

        public ICommand SetCommand { get; set; }
        public ICommand GetCommand { get; set; }
        public ICommand ClearCommand { get; set; }

    }
}