using System;

namespace DotnetWS.DesignPatterns.Visitor
{
    public class Mechanic : IVisitor
    {
        public string Name
        {
            get; set;
        }
        public Mechanic(string name)
        {
            this.Name = name;
        }

        public void Visit(IElement element)
        {
            Veichle veichle = (Veichle) element;
            Console.WriteLine($"Mechanic {this.Name} visited the {veichle.Name}");
        }
    }
}