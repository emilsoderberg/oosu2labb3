using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Datalayer
{
    public class DataManager
    {

        public void Remove(int Id)
        {
            using (var db = new Model1Container1())
            {
                var query = from x in db.Heroes.Include("Abilities").Include("Jobs")
                            where x.Id == Id
                            select x;

                foreach (Hero item in query)
                {
                    foreach (var item2 in item.Abilities.ToList())
                    {
                        foreach (var x in item2.Heroes.ToList())
                        {
                            if (x.Id == Id)
                                item2.Heroes.Remove(x);
                            else
                                break;
                        }
                        item.Abilities.Remove(item2);
                    }

                    foreach (Job item3 in item.Jobs.ToList())
                    {
                        foreach (var y in item3.Heroes.ToList())
                        {
                            if (y.Id == Id)
                                item3.Heroes.Remove(y);
                            else break;
                        }
                        item.Jobs.Remove(item3);
                    }

                    db.Heroes.Remove(item);
                }
                db.SaveChanges();
            }
        }

        List<Hero> heroes = new List<Hero>();
        //Addform
        List<Ability> abilities = new List<Ability>();
        public DataManager()
        {
            //Hero leo = new Hero();
            //leo.RealName = "leo";
            //heroes.Add(leo);
        }

        public List<Hero> listheroes()
        {

            using (var db = new Model1Container1())
            {
                ////Skapa hjälte
                //db.Heroes.Add(
                //        new Hero()
                //        {

                //            RealName = "Danieldwdwdwfew",
                //            Age = 18,
                //            City = "Ulricehamn",
                //            SuperName = "GayAswell",
                //            Abilities = new List<Ability>()
                //                        {
                //                            new Ability()
                //                            {
                //                                Cooldown = 12,
                //                                Damage = 100,
                //                                Name = "Sissy Punch!",
                //                                Description = "VERY WEAK PUNCH!"
                //                            }
                //                        },
                //            Jobs = new List<Job>()
                //                        {
                //                            new Job()
                //                            {
                //                                Location = "Borås",
                //                                StartDate = DateTime.Now,
                //                                EndDate = DateTime.Now,
                //                            }
                //                        }
                //        }
                //                );

                //db.SaveChanges();


                //db.Heroes.Add(
                //        new Hero()
                //        {
                //            RealName = "Mikael",
                //            Age = 49,
                //            City = "Kinna",
                //            SuperName = "MikeLike",
                //            Abilities = new List<Ability>()
                //            {
                //                new Ability()
                //                {
                //                    Cooldown = 12,
                //                    Damage = 100,
                //                    Name = "Super Punch!",
                //                    Description = "VERY HARD PUNCH!"
                //                }
                //            },
                //            Jobs = new List<Job>()
                //            {
                //                new Job()
                //                {
                //                    Location = "Karlstad",
                //                    StartDate = DateTime.Now,
                //                    EndDate = DateTime.Now,
                //                }
                //            }
                //        }
                //    );

                //db.SaveChanges();

                var query = from item in db.Heroes.Include("Abilities").Include("Jobs")
                            select item;

                // return query.ToList();

                foreach (var item in query)
                {
                    heroes.Add(item);
                }
                return heroes;

            }

        }
        //Addform
        public List<Ability> listAbilites()
        {
            using (var db = new Model1Container1())
            {
                var query = from item in db.Abilities
                            select item;

                foreach (var item in query)
                {
                    abilities.Add(item);
                }
                return abilities;
            }
        }

        //AddForm
        public void AddHero(string realname, string supername, string city, int age, List<String> skills)
        {
            List<Ability> skill = new List<Ability>();
            using (var db = new Model1Container1())
            {
                foreach (var item in skills)
                {
                    var query = from x in db.Abilities
                                where x.Name == item
                                select x;
                    foreach (var i in query)
                    {
                        skill.Add(i);
                    }
                }
                db.Heroes.Add(
                    new Hero()
                    {
                        RealName = realname,
                        Age = age,
                        City = city,
                        SuperName = supername,
                        Abilities = skill
                    });
                db.SaveChanges();
            }
        }
        public Hero GetHero(string heroname)
        {
            Hero edhero = new Hero();

            using (var db = new Model1Container1())
            {
                var query = from x in db.Heroes.Include("Abilities")
                            where x.SuperName == heroname
                            select x;

                foreach (Hero item in query)
                {
                    edhero = item;
                }

                return edhero;
            }
        }
        public void EditHero(string orgSupername, string newSupername, string newName, string newCity, int newAge, List<string> newAbilites)
        {
            List<Ability> newAbs = new List<Ability>();
            using (var db = new Model1Container1())
            {
                foreach (var item in newAbilites)
                {
                    var abquery = from x in db.Abilities
                                  where x.Name == item
                                  select x;
                    foreach (var i in abquery)
                    {
                        newAbs.Add(i);
                    }
                }
                var query = (from x in db.Heroes.Include("Abilities")
                             where x.SuperName == orgSupername
                             select x);

                foreach (Hero item in query)
                {

                    item.SuperName = newSupername;
                    item.RealName = newName;
                    item.City = newCity;
                    item.Age = newAge;
                    item.Abilities = newAbs;

                }
                db.SaveChanges();
            }

        }
        public void AddJob(List<string> supernames, string location, DateTime startdate, DateTime enddate)
        {
            using (var db = new Model1Container1())
            {
                Job j = db.Jobs1.Add(
                     new Job()
                     {
                         Location = location,
                         StartDate = startdate,
                         EndDate = enddate
                     });
                foreach (string x in supernames)
                {
                    var query = from i in db.Heroes
                                where i.SuperName == x
                                select i;
                    foreach (Hero item in query)
                    {
                        item.Jobs.Add(j);
                    }
                }
                db.SaveChanges();

            }
        }
    }
}
