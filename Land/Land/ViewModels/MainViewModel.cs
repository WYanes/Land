using System;
using System.Collections.Generic;
using System.Text;

namespace Land.ViewModels
{
    public class MainViewModel
    {
        #region View Models
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
