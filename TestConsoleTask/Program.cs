using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //0:music;1:video;2:program
            CD cd1 = new CD("CD name1", 200, 0);
            CD cd2 = new CD("CD name2", 300, 1);
            DVD dvd1 = new DVD("DVD name1", 500, 2);
            DVD dvd2 = new DVD("DVD name2", 500, 2);
            DVD dvd3 = new DVD("DVD name2", 650, 1);
            BookCook bookC1 = new BookCook("BookCook name 1", 100, 40, "bread");
            BookEsoterics bookE1 = new BookEsoterics("Dragon D", 399, 350, 18);
            BookCook bookC2 = new BookCook("BookCook name 2", 300, 80, "fish");
            BookCook bookC3 = new BookCook("BookCook name 3", 270, 75, "meat");
            CD cd3 = new CD("CD name3", 297, 1);
            BookProg bookP1 = new BookProg("C# book", 300, 90, "c#");
            BookProg bookP2 = new BookProg("Python book", 500, 50, "python");
            BookProg bookP3 = new BookProg("golang book", 200, 40, "Go");
            var items = new List<Item> { cd1, cd2, dvd1, dvd2, dvd3, bookC1, bookE1, bookC2, bookC3, cd3, bookP1, bookP2, bookP3 };
            while (items.Count != 0)
                foreach (Item item in items)
                {
                    if (item.GetType() == typeof(CD))
                    {
                        Console.WriteLine(((CD)item).GetInfo());
                        items.Remove(item);
                        break;
                    }
                    if (item.GetType() == typeof(DVD))
                    {
                        Console.WriteLine(((DVD)item).GetInfo());
                        items.Remove(item);
                        break;
                    }
                    if (item.GetType() == typeof(BookCook))
                    {
                        Console.WriteLine(((BookCook)item).GetInfo());
                        items.Remove(item);
                        break;
                    }
                    if (item.GetType() == typeof(BookEsoterics))
                    {
                        Console.WriteLine(((BookEsoterics)item).GetInfo());
                        items.Remove(item);
                        break;
                    }
                    if (item.GetType() == typeof(BookProg))
                    {
                        Console.WriteLine(((BookProg)item).GetInfo());
                        items.Remove(item);
                        break;
                    }
                }
            Console.ReadLine();
        }
    }
}
