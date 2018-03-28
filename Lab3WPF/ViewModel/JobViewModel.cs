using Lab3WPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.ViewModel
{
    class JobViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Job> Jobs
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void LoadJobs()
        {
            ObservableCollection<Job> jobs = new ObservableCollection<Job>();

            jobs.Add(new Job { Id = 0, Location = "ingenmansland", StartDate = null, EndDate = null });
            jobs.Add(new Job { Id = 0, Location = "ingenmansland", StartDate = null, EndDate = null });
            jobs.Add(new Job { Id = 0, Location = "ingenmansland", StartDate = null, EndDate = null });

            Jobs = jobs;
        }
    }
}
