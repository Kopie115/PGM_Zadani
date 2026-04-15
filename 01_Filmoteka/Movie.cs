using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmotéka
{
    internal class Movie : IComparable<Movie>
    {
        private string name;
        private string director;
        private int rating;
        private string note;

        public Movie(string name, string director)
        {
            this.name = name;
            this.director = director;
            rating = -1;
            note = string.Empty;
        }

        public string Name { get { return Name; } }
        public string Director { get { return director; } }
        public int Rating { get { return rating; } set { rating = SetRating(value); }  }
        public string Note { set { note = value; } }
        public string Info()
        {
            return $"Hodnocení: {Rating}{Environment.NewLine}{note}";
        }



        private int SetRating(int value)
        {
            if (value < 0) return 0;
            if (value > 100) return 0;
            return value;
        }

        public override string ToString()
        {
            return $"{name.ToUpper()} - {director}"; 
        }

        public int CompareTo(Movie? other)
        {
            if (other == null) return -1;
            if (name.CompareTo(other.name) == 0)
            {
                return director.CompareTo(other.director);
            }
            return name.CompareTo(other.name);
        }
    }
}
