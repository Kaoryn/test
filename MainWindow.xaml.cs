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

namespace ЛР1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Pages.ZadT());
        }
    }
}
