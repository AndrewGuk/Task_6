using System;
using Library_Tools;
using System.Collections.Generic;
using Hellper;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello library program:");
            //auto loading books in the library:
            Library library = new Library();
            Random random = new Random();

            library.AddToList();

            //manually uploading books to the library:
            List<Book> manualLibrary = new List<Book>()
            {
                new Book("name", "janr", random.Next(1,1000)),
                new Book("name1", "janr1", random.Next(1,1000)),
                new Book("name2", "janr2", random.Next(1,1000)),
                new Book("name3", "janr3", random.Next(1,1000)),
                new Book("name4", "janr4", random.Next(1,1000))
            };

            //book search by index:
            Console.WriteLine("Please enter an index:");
            var index = int.Parse(Console.ReadLine());
            string[] answerIndex = library.PrintIndex(index);
            foreach (var item in answerIndex)
            {
                Console.WriteLine(item);
            }
            //book search by title:
            Console.WriteLine("Please enter a title:");
            string[] answerName = library.PrintName(Console.ReadLine().ToLower().Replace(' ','_'));
            foreach (var item in answerName)
            {
                Console.WriteLine(item);
            }

            //Conclusion of the "thickest" book:
            Console.WriteLine("The list is normal:");
            for (int i = 0; i < manualLibrary.Count; i++)
            {
                Console.WriteLine(manualLibrary[i].name);
                Console.WriteLine(manualLibrary[i].level);
                Console.WriteLine(manualLibrary[i].page);
            }
            UserMethods.SearchBiggestBook(manualLibrary);
            Console.WriteLine("List after sorting:");
            for (int i = 0; i < manualLibrary.Count; i++)
            {
                Console.WriteLine(manualLibrary[i].name);
                Console.WriteLine(manualLibrary[i].level);
                Console.WriteLine(manualLibrary[i].page);
            }

            //Conclusion of the "thickest" book:
            int[] array = new int[random.Next(1, 20)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 1000);
            }
            Console.WriteLine("array before sorting:");
            foreach (var item in array)
            {
                Console.Write($"{item} |");
            }
            Console.WriteLine();
            //Applying sorting:
            Console.WriteLine("Applying sorting:");
            UserMethods.BubbleSort(array);
            foreach (var item in array)
            {
                Console.Write($"{item} |");
            }

            //See the entire library:
            Console.WriteLine("Whole library:");
            library.PrintAllBook();
        }
    }
}