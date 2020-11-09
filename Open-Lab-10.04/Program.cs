using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("Creative name of book", -100, "encyclopedia", "Jaro", 2020);

            Console.WriteLine(LOTR.Title + ", " + LOTR.Pages + ", " + LOTR.Category + ", " + LOTR.Author + ", " + LOTR.ReleaseDate);
            Console.ReadKey();
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }
        public string Title
        {
            get;
            set;
        }

        public int Pages
        {
            get => this.pages;
            set
            {
                this.pages = value;
                if (this.pages < 0)
                {
                    this.pages = 1;
                }
            }
        }

        public string Category
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public int ReleaseDate
        {
            get => this.releaseDate;
            set
            {
                this.releaseDate = value;
                if ((this.releaseDate > 2021) || (this.releaseDate < 1450))
                {
                    this.releaseDate = -1;
                }
            }
        }
    }
}