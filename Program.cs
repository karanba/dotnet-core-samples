using System;
using DotnetWS.DesignPatterns.Adapter;
using DotnetWS.DesignPatterns.Visitor;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.TestAdapterPattern();
            Program.TestVisitorPattern();
        }

        static void TestVisitorPattern()
        {
            var mechanic = new Mechanic("Usta");
            var controller = new Controller("EGM");

            var garage = new Garage();
            garage.PerformOperation(mechanic);
            garage.PerformOperation(controller);


        }
        static void TestAdapterPattern()
        {
            IDrive[] drives = {
                new Car(),
                new TumbrelAdapter(new Tumbrel())
            };

            foreach(var drive in drives)
            {
                drive.Start();
                drive.Stop();
            }
        }
    }
}
