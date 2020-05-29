using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Person
{
    public class Employer : INotifyPropertyChanged
    {
        private string surname;

        private string name;

        private string patronymic;

        public int salary;

        private Company company;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged(nameof(Surname));
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (patronymic != value)
                {
                    patronymic = value;
                    OnPropertyChanged(nameof(Surname));
                }
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (salary != value)
                {
                    salary = value;
                    OnPropertyChanged(nameof(Salary));
                }
            }
        }
        public Company Company
        {
            get { return company; }
            set
            {
                if (company != value)
                {
                    company = value;
                    OnPropertyChanged(nameof(Company));
                }
            }
        }

        public override string ToString()
        {
            return $"{Surname}, ${Name}, ${Patronymic}, ${Company}";
        }

        public Employer()
            {
            Company = new Company();
        }
    }
}
