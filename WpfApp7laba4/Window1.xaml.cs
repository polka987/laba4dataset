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
using System.Windows.Shapes;
using WpfApp7laba4.plushlan123DataSetTableAdapters;

namespace WpfApp7laba4
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        public Window1()
        {
            InitializeComponent();
            Catshot.ItemsSource = products.GetData();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Catshot.ItemsSource = products.SearchByProduct(SearchText.Text);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
