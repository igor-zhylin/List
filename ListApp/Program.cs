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
            list.Insert(2, 4);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
