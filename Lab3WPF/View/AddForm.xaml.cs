﻿using Lab3WPF.ViewModel;
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
    public partial class AddForm : Window
    {
        public AddForm()
        {
           InitializeComponent();

            AbilityViewModel abilitiesViewModel = new AbilityViewModel();

            abilitiesViewModel.LoadAbilities();

            HeroViewModel heroesViewModel = new HeroViewModel();

            heroesViewModel.LoadHeroes();

            JobViewModel jobsViewModel = new JobViewModel();

            jobsViewModel.LoadJobs();

            DataContext = abilitiesViewModel;
        }

        private void CloseAddForm_Click(object sender, RoutedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }
    }
}
