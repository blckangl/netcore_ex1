using System;

namespace ex1
{
    public class Car : Vehicle
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }


        public void run()
        {
            Console.WriteLine("running");
        }
    }
}