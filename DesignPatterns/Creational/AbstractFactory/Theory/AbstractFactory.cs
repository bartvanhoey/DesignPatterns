
using System.Diagnostics;

namespace DesignPatterns.Creational.AbstractFactory.Theory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA() => new ProductA1();

        public override AbstractProductB CreateProductB() => new ProductB1();
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA() => new ProductA1();

        public override AbstractProductB CreateProductB() => new ProductB1();
    }


    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA productA);
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA) => Debug.WriteLine(GetType().Name + " interacts with " + productA.GetType().Name);
    }

    public abstract class AbstractProductA {}

    public class ProductA1 : AbstractProductA {}

    public class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run() => _abstractProductB.Interact(_abstractProductA);
    }


}