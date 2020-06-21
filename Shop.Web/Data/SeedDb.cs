﻿
namespace Shop.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using Shop.Web.Helpers;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private Random random;

        public SeedDb(DataContext context,IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();


            var user = await this.userHelper.GetUserByEmailAsync("mlozanos@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Miyer",
                    LastName = "Lozano",
                    Email = "mlozanos@gmail.com",
                    UserName = "mlozanos@gmail.com",
                    PhoneNumber = "3503256789"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }


            if (!this.context.Products.Any())
            {
                this.AddProduct("Iphone X",user);
                this.AddProduct("Magic Mouse",user);
                this.AddProduct("iWatch Series 4",user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            this.context.Products.Add(new Product
            {
                ProSer = name,
                               
                User=user


            });
        }
    }

}
