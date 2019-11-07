using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FluentRibbonBackstage
{
    /// <summary>
    /// Interaction logic for BackstageControl.xaml
    /// </summary>
    public partial class BackstageControl : UserControl
    {
        public BackstageControl()
        {
            InitializeComponent();

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"LOADED EVENT");
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"UNLOADED EVENT");
        }
    }
}
