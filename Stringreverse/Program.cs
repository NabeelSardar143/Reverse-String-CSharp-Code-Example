using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringreverse
{
    class Search
    {
        String func(String el)
        {
            int length=(el.Length)-1;
            String revresstring = "";
           for(;length>=0 ;length--)
            {
                revresstring =revresstring+ el[length];
            }
            return revresstring;
            
        }
        static void Main(string[] args)
        {
            Search obj=new Search();
            Console.WriteLine("Enter a String");
            String el= Console.ReadLine();
            Console.WriteLine("Rverse String");
            Console.WriteLine(obj.func(el));
           
            Console.ReadKey();
            
        }
    }
}
