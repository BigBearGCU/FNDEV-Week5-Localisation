using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModel
{
    //INotifyPropertyChanged Contract is used to tell clients that a property has changed. 
    //Typically used for binding clients, which enables two way communication between the 
    //model and UI.
    //Track class, holds the details of a track listed in an album
    public class Track : INotifyPropertyChanged
    {
        private string name;
        private int trackNo;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public List<string> Writers { get; set; }
        public int TrackNo {
            get
            {
                return trackNo;
            }
            set
            {
                trackNo = value;
                OnPropertyChanged("TrackNo");
            }
        }

        public Track()
        {
            Writers = new List<string>();
        }

        //This is the event which is triggered when a proerty changed
        public event PropertyChangedEventHandler PropertyChanged;

        //This method will call the event handlers, this is a common pattern to have
        //a method to make the call
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
