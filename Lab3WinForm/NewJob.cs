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

    public partial class NewJob : Form
    {
        public BusinessManager bl = new BusinessManager();
        public NewJob()
        {
            InitializeComponent();
            FillHeroList();
        }

        public void FillHeroList()
        {
            foreach (Hero item in bl.listheroes())
            {
                HeroCheckedListBox.Items.Add(item.SuperName);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddJobBtn_Click(object sender, EventArgs e)
        {
            string location = LocationBox.Text;
            List<string> supernames = new List<string>();
            DateTime startdate;
            DateTime enddate;


            DateTime.TryParse(StartDateBox.Text, out startdate);
            DateTime.TryParse(EndDateBox.Text, out enddate);

            foreach (string item in HeroCheckedListBox.CheckedItems)
            {
                supernames.Add(item);
            }

            bl.AddJob(supernames, location, startdate, enddate);

            this.Close();
        }
    }
}
