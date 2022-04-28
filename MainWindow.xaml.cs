using couse_work_web.ModelsApi;
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

namespace couse_work_web
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

        private static async Task NewMethod()
        {
            var all_books = await Api.PostAsync<SearchBook, BookApi[]>(new SearchBook { SearchName = "" }, "Books/search");
           
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Task.Run(NewMethod); // тестовый запуск
            AddWindow addWindow = new AddWindow();
            addWindow.Owner = this;
            addWindow.Show();
           

        } 

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }

        private void SortList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OnClick1(object sender, RoutedEventArgs e)
        {

            


        }



    }
}
