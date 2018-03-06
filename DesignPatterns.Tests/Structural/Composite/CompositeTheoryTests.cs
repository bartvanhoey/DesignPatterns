using DesignPatterns.Structural.Composite.Theory;
using Xunit;

namespace DesignPatterns.Tests.Structural.Composite
{
    public class CompositeTheoryTests
    {
        [Fact]
        public void TestCompositeTheory()
        {
            // Create a tree structure
            var root = new DesignPatterns.Structural.Composite.Theory.Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new DesignPatterns.Structural.Composite.Theory.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
        }
    }
}
