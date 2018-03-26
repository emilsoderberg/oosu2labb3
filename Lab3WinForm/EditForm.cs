using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3BusinessLayer;
using Lab3Datalayer;

namespace Lab3WinForm
{
    public partial class EditForm : Form
    {
        public Form1 frm1 = new Form1();
        public BusinessManager bl = new BusinessManager();
        private ListBox listBox1;
        //string superheroname;
        public EditForm(ListBox ListBox1)
        {
            InitializeComponent();
            listBox1 = ListBox1;
            //GetHero();
        }

        public void GetHero(string superheroname)
        {
            Hero edhero = new Hero();
            string heroname = superheroname;
            edhero = bl.GetHero(heroname);

            foreach (Ability ab in edhero.Abilities)
            {
                AbilityListView.Items.Add(ab.Name);
            }

            SuperName.Text = edhero.SuperName;
            RealName.Text = edhero.RealName;
            Age.Text = edhero.Age.ToString();
            City.Text = edhero.City;

            OriginalSuperName.Text = edhero.SuperName;
            OriginalName.Text = edhero.RealName;
            OriginalCity.Text = edhero.City;
            OriginalAge.Text = edhero.Age.ToString();

            foreach (Ability item in bl.listAbilites())
            {
                AbilitiesList.Items.Add(item.Name);
            }
        }


        //public string _GetSuperName
        //{
        //    set {superheroname = value; }
        //}



        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void RealName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<string> newAbilites = new List<string>();
            int newAge;
            int.TryParse(Age.Text, out newAge);

            foreach (string item in AbilitiesList.CheckedItems)
            {
                newAbilites.Add(item);
            }
            bl.EditHero(OriginalSuperName.Text, SuperName.Text, RealName.Text, City.Text, newAge, newAbilites);

            listBox1.Items.Clear();

            foreach (Hero item in bl.listheroes())
            {
                listBox1.Items.Add(item.SuperName);
            }

            this.Close();
        }
    }
}
