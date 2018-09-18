using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns.Creational.Builder.Theory
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    public class ConcreteBuilder1 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartA() => _product.Add("PartA");

        public override void BuildPartB() => _product.Add("PartB");

        public override Product GetResult() => _product;
    }

    public class Product
    {
        private readonly List<string> _parts = new List<string>();

        public void Add(string part) => _parts.Add(part);

        public void Show()
        {
            Debug.WriteLine("\nProduct Parts -----");
            foreach (var part in _parts)
                Debug.WriteLine(part);
        }
    }

    public class ConcreteBuilder2 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartA() => _product.Add("PartX");

        public override void BuildPartB() => _product.Add("PartY");

        public override Product GetResult() => _product;
    }
}