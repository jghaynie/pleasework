using System;
using System.IO;
using System.Globalization;

namespace pleasework
{
    public class Books
    {
        private double isbn;
        private string title;
        private string author;
        private string genre;
        private double runTime;
        private double copies;
        private static int count;

        public Books() {}

        public Books(double isbn, string title, string author, string genre, double runTime, double copies)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.runTime = runTime;
            this.copies = copies;
        }

        public void SetIsbn(double isbn)
        {
            this.isbn = isbn;
        }

        public double GetIsbn()
        {
             return isbn;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
             return title;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public string GetAuthor()
        {
             return author;
        }
        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public string GetGenre()
        {
             return genre;
        }
        public void SetRuntime(double runTime)
        {
            this.runTime = runTime;
        }

        public double GetRuntime()
        {
             return runTime;
        }
        public void SetCopies(double copies)
        {
            this.copies = copies;
        }

        public double GetCopies()
        {
             return copies;
        }

        public static void SetCount(int count)
        {
            Books.count = count;
        }

        public static int GetCount()
        {
             return count;
        }

        public static void IncCount()
        {
            count++;
        }

        public static void DecCount()
        {
            count--;
        }

        public override string ToString()
        {
             return ($"ISBN: {isbn}, Title: {title}, Author: {author}, Genre: {genre}, Run Time: {runTime}, Copies; {copies}");
        }

        public int CompareTo(Books value)
        {
             return (this.isbn.CompareTo(value.GetIsbn()));
        }

        public bool Equals(Books tempBook)
        {
             return this.isbn == tempBook.GetIsbn();
        }  

        public bool Equals(double tempIsbn)
        {
             return this.isbn == tempIsbn;
        }
    }
}