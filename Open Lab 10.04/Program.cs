using System;

namespace Open_Lab_10._04
{
    class Book
    {
        string title;
        int pages;
        string category;
        string autor;
        int releaseDate;


        public int Release
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value > 2021 || value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }

            }

        }
        public int Str
        {
            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }

        }
        public string Kateg
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }

        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }

        }
        public void Vypis()
        {
            Console.WriteLine(title + " " + pages + " " + category + " " + autor + " " + releaseDate);
        }
        
        //nie som si istý ako je mylené dať text na hodnotu -1
        
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            autor = "-1";
            releaseDate = -1;
        }
        public Book(string TITLE, int PAGES)
        {
            title = TITLE;
            pages = PAGES;
            category = "-1";
            autor = "-1";
            releaseDate = -1;
        }
        public Book(string TITLE, int PAGES, string CATEGORY, string AUTOR, int DATE)
        {
            title = TITLE;
            pages = PAGES;
            category = CATEGORY;
            autor = AUTOR;
            releaseDate = DATE;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR2 = new Book();
            LOTR2.Vypis();
            Book LOTR3 = new Book("Lord of the Rings 3", 250);
            LOTR3.Vypis();
            Book HOBBIT = new Book("Hobbit", 240, "Adventure", "J.R.R Token", 1937);
            HOBBIT.Vypis();
        }
    }
}
