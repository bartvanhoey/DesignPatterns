using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns.Structural.Composite.RealWorld
{
    public abstract class DrawingElement
    {
        protected readonly string Name;
        protected DrawingElement(string name) => Name = name;
        public abstract void Add(DrawingElement drawingElement);
        public abstract void Remove(DrawingElement drawingElement);
        public abstract void Display(int indent);
    }

    public class CompositeElement : DrawingElement
    {
        private readonly List<DrawingElement> _drawingElements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name) { }

        public override void Add(DrawingElement drawingElement) => _drawingElements.Add(drawingElement);

        public override void Remove(DrawingElement drawingElement) => _drawingElements.Remove(drawingElement);

        public override void Display(int indent)
        {
            Debug.WriteLine(new string('-', indent) + "+ " + Name);
            foreach (var drawingElement in _drawingElements)
                drawingElement.Display(indent + 2);
        }
    }

    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name) { }

        public override void Add(DrawingElement drawingElement) => Debug.WriteLine("Cannot add to PrimitiveElement");

        public override void Remove(DrawingElement drawingElement) => Debug.WriteLine("Cannot remove from PrimitiveElement");

        public override void Display(int indent) => Debug.WriteLine(new string('-', indent) + Name);
    }
}