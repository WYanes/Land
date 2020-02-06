using System;
using System.Collections.Generic;
using System.Text;

namespace Land.ViewModels
{ using Xamarin.Forms;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    public class LoginViewModel
    {
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
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand {
            get
            {
                return new RelayCommand(Login);
            } 
             
        }

        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email))
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
                return;
            }

        }
        #endregion
    }
}
