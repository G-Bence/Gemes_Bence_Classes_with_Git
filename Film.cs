using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_250207
{
    internal class Film
    {
        private string title;
        private string director;
        private int length;
        private string genre;
        private bool release;


        public Film(string title, string director, int length, string genre, bool release)
        {
            this.title = title;
            this.director = director;
            this.length = length;
            this.genre = genre;
            this.release = release;
        }

        public Film(string title, string director)
        {
            this.title = title;
            this.director = director;
            this.length = 120;
            this.genre = "Unknown";
            this.release = false;
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Director
        {
            get { return this.director; }
            set { this.director = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }


        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public bool Release
        {
            get { return this.release; }
            set { this.release = value; }
        }


        public string isPlaying()
        {
            return this.release ? "The film is playing" : "The film is not playing";
        }

        public string newGenre(string newGenre)
        {
            return this.genre = newGenre;
        }

        public int enlongLength (int elongation)
        {
            return this.length =+ elongation;
        }


        public override string ToString()
        {
            return $"Title: {this.title}, Director: {this.director}, Length: {this.length}, Genre: {this.genre}, Release: {this.release}";
        }
    }
}
