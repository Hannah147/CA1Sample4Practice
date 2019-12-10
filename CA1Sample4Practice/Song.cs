using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Sample4Practice
{
    public enum Genre { Rock, Pop, Dance, Other}
    // Question 2
    class Song
    {
        // Question 4
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre Genre { get; set; }

        // Question 5
        public Song(string title, string artist, double duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public Song(string title) : this(title, "Unknown", 0, Genre.Other) { }
        public Song() : this("Unknown", "Unknown", 0, Genre.Other) { }

        // Question 6
        public override string ToString()
        {
            return $"{Artist} {Title} {Duration} {Genre}";
        }
    }
}
