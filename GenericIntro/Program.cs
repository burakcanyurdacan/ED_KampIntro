using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimlerList = new MyList<string>();
            isimlerList.Add("Burak");

            foreach (var item in isimlerList.GetItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
