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
    public partial class Form1 : Form
    {
        public BusinessManager bl = new BusinessManager();
        
        
        public Form1()
        {
            InitializeComponent();
            UpdateForm();
        }


        public string SendHeroEdit()
        {
            string heroedit = listBox1.SelectedItem.ToString();
            return heroedit;
        }
        //public string _sendHeroName
        //{
        //    get { return listBox1.SelectedItem.ToString(); }
        //}

        public void UpdateForm()
        {
            foreach (Hero item in bl.listheroes())
            {
                listBox1.Items.Add(item.SuperName);
            }
        }



        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }


        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                listBox1.SelectedIndex = 0;
            }
            foreach (Hero item in bl.listheroes())
            {
                if (item.SuperName.ToString() == listBox1.SelectedItem.ToString())
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Hero Name =" + " " + item.SuperName);
                    listBox2.Items.Add("Real Name =" + " " + item.RealName);
                    listBox2.Items.Add("Age = " + item.Age);
                    listBox2.Items.Add("City = " + item.City);

                    AbilitiesList.Items.Clear();

                    foreach (var x in item.Abilities)
                      {
                        AbilitiesList.Items.Add(x.Name);
                      }

                    JobList.Items.Clear();
                    int nr = 1;
                    foreach (var i in item.Jobs)
                    {
                        JobList.Items.Add("Nr =" + nr);
                        JobList.Items.Add("Location =" + i.Location);
                        JobList.Items.Add("Start date =" + i.StartDate);
                        JobList.Items.Add("End date =" + i.EndDate);
                        nr++;
                    }
                }

            }

            string selectedHero = listBox1.SelectedItem.ToString();



            //foreach (Hero h in bl.dl.listheroes())
            //{
            //    listBox1.Text = "derp";//+= h.RealName;
            //    listBox1.Update();
            //}
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string heroedit = SendHeroEdit();
            EditForm editform = new EditForm(listBox1);
            editform.GetHero(heroedit);
            editform.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddForm(listBox1);
            form.Show(this);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Hero item in bl.listheroes())
                if (item.SuperName.ToString() == listBox1.SelectedItem.ToString())
                {                
                    bl.RemoveHero(item.Id);
                }
            listBox1.Items.Remove(listBox1.SelectedItem);


            //foreach (Hero item in bl.listheroes())
            //{
            //    listBox1.Items.Add(item.SuperName);
            //}
        }

        private void AddJobBtn_Click(object sender, EventArgs e)
        {
            var form = new NewJob();
            form.Show(this);
        }
    }
}
