using System;
using System.Collections.Generic;
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
using System.IO;

namespace StylesAndThemesLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var theme = new ResourceDictionary();
            //theme.Source = new Uri(Directory.GetCurrentDirectory() + "DarkTheme.xaml");
            //var uri = new Uri(Directory.GetCurrentDirectory() + "\\DarkTheme.xaml");
            var uri = new Uri("DarkTheme.xaml", UriKind.Relative);
            var theme = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(theme);
            //Resources.Add("myTheme", theme);
        }
    }
}
