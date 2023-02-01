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

namespace ЛР1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZadT.xaml
    /// </summary>
    public partial class ZadT : Page
    {
        public ZadT()
        {
            InitializeComponent();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            label1.Content = "Привет";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "До свидания";
        }
    }
}
