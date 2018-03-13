using System.Collections;
using System.Diagnostics;

namespace DesignPatterns.Structural.Flyweight.Theory
{
    public class FlyweightFactory
    {
        private readonly Hashtable _flyweights = new Hashtable();

        public FlyweightFactory()
        {
            _flyweights.Add("X", new ConcreteFlyweight());
            _flyweights.Add("Y", new ConcreteFlyweight());
            _flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key) => (Flyweight)_flyweights[key];
    }

    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);

    }

    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Debug.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
        }
    }

    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Debug.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}