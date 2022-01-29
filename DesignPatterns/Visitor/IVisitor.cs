namespace DotnetWS.DesignPatterns.Visitor
{ 

    public interface IVisitor 
    {
        void Visit(IElement element);
    }
}