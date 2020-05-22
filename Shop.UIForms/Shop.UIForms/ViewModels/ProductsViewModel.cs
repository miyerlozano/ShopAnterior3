using Shop.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace Shop.UIForms.ViewModels
{
   public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; set; }


    }
}
