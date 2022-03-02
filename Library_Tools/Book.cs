using System;
using System.Collections.Generic;

namespace Library_Tools
{
    public class Book
    {
        public string name { get; set; }
        public string janr { get; set; }
        public int page { get; set; }

        public Book(string name, string janr, int page)
        {
            this.name = name;
            this.janr = janr;
            this.page = page;
        }


    }
    public class Library
    {
        List<Book> library = new List<Book>()
        {
            new Book("name", "janr", 14),
            new Book("name1", "janr1", 4543),
            new Book("name2", "janr2", 4),
            new Book("name3", "janr3", 432),
            new Book("name4", "janr4", 20)
        };


        public void Print(int x)
        {
            for (int i = 0; i < library.Count; i++)
            {
                if (i==x)
                {
                    Console.WriteLine(library[x].name);
                    Console.WriteLine(library[x].janr);
                    Console.WriteLine(library[x].page);
                }
            }
        }
        public void PrintName(string x)
        {
            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].name == x)
                {
                    Console.WriteLine(library[i].name);
                    Console.WriteLine(library[i].janr);
                    Console.WriteLine(library[i].page);
                    return;
                }
            }
            Console.WriteLine("sorry");
        }
        

        //public List<Book> Tolstaja(this List<Book> library)
        //{
        //    var b = 0;
        //    for (int i = 1; i < library.Count; i++)
        //    {
        //        if (library[i].page > library[i-1].page )
        //        {
        //            if (library[i].page > library[library.Count-1].page)
        //            {
        //                b = library[i].page;
        //            }
        //            b = i;
        //        }
        //    }
        //    library.Insert(0, library[b]);
        //    return library;
        //}



    }
    public static class Tut
    {
        public static List<Book> Tolstaja(this List<Book> library)
        {
            var b = 0;
            for (int i = 1;i < library.Count;i++)
            {
                if (library[i-1].page<library[i].page)
                {
                    if (library[b].page < library[i].page)
                    {
                        b = i;
                    }
                }
            }
            
            library.Insert(0, library[b]);
            library.RemoveAt(b+1);
            return library;
        }
    }
    

}