using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectTextOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\programmC#\TextPoem.txt";
            string pathW = @"D:\programmC#\TextC#.txt";
            string text = null;
            text = ClassMethod.textRead(path);
            List<Tuple<string, int>> lst = new List<Tuple<string, int>>();
            string[] massText = text.Split(new char[]{' ', ',', '.','?', '-', '!',':','\n','\r'}, StringSplitOptions.RemoveEmptyEntries);    
            lst = ClassMethod.CountWord(massText);
            lst = lst.Distinct().ToList();    
            lst = ClassMethod.BubbleSort(lst);
            foreach (Tuple<string, int> p in lst) Console.WriteLine("Слово {0} |количесвто повторений {1} ", p.Item1, p.Item2);
            ClassMethod.textWrite(lst, pathW);
        }
 

    }
}
