using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_250207
{
    internal class Books
    {
        /*· Adattagok: cim, szerzo, kiadasEve, oldalszam, ar.

· 2 konstruktor:

o Egyik minden adattagot kap.

o Másik csak a címet és szerzőt kapja meg, a kiadás éve legyen az aktuális év, az oldalszám 200, az ár pedig 3000.
        
         · Property-k az adattagokhoz.*/

        private string title;
        private string author;
        private int year;
        private int pages;
        private int price;


        public Books(string title, string author, int year, int pages, int price)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
            this.price = price;
        }

        public Books(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.year = DateTime.Now.Year;
            this.pages = 200;
            this.price = 3000;
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public int Pages
        {
            get { return this.pages; }
            set { this.pages = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }


        public int IncreasePrice(int surplus)
        {
            return this.price + surplus;
        }

        public double discount(double percentage)
        {
            return this.price - (this.price * percentage / 100);
        }

        public string PagesLeft(int readPages)
        {
            return $"The remaining pages: {this.pages - readPages}";
        }

       


        public override string ToString()
        {
            return $"Title: {this.title}, Author: {this.author}, Year: {this.year}, Pages: {this.pages}, Price: {this.price} Ft";
        }


    }
}
