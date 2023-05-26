using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using Sebs.Template.Wpf.Mvvm.ViewModel;
using System.Windows;

namespace Sebs.Template.Wpf
{
    /// <summary>
    /// Purpose: 
    /// Created by: $username$
    /// Created at: $time$
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<ShellWindow, ShellViewModel>();
        }
    }
}
