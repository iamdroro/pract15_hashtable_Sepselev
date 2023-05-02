using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt15Algoritm4
{
    class Music
    {
        public string ArtistName { get; set; }
        public string SongName { get; set; }

        public Music(string artistName, string songName)
        {
            ArtistName = artistName;
            SongName = songName;
        }
    }
}
