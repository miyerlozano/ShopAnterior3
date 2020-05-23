using Shop.Common.Models;
using Shop.Common.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Shop.UIForms.ViewModels
{
    public class ProductsViewModel:BaseViewModel
    {

        private readonly ApiService apiService;
        private bool isRefreshing;

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }


        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing , value); }
        }


        public ProductsViewModel()
        {
            this.apiService = new ApiService();

            this.LoadProduct();

        }

        private async void LoadProduct()
        {
            this.IsRefreshing = true;


            var response = await this.apiService.GetListAsync<Product>("https://shopzulu.azurewebsites.net", "/api", "/Products");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            this.IsRefreshing = false;

            var myProducts = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(myProducts);


        }
    }
}
