using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        BuyerTableAdapter rabitshot= new BuyerTableAdapter();
        public Window3()
        {
            InitializeComponent();
            rabit.ItemsSource = rabitshot.GetData();
            StoreNameComboBox.ItemsSource = rabitshot.GetData();
            StoreNameComboBox.DisplayMemberPath = "name_buyer";
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            rabit.ItemsSource = rabitshot.GetData();
        }
        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();    
        }

        private void StoreNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StoreNameComboBox.SelectedItem != null) 
            {
                var id = (int)(StoreNameComboBox.SelectedItem as DataRowView).Row[0];
                rabit.ItemsSource = rabitshot.filterbuyer(id);
            }
        }
    }
}
