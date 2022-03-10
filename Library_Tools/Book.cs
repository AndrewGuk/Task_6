using System;
using System.Collections.Generic;
using Library_Tools.Enums;

namespace Library_Tools
{
    public class Book
    {
        public string name { get; set; }
        public string level { get; set; }
        public int page { get; set; }

        public Book(string name, string level, int page)
        {
            this.name = name;
            this.level = level;
            this.page = page;
        }
    }
    public class Library
    {
        List<Book> library = new List<Book>();
        public string[] PrintIndex(int x)
        {
            string[] resault = new string[3];
            for (int i = 0; i < library.Count; i++)
            {
                if (i == x)
                {
                    resault[0] = library[i].name.Replace('_', ' ');
                    resault[1] = library[i].level;
                    resault[2] = library[i].page.ToString();
                    break;
                }
                else
                {
                    resault[0] = "Sorry,";
                    resault[1] = "I can't search";
                    resault[2] = $"the book <{x}>((";
                }
            }
            return resault;
        }
        public string[] PrintName(string x)
        {
            string[] resault = new string[3];
            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].name == x)
                {
                    resault[0] = library[i].name.Replace('_', ' ');
                    resault[1] = library[i].level;
                    resault[2] = library[i].page.ToString();
                    break;
                }
                else
                {
                    resault[0] = "Sorry,";
                    resault[1] = "I can't search";
                    resault[2] = $"the book <{x}>((";
                }
            }
            return resault;
        }
        public void AddToList()
        {
            string level = "A0";
            Random random = new Random();
            var countElementA0 = Enum.GetNames(typeof(BooksA0)).Length;
            var countElementA1 = Enum.GetNames(typeof(BooksA1)).Length;
            var countElementA2 = Enum.GetNames(typeof(BooksA2)).Length;
            var countElementB1 = Enum.GetNames(typeof(BooksB1)).Length;
            var countElementB2 = Enum.GetNames(typeof(BooksB2)).Length;
            var countElementC1 = Enum.GetNames(typeof(BooksC1)).Length;
            int generalCount = countElementA0 + countElementA1 + countElementA2 + countElementB1 + countElementB2 + countElementC1;

            for (int i = 0; i < Enum.GetNames(typeof(BooksA0)).Length; i++)
            {
                library.Add(new Book(Enum.GetName(typeof(BooksA0), i), level, random.Next(1, 1000)));
            }
            level = "A1";
            for (int i = 0; i < Enum.GetNames(typeof(BooksA1)).Length; i++)
            {
                library.Add(new Book(Enum.GetName(typeof(BooksA1), i), level, random.Next(1, 1000)));
            }
            level = "A2";
            for (int i = 0; i < Enum.GetNames(typeof(BooksA2)).Length; i++)
            {
                library.Add(new Book(Enum.GetName(typeof(BooksA2), i), level, random.Next(1, 1000)));
            }
            level = "B1";
            for (int i = 0; i < Enum.GetNames(typeof(BooksB1)).Length; i++)
            {
                library.Add(new Book(Enum.GetName(typeof(BooksB1), i), level, random.Next(1, 1000)));
            }
            level = "B2";
            for (int i = 0; i < Enum.GetNames(typeof(BooksB2)).Length; i++)
            {
                library.Add(new Book(Enum.GetName(typeof(BooksB2), i), level, random.Next(1, 1000)));
            }
            level = "C1";
            for (int i = 0; i < Enum.GetNames(typeof(BooksC1)).Length; i++)
            {
                library.Add(new Book(Enum.GetName(typeof(BooksC1), i), level, random.Next(1, 1000)));
            }
        }
        public void PrintAllBook()
        {
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"name is: <{library[i].name.Replace('_', ' ')}>, "+
                     $"level is: <{library[i].level}>, "+ 
                     $"pages are: <{library[i].page}>.");
            }
        }
    }
}
