using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModel
{
    //View Model
    public class RecordCollectionViewModel:INotifyPropertyChanged
    {
        //The records
        private ObservableCollection<RecordWithTracks> records;
        //The current tracks
        private ObservableCollection<Track> currentTracks;

        //The selected record instance
        private int selectedRecordIndex;

        //The current record
        public RecordWithTracks CurrentRecord
        {
            get
            {
                //Get the current record using the current index
                return records[SelectedRecordIndex];
            }
            set
            {
                //set the value, call property changed
                records[selectedRecordIndex] = value;
                OnPropertyChanged("CurrentRecord");

            }
        }

        //Records Property
        public ObservableCollection<RecordWithTracks> Records
        {
            get
            {
                return records;
            }
            set
            {
                records = value;
                SelectedRecordIndex = 0;
                OnPropertyChanged("Records");
            }
        }

        //Selected Record Index
        public int SelectedRecordIndex
        {
            get
            {
                return selectedRecordIndex;
            }
            set
            {
                //Update the collections based on changes on the index
                selectedRecordIndex = value;
                CurrentRecord = Records[selectedRecordIndex];
                CurrentTracks = new ObservableCollection<Track>(Records[selectedRecordIndex].Tracks);

                OnPropertyChanged("SelectedIndexRecord");
            }
        }

        //The current tracks
        public ObservableCollection<Track> CurrentTracks
        {
            get
            {
                return currentTracks;
            }
            set
            {
                currentTracks = value;
                OnPropertyChanged("CurrentTracks");
            }

        }

        //Property Changed
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public RecordCollectionViewModel()
        {
            //Set the records
            Records = new ObservableCollection<RecordWithTracks>();
            //the index
            SelectedRecordIndex = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
