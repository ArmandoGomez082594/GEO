using System;
namespace GEO.ViewModels
{
    public class MainViewModels
    {
        #region ViewModels
        public  LoginViewModel Login
        {
            get;
            set;
        }
        public GEOVIewModel GEO
        {
            get;
            set;
        }
        #endregion
        #region Contructors
        public MainViewModels()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion
        #region Singleton
        private static MainViewModels instance;
        public static MainViewModels Getinstance()
        {
            if (instance == null)
            {
                return new MainViewModels();
            }

            return instance;
        }
        #endregion
    }
}
