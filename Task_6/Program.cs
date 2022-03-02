using System;
using Library_Tools;
using System.Collections.Generic;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {


            Library library = new Library();
            //library.Print(4);
            //library.PrintName("name7");
            List<Book> nana = new List<Book>()
            {
                new Book("name", "janr", 854),
                new Book("name1", "janr1", 45),
                new Book("name2", "janr2", 1000),
                new Book("name3", "janr3", 999),
                new Book("name4", "janr4", 20000)
            };

            Tut.Tolstaja(nana);
            void Res(List<Book> x)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    {
                        Console.WriteLine(x[i].name);
                        Console.WriteLine(x[i].janr);
                        Console.WriteLine(x[i].page);
                    }
                }
            }
            Res(nana);


        }
    }
}