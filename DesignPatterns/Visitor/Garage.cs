using System.Collections.Generic;

namespace DotnetWS.DesignPatterns.Visitor
{
    public class Garage
    {
        List<IElement> veichles = new List<IElement>();
        public Garage()
        {
            veichles.Add(new Veichle("Subaru"));
            veichles.Add(new Veichle("Renault"));
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach(IElement veichle in veichles){
                veichle.Accept(visitor);
            }
        }
    }
}