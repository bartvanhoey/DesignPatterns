using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns.Structural.Composite.Theory
{
    public abstract class Component
    {
        protected string Name;

        protected Component(string name) => Name = name;

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    public class Composite : Component
    {
        private readonly List<Component> _components = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Debug.WriteLine(new string('-', depth) + Name);
            foreach (var component in _components) component.Display(depth + 2);
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
           Debug.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Debug.WriteLine("Cannot remove from a leave");
        }

        public override void Display(int depth)
        {
            Debug.WriteLine(new string('-', depth) + Name);
        }
    }



}