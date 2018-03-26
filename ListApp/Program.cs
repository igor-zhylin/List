namespace ListApp
{
    using System;
    using ObjectList;

    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 1);
            }
            list.InsertAt(2, 4);
            list.RemoveAt(0);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("---------------");
            Console.WriteLine( list.IndexOf(4));
            Console.WriteLine(list.IndexOf(10));
            Console.WriteLine("---------------");
            list.Reverce();
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
