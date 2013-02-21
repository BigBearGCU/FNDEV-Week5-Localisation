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
    //A record which hold tracks information
    public class RecordWithTracks : INotifyPropertyChanged
    {
        public RecordWithTracks()
        {
            Tracks = new List<Track>();

        }

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

        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
                OnPropertyChanged("ReleaseDate");
            }
        }

        public RecordGenre Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
                OnPropertyChanged("Genre");
            }
        }

        public List<Track> Tracks { get; set; }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public static RecordWithTracks GetTempData()
        {
            RecordWithTracks record =new RecordWithTracks { 
                Name = "Back in Black", Artist = "AC/DC", Genre = RecordGenre.Rock, ReleaseDate = DateTime.Parse("25/07/1980")
            };

            Track t = new Track();

            t.Name = "Hells Bells";
            t.TrackNo = 1;
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");

            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 2;
            t.Name = "Shoot to Thrill";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 3;
            t.Name = "What Do You Do for Money Honey";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 4;
            t.Name = "Given the Dog a Bone";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 5;
            t.Name = "Let Me Put My Love into You";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 6;
            t.Name = "Back in Black";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 7;
            t.Name = "You Shook Me All Night Long";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 8;
            t.Name = "Have a Drink on Me";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 9;
            t.Name = "Shake a Leg";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 10;
            t.Name = "Rock and Roll Ain't Noise Pollution";
            t.Writers.Add("Angus Young");
            t.Writers.Add("Malcolm Young");
            t.Writers.Add("Brian Johnson");
            record.Tracks.Add(t);

            return record;
        }

        public static List<RecordWithTracks> GetCollectionTempData()
        {
            List<RecordWithTracks> records = new List<RecordWithTracks>();
            records.Add(GetTempData());

            RecordWithTracks record=new RecordWithTracks { Name = "Disraeli Gears", Artist = "Cream", Genre = RecordGenre.Rock, ReleaseDate = DateTime.Parse("01/11/1967") };

            Track t = new Track();
            t.TrackNo = 1;
            t.Name = "Strange Brew";
            t.Writers.Add("Eric Clapton");
            t.Writers.Add("Felix Pappalardi");
            t.Writers.Add("Gail Collins");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 2;
            t.Name = "Sunshine Of Your Love";
            t.Writers.Add("Eric Clapton");
            t.Writers.Add("Jack Bruce");
            t.Writers.Add("Pete Brown");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 3;
            t.Name = "World of Pain";
            t.Writers.Add("Gail Collins");
            t.Writers.Add("Felix Pappalardi");
            record.Tracks.Add(t);

            t = new Track();
            t.TrackNo = 4;
            t.Name = "Dance The Night Away";
            t.Writers.Add("Jack Bruce");
            t.Writers.Add("Pete Brown");
            record.Tracks.Add(t);

            records.Add(record);

            return records;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
