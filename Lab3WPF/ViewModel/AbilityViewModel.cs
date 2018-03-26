using Lab3WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.ViewModel
{
    class AbilityViewModel
    {
        public ObservableCollection<Ability> Abilities
        {
            get;
            set;
        }

        public void LoadAbilities()
        {
            ObservableCollection<Ability> abilities = new ObservableCollection<Ability>();

            abilities.Add(new Ability { Id = 0, Name = "cancertumor", Cooldown = "fast af", Desc = "rly shit", Dmg = 5 });
            abilities.Add(new Ability { Id = 0, Name = "snoppspagetti", Cooldown = "slow af", Desc = ";)", Dmg = 1 });
            abilities.Add(new Ability { Id = 0, Name = "andreas kastar", Cooldown = "ett per månad", Desc = "aaaduskitkul", Dmg = 10 });

            Abilities = abilities;
        }
    }
}
