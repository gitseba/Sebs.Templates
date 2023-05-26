using Sebs.Template.Wpf.Features;
using System.Windows;

namespace Sebs.Template.Wpf
{
    /// <summary>
    /// Purpose: 
    /// Created by: $username$
    /// Created at: $time$
    /// </summary>
    public partial class ShellWindow : Window
    {
        public ShellWindow()
        {
            InitializeComponent();

            //When window is resized, without this class,it's going over the screen edges.
            //This class keeps the window in the screen.
            //reference: 2:02:30 => https://youtu.be/TDOxHx-AMqQ?t=7350
            _ = new WindowResizer(this);
        }
    }
}
