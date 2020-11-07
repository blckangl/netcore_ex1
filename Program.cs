using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    class Program
    {
        // public static List<int> listNumbers = new List<int>(new int[]{27,30,67,645,56465,75});
        static void Main(string[] args)
        {
            // List<int> list2 = new List<int>(new int[]{2,6,23,8,5});
            
            //method 1
            // var newList = new List<int>();
            // for (int i = 0; i < listNumbers.Count; i++)
            // {
            //     if (listNumbers[i] % 10 != 7)
            //     {
            //         newList.Add(listNumbers[i]);
            //     }
            // }
            //
            // newList.ForEach((x) =>
            // {
            //     Console.WriteLine(x);
            // });

            //method2
            // var newList = listNumbers.Where(x => x % 10 != 7).Select(x => x).ToList<int>();
            // newList.ForEach((x) =>
            // {
            //     Console.WriteLine(x);
            // });

            //method3
            // getNewList().ForEach((x) =>
            // {
            //     Console.WriteLine(x);
            //  });
            
            
            // getSqrt(list2).ForEach(x =>
            // {
            //     Console.WriteLine(x);
            // });
            
            var bmw = new Car();
            bmw.Name = "bmw";

            runVehcile(bmw);
            
            var jet = new Plane();
            runVehcile(jet);


        }

        public static void runVehcile(Vehicle veh)
        {
            veh.run();
        }

        // static List<int> getNewList()
        // {
        //     var newList = from number in listNumbers
        //         let rest = number % 10 
        //         where (rest != 7)
        //         select number;
        //     
        //     return newList.ToList();
        // }
        //
        // static List<Object> getSqrt(List<int> list)
        // {
        //     var newList = from number in list
        //         let sqr = number * number
        //         where sqr < 20
        //         select new {number, sqr};
        //
        //     return newList.ToList<Object>();
        // }
        //
    }
}
