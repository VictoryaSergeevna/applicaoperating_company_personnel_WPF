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
using System.Collections.ObjectModel;

namespace Person
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employer> employers;
        public MainWindow()
        {
            InitializeComponent();
            employers = new ObservableCollection<Employer> { new Employer { Surname = "Иванов", Name = "Иван", Patronymic = "Иванович", Salary = 20000, Company = new Company { Office = "Директор" } } };
               
            list.ItemsSource = employers;
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            Employer emp = new Employer();
            WindowEmployer childWin = new WindowEmployer(emp);
            if (childWin.ShowDialog() == true)
            {
                employers.Add(emp);
            }
        }

        private void Button_ClickEdit(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex != -1)
            {
                Employer emp = list.SelectedItem as Employer;
                WindowEmployer childWin = new WindowEmployer(emp);
                if (childWin.ShowDialog() == true)
                {
                    employers[list.SelectedIndex] =emp;
                }
            }
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex != -1) {              
                employers.RemoveAt(list.SelectedIndex);
              }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления!", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
