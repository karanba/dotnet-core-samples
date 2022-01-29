namespace DotnetWS.DesignPatterns.Visitor
{ 
    public interface IElement 
    {
        void Accept(IVisitor visitor);
    }
}