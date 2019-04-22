
namespace Versiones4GL.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Helpers;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        #region Atributtes
        private string email;
        private string password;
        private bool isRunning;
       // private bool isRemembered;
        private bool isEnabled;


        #endregion

        #region Properties
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }


        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }


        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsEnabled = true;
            this.IsRemembered = true;
           // this.Email = "jalax@4glsp.com";
            this.Password = "Astrid_18";
           
        }


        #endregion

        #region ICommand

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "EmailValidation",
                   "Accept");

/*                await Application.Current.MainPage.DisplayAlert(
                    Languages.Error,
                    Languages.EmailValidation,
                    Languages.Accept);*/
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "PasswordValidation",
                    "Accept");
               /* await Application.Current.MainPage.DisplayAlert(
                    Languages.Error,
                    Languages.PasswordValidation,
                    Languages.Accept);*/
                return;
            }

            //this.IsRunning = true;
            //this.IsEnabled = false;
        }
        #endregion

    }

}
