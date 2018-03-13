using System;
using DesignPatterns.Structural.Flyweight.Theory;
using Xunit;

namespace DesignPatterns.Tests.Structural.Flyweight
{
    public class FlyweightTheoryTests
    {
        [Fact]
        public void MethodName()
        {
            var extrinsicstate = 22;

            var factory = new FlyweightFactory();

            var fX = factory.GetFlyweight("X");
            fX.Operation(--extrinsicstate);

            var fY = factory.GetFlyweight("Y");
            fY.Operation(--extrinsicstate);

            var fZ = factory.GetFlyweight("Z");
            fY.Operation(--extrinsicstate);

            var fU = new UnsharedConcreteFlyweight();
            fU.Operation(--extrinsicstate);


        }
    }
}
