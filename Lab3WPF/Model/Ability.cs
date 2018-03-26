using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.Model
{
    class Ability : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string cooldown;
        private int dmg;
        private string desc;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                RaisePropertyChanged("id");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("name");
            }
        }

        public string Cooldown
        {
            get { return cooldown; }
            set
            {
                cooldown = value;
                RaisePropertyChanged("cooldown");
            }
        }

        public int Dmg
        {
            get { return dmg; }
            set
            {
                dmg = value;
                RaisePropertyChanged("dmg");
            }
        }

        public string Desc
        {
            get { return desc; }
            set
            {
                desc = value;
                RaisePropertyChanged("desc");
            }
        }

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
