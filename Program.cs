using System;
using DotnetWS.DesignPatterns.Adapter;
using DotnetWS.DesignPatterns.Facade;
using DotnetWS.DesignPatterns.Visitor;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.TestAdapterPattern();
            Program.TestVisitorPattern();
            Program.TestFacadePattern();
        }

        static void TestFacadePattern()
        {
            Order order = new Order();
            order.PlaceOrder();
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

            foreach (var drive in drives)
            {
                drive.Start();
                drive.Stop();
            }
        }
    }
}
