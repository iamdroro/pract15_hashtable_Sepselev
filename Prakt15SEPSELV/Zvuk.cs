using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt15Algoritm4
{
    class Zvuk
    {
        private Hashtable discs = new Hashtable();

        public void AddDisc(string discName)
        {
            discs.Add(discName, new ArrayList());
        }

        public void RemoveDisc(string discName)
        {
            discs.Remove(discName);
        }

        public void AddSong(string discName, string artistName, string songName)
        {
            if (discs.ContainsKey(discName))
            {
                ArrayList songs = (ArrayList)discs[discName];
                songs.Add(new Music(artistName, songName));
            }
        }

        public void RemoveSong(string discName, string artistName, string songName)
        {
            if (discs.ContainsKey(discName))
            {
                ArrayList songs = (ArrayList)discs[discName];
                songs.Remove(new Music(artistName, songName));
            }
        }

        public void PrintCatalog()
        {
            Console.WriteLine("Каталог:");
            foreach (string discName in discs.Keys)
            {
                Console.WriteLine(discName);
                PrintDisc(discName);
            }
        }

        public void PrintDisc(string discName)
        {
            if (discs.ContainsKey(discName))
            {
                Console.WriteLine("Песни:");
                ArrayList songs = (ArrayList)discs[discName];
                foreach (Music Music in songs)
                {
                    Console.WriteLine("        " + Music.ArtistName + " - " + Music.SongName);
                }
            }
        }

        public void SearchByArtist(string artistName)
        {
            Console.WriteLine("Результат поиска: " + artistName);
            foreach (string discName in discs.Keys)
            {
                Console.WriteLine("  " + discName + ":");
                ArrayList songs = (ArrayList)discs[discName];
                foreach (Music Music in songs)
                {
                    if (Music.ArtistName == artistName)
                    {
                        Console.WriteLine("    " + Music.ArtistName + " - " + Music.SongName);
                    }
                }
            }
        }
    }
}
