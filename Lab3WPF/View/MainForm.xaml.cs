using Lab3WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3WPF.View
{
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();

            AbilityViewModel abilitiesViewModel = new AbilityViewModel();

            abilitiesViewModel.LoadAbilities();

            HeroViewModel heroesViewModel = new HeroViewModel();

            heroesViewModel.LoadHeroes();

            JobViewModel jobsViewModel = new JobViewModel();

            jobsViewModel.LoadJobs();


            myListViewOfHeroes.DataContext = heroesViewModel;
            //DataContext = heroesViewModel;
        }

        private void AddFormButton_Click(object sender, RoutedEventArgs e)
        {
            AddForm af = new AddForm();
            af.Show();
            this.Close();

        }

        private void EditFormButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EEEEButton is clicked!");
        }

        private void RemoveHeroButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RRRRRButton is clicked!");
        }

        private void myListViewOfHeroes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //myListViewOfHeroAbilities.DataContext = myListViewOfHeroes.SelectedItem
        }
    }
}
