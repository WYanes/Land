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
            get
            {
                return this.password;
            }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.Password)));
                }
            }
        }

        public bool IsRunning {
            get
            {
                return this.isRunning;
            }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.IsRunning)));
                }
            }
        }

        public bool IsRemembered { get; set; }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.IsEnabled)));
                }
            }
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

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "willianguitarflash6@gmail.com" || this.Password != "2345")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert("Error",
                    "Error email or password incorrect",
                    "Accept");
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.DisplayAlert("OK",
                    "Jejejej",
                    "Accept");
        }
        #endregion
    }
}
