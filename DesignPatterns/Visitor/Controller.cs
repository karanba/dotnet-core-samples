using System;

namespace DotnetWS.DesignPatterns.Visitor
{
    public class Controller : IVisitor
    {
        public string Name { get; private set; }

        public Controller(string name)
        {
            this.Name = name;
        }

        public void Visit(IElement element)
        {
            Veichle veichle = (Veichle) element;
            Console.WriteLine($"Controller {this.Name} visited veichle {veichle.Name}");
        }
    }
}