using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModel
{
    public class Record
    {
        public enum RecordGenre
        {
            Rock,
            Blues,
            Classical,
            Country,
            Rap,
            Pop
        }

        protected string name;
        protected string artist;
        protected DateTime releaseDate;
        protected RecordGenre genre;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Artist {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public DateTime ReleaseDate {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }

        public RecordGenre Genre {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public static Record GetTempData()
        {
            return new Record { Name = "Back in Black", Artist = "AC/DC", Genre = Record.RecordGenre.Rock, ReleaseDate = DateTime.Parse("25/07/1980") };
        }

        public static List<Record> GetCollectionTempData()
        {
            List<Record> recordList = new List<Record>();

            recordList.Add(new Record { Name = "Back in Black", Artist = "AC/DC", Genre = Record.RecordGenre.Rock, ReleaseDate = DateTime.Parse("25/07/1980") });
            recordList.Add(new Record { Name = "Disraeli Gears", Artist = "Cream", Genre = Record.RecordGenre.Rock, ReleaseDate = DateTime.Parse("01/11/1967") });
            recordList.Add(new Record { Name = "Are you Experienced", Artist = "Jimi Hendrix", Genre = Record.RecordGenre.Rock, ReleaseDate = DateTime.Parse("12/06/1967") });

            return recordList;
        }

    }
}
