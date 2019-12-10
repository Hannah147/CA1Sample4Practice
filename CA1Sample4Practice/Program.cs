using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Sample4Practice
{
    class Program
    {
        private static Random rng = new Random();
        static void Main(string[] args)
        {
            // Question 7
            Song s1 = new Song()
            {
                Artist = "ED SHEERAN",
                Title = "BEAUTIFUL PEOPLE",
                Duration = 3.15,
                Genre = Genre.Pop
            };

            Song s2 = new Song() { Artist = "REGARD", Title = "RIDE IT", Duration = 3.37, Genre = Genre.Dance };
            Song s3 = new Song() { Artist = "TONES & I", Title = "DANCE MONKEY", Duration = 4.20, Genre = Genre.Dance };
            Song s4 = new Song() { Artist = "POST MALONE", Title = "CIRCLES", Duration = 3.25, Genre = Genre.Pop };
            Song s5 = new Song() { Artist = "ED SHEERAN", Title = "SOUTH OF THE BORDER", Duration = 4.26, Genre = Genre.Other };

            List<Song> PlayList = new List<Song>();

            PlayList.Add(s1);
            PlayList.Add(s2);
            PlayList.Add(s3);
            PlayList.Add(s4);
            PlayList.Add(s5);

            Display(PlayList);

            PlayList.Sort();

            WriteLine("\nSorting the playlist by Artist, then Song Title\n");

            Display(PlayList);

            WriteLine("\nShuffling the Playlist...\n");

            Shuffle(PlayList);

            Display(PlayList);
        }

        // Question 9
        private static void Display(List<Song> playlist)
        {
            WriteLine("{0, -20}{1,-25}{2,-10}{3,-10}", "Artist", "Song", "Duration", "Genre");

            foreach(var s in playlist)
            {
                WriteLine($"{s.Artist, -20}{s.Title, -25}{s.Duration, -10}{s.Genre, -10}");
            }
        }

        private static void Shuffle(List<Song> playlist)
        {
            int n = playlist.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Song value = playlist[k];
                playlist[k] = playlist[n];
                playlist[n] = value;
            }
        }
    }
}
