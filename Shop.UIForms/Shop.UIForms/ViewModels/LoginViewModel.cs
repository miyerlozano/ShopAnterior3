

namespace Shop.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class LoginViewModel
    {



        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);


        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a email", "Accept");
                return;

            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a password", "Accept");
                return;

            }

            if(!this.Email.Equals("miyerlozanos@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "User or Password Incorrect", "Accept");
                return;


            }


            await Application.Current.MainPage.DisplayAlert("Ok", "Fuck Full Yeah!!!", "Accept");
        }
    }
}
