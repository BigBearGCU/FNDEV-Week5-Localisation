using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModel
{
    //This is just an example
    public class RecordWithNotification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public enum RecordGenre
        {
            Rock,
            Blues,
            Classical,
            Country,
            Rap,
            Pop
        }

        private string name;
        private string artist;
        private DateTime releaseDate;
        private RecordGenre genre;

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

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
                OnPropertyChanged("Artist");
            }
        }

        public DateTime ReleaseDate {
            get { 
                return releaseDate; 
            }
            set { 
                releaseDate = value;
                OnPropertyChanged("ReleaseDate");
            }
        }

        public RecordGenre Genre {
            get { 
                return genre; 
            }
            set { 
                genre = value;
                OnPropertyChanged("Genre");
            }
        }

        public static RecordWithNotification GetTempData()
        {
            return new RecordWithNotification { Name = "Back in Black", Artist = "AC/DC", Genre = RecordWithNotification.RecordGenre.Rock, ReleaseDate = DateTime.Parse("25/07/1980") };
        }

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
