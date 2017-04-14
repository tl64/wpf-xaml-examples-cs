using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ObservableCollectionExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> observable = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();

            var debut = new[] { "One", "Two", "Three" };
            foreach (var x in debut)
            {
                observable.Add(x);
            }

            MyListBox.ItemsSource = observable;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //with List you won't see added items on screen as List doesn't have an event on added item
            observable.Add(DateTime.Now.ToLongTimeString());
        }
    }
}
