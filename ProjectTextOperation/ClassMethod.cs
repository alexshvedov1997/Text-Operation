using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectTextOperation
{
    class ClassMethod
    {
        static public string textRead(string fileLocation) {
            string text = null;
            using (StreamReader reader = new StreamReader(fileLocation, Encoding.Default))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
        static public List<Tuple<string, int>> CountWord(string [] massText) {
            List<Tuple<string, int>> lst = new List<Tuple<string, int>>();
            for (int i = 0; i < massText.Length; i++)
            {
                int count = 0;
                Tuple<string, int> tupl;
                for (int j = 0; j < massText.Length; j++)
                {
                    if (massText[i] == massText[j])
                    {
                        count++;
                    }
                }
                tupl = Tuple.Create(massText[i], count);
                lst.Add(tupl);
            }
            return lst;
        }

        static public List<Tuple<string, int>> BubbleSort( List<Tuple<string, int>> lst) {
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    if (lst[i].Item2 < lst[j].Item2)
                    {
                        Tuple<string, int> temp;
                        temp = lst[i];
                        lst[i] = lst[j];
                        lst[j] = temp;
                    }
                }
            }
            return lst;
        }

        public static void textWrite(List<Tuple<string, int>> lst, string fileLocation)
        { 
              using(StreamWriter strW = new StreamWriter(fileLocation, false, Encoding.Default)){
                  foreach (Tuple<string, int> p in lst) strW.WriteLine("Слово {0} |количесвто повторений {1} ", p.Item1, p.Item2);
              }
        }
    }
}
