namespace DotnetWS.DesignPatterns.Visitor
{ 
    public class Veichle : IElement
    {
        public string Name {get; set;}
        public Veichle(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}