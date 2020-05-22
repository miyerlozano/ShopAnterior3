﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.UIForms.ViewModels
{
    public class MainViewModel
    {

        public LoginViewModel Login { get; set; }

        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
    }
}
