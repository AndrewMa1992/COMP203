using System;

namespace Comp203A1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string sort = args[0];
            int number = int.Parse(args[1]);
            IntList list = new IntList();
            Random rd = new Random();
            for (int i = 1; i <= number; i++)
            {
                list.Add(rd.Next(0, number + 1));
            }
            if (sort == "i")
            {
                list.Dump();
                list.Isort();
                list.Dump();
            }
            else
            {
                list.Dump();
                list.Qsort(1, number);
                list.Dump();
            }
        }
    }
}
