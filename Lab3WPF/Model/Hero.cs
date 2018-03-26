using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.Model
{
    class Hero : INotifyPropertyChanged
    {
        private int id;
        private string superName;
        private string realName;
        private int age;
        private string city;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                RaisePropertyChanged("id");
            }
        }

        public string SuperName
        {
            get { return superName; }
            set
            {
                superName = value;
                RaisePropertyChanged("superName");
            }
        }

        public string RealName
        {
            get { return realName; }
            set
            {
                realName = value;
                RaisePropertyChanged("realName");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                RaisePropertyChanged("age");
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                RaisePropertyChanged("city");
            }
        }

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
