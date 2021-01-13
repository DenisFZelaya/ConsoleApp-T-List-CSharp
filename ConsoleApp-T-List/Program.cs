using System;
using System.Collections.Generic; // No olvidar importar

namespace ConsoleApp_T_List
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a list of strings using collection initializer  
            //var names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love" };

            //Create a list of strings
            var names = new List<string>();

            names.Add("Denis Zelaya");
            names.Add("Mellisa");
            names.Add("Maite");

            foreach (var name in names) 
            {
                Console.WriteLine(name);
            }

            //Similar a un array en js
           
        }
    }
}
