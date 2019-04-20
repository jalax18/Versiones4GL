namespace Versiones4GL.Infrastructure
{
    using ViewModels;

    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
      /*  public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }*/
        #endregion
    }
}