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

namespace Person
{
    /// <summary>
    /// Interaction logic for WindowEmployer.xaml
    /// </summary>
    public partial class WindowEmployer : Window
    {
        Employer employers;
        public WindowEmployer(Employer employers)
        {
            InitializeComponent();
            this.employers = employers;
            txtbSurname.Text = employers.Surname;
            txtbName.Text = employers.Name;
            txtbPatronymic.Text = employers.Patronymic;
            txtbSalary.Text = employers.Salary.ToString();
            txtbPosition.Text = employers.Company.Office;
           
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtbSurname.Text == "" || txtbName.Text == "" || txtbPatronymic.Text == "" || txtbPosition.Text == "" || txtbSalary.Text == "")
            {
                MessageBox.Show("Введите все поля!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            else
            {
                employers.Surname = txtbSurname.Text;
                employers.Name = txtbName.Text;
                employers.Patronymic = txtbPatronymic.Text;
                employers.Salary = int.Parse(txtbSalary.Text);
                employers.Company.Office = txtbPosition.Text;
               
              
                this.DialogResult = true;
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
