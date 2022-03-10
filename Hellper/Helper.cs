using Library_Tools;

namespace Hellper
{
    public static class UserMethods
    {
        public static int[] BubbleSort(this int[] array)
        {
            int temple;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temple = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temple;
                    }
                }
            }
            return array;
        }
        public static List<Book> SearchBiggestBook(this List<Book> library)
        {
            var temple = 0;
            for (int i = 1; i < library.Count; i++)
            {
                if (library[i - 1].page < library[i].page)
                {
                    if (library[temple].page < library[i].page)
                        temple = i;
                }
            }
            library.Insert(0, library[temple]);
            library.RemoveAt(temple + 1);
            return library;
        }
    }
}