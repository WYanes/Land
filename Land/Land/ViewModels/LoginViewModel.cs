using System;
using System.Collections.Generic;
using System.Text;

namespace Land.ViewModels
{
    using Xamarin.Forms;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using System.ComponentModel;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }

        public bool IsRunning { get; set; }

        public bool IsRemembered { get; set; }

        public bool IsEnabled
        {
            get;
            set;
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
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "You must enter a email.",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "You must enter a Password.",
                    "Accept");
                this.Password = string.Empty;
                return;
            }

            if (this.Email != "willianguitarflash6@gmail.com" || this.Password != "2345")
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "Error email or password incorrect",
                    "Accept");
                return;
            }

            await Application.Current.MainPage.DisplayAlert("OK",
                    "Jejejej",
                    "Accept");
        }
        #endregion
    }
}
