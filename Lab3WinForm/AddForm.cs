using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3Datalayer;
using Lab3BusinessLayer;
using Lab3WinForm;

namespace Lab3WinForm
{
    
    public partial class AddForm : Form
    {

        public BusinessManager bl = new BusinessManager();
        private ListBox listBox1;
        public AddForm(ListBox ListBox1)
        {
            InitializeComponent();

            listBox1 = ListBox1;

            

            foreach (Ability item in bl.listAbilites())
            {
                AbilitiesList.Items.Add(item.Name);
            }
        }

        private void AbilitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void RealName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string realname = RealName.Text;
            string supername = SuperName.Text;
            string city = City.Text;
            int age;
            int.TryParse(Age.Text, out age);

            List<String> strabilities = new List<string>();
            foreach (string item in AbilitiesList.CheckedItems)
            {
                strabilities.Add(item);
            }

            bl.AddHero(realname, supername, city, age, strabilities);

            listBox1.Items.Clear();

            foreach (Hero item in bl.listheroes())
            {
                listBox1.Items.Add(item.SuperName);
            }

            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
