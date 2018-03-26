using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Datalayer;

namespace Lab3BusinessLayer
{
    public class BusinessManager
    {
        public DataManager dl = new DataManager();

        public List<Hero> listheroes() {
            return dl.listheroes();

        }

        public void RemoveHero(int Id) {
            dl.Remove(Id);

        }

        public void IdName(int Id) {
           
        }

        //Addform
        public List<Ability> listAbilites()
        {
            return dl.listAbilites();
        }

        //Addform
        public void AddHero(string realname, string supername, string city, int age, List<String> skills)
        {
            dl.AddHero(realname, supername, city, age, skills);
        }

        public Hero GetHero(string heroname)
        {
            return dl.GetHero(heroname);
        }
        public void EditHero(string orgSupername, string newSupername, string newName, string newCity, int newAge, List<String> newAbilites)
        {
            dl.EditHero(orgSupername, newSupername, newName, newCity, newAge, newAbilites);
        }
        public void AddJob(List<string> supernames, string location, DateTime startdate, DateTime enddate)
        {
            dl.AddJob(supernames, location, startdate, enddate);
        }
    }
}
