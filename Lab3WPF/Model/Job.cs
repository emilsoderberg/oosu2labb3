using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WPF.Model
{
    class Job : INotifyPropertyChanged
    {
        private int id;
        private string location;
        private string startDate;
        private string endDate;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                RaisePropertyChanged("id");
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                RaisePropertyChanged("location");
            }
        }

        public string StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                RaisePropertyChanged("startDate");
            }
        }

        public string EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                RaisePropertyChanged("endDate");
            }
        }

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
