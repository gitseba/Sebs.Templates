using Sebs.Template.Wpf.Features.Commands;
using System.Windows;
using System.Windows.Input;

namespace Sebs.Template.Wpf.Mvvm.ViewModel
{
    /// <summary>
    /// Purpose: 
    /// Created by: $username$
    /// Created at: $time$
    /// </summary>
    public class ShellViewModel : BaseViewModel
    {
        public ShellViewModel()
        {
            // Window commands
            MinimizeCommand = new RelayCommand((p) => { WindowState = WindowState.Minimized; });
            MaximizeCommand = new RelayCommand((p) => { WindowState = WindowState.Maximized; });
            CloseCommand = new RelayCommand((p) => (p as Window)?.Close());
        }

        #region Binding properties
        public WindowState WindowState { get; set; } = WindowState.Normal;
        #endregion

        #region ICommands
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        #endregion
    }
}
