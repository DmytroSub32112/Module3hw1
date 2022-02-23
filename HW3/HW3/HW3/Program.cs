using System;

namespace HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var collect = new MiList<string>("s");
            collect.Add("f");
            collect.Add("g");
            collect.Add("h");
            collect.Add("b");
            collect.Add("v");
            collect.Add("c");
            collect.Add("x");
            collect.Sort();
            collect.Remove("b");
            collect.RemoveAt(1);
            foreach (var item in collect)
            {
                Console.WriteLine(item);
            }
        }
    }
}
