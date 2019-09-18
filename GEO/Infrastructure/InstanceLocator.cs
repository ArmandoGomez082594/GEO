using System;
namespace GEO.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region Propiedades

        public MainViewModels Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModels();
        }
        #endregion

    }
}
