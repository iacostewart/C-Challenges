using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "GEORGE", "PAUL", "JOHN", "RINGO" };

            foreach (string name in names)
            {
                string[] lowername = new string[] { (name.ToLower()) };
                //foreach (string lower in lowername);
                List<string> lowercase = new List<string>();
                foreach (string lname in lowername)
                {
                    lowercase.Add(lname);
                }
                foreach(string n in lowername)
                {
                    Console.WriteLine(n);
                }
            }


        }
    }
}
