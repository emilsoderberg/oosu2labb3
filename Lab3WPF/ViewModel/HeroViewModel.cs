using Lab3WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.ViewModel
{
    class HeroViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Hero> Heroes
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void LoadHeroes()
        {
            ObservableCollection<Hero> heroes = new ObservableCollection<Hero>();

            heroes.Add(new Hero { Id = 0, SuperName = "Skalman", RealName = "patrik star", Age = 5, City = "bikinibottom" });
            heroes.Add(new Hero { Id = 1, SuperName = "idgafman", RealName = "svamp", Age = 10, City = "danmarkköping" });
            heroes.Add(new Hero { Id = 2, SuperName = "Troll", RealName = "cadencer blurp", Age = 21, City = "vegas" });

            Heroes = heroes;
        }
    }
}
