using DesignPatterns.Structural.Composite.RealWorld;
using Xunit;

namespace DesignPatterns.Tests.Structural.Composite
{
    public class CompositeRealWorldTests
    {
        [Fact]
        public void TestCompositeRealWorld()
        {
            var picture = new CompositeElement("Picture");
            picture.Add(new PrimitiveElement("Red Line"));
            picture.Add(new PrimitiveElement("Blue Circle"));
            picture.Add(new PrimitiveElement("Green Box"));

            var composite = new CompositeElement("Two Circles");
            composite.Add(new PrimitiveElement("Black Circle"));
            composite.Add(new PrimitiveElement("White Circle"));
            picture.Add(composite);

            var yellowLine = new PrimitiveElement("Yellow Line");
            picture.Add(yellowLine);
            picture.Remove(yellowLine);

            picture.Display(1);


        }


    }
}
