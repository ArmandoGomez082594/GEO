using System;
using System.ComponentModel;
using System.Windows.Input;


using Xamarin.Forms;

namespace GEO.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    public class LoginViewModel: BaseViewModel
    {

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion
        #region Properties
        public String Email
      
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public String Password
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

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
            
        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
            
        }

        

        private async void Login()
        {
            if(String.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",

                    "Debes ingresar un Correo",
                    "Aceptar");
                return;
            }
            if(String.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes Ingrsar la Contraseña",
                    "Aceptar");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;
            if(this.Email != "jesusgomez@axsistec.com" || this.Password != "jesusa1**")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Correo o contraseña Invalidos",
                    "Aceptar");
                this.Password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = String.Empty;
            this.Password = String.Empty;

            MainViewModels.Getinstance().GEO = new GEOVIewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new GEOPage());
        }
        #endregion

    }
}
