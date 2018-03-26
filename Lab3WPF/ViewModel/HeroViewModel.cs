using Lab3WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.ViewModel
{
    class HeroViewModel
    {
        public ObservableCollection<Hero> Heroes
        {
            get;
            set;
        }

        public void LoadHeroes()
        {
            ObservableCollection<Hero> heroes = new ObservableCollection<Hero>();

            heroes.Add(new Hero { Id = 0, SuperName = "suckadickman", RealName = "patrik star", Age = 5, City = "bikinibottom" });
            heroes.Add(new Hero { Id = 1, SuperName = "idgafman", RealName = "spongewad testacle", Age = 10, City = "danmarkköping" });
            heroes.Add(new Hero { Id = 2, SuperName = "cancerman", RealName = "cadencer blurp", Age = 21, City = "vegas" });

            Heroes = heroes;
        }
    }
}
