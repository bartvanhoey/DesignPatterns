using DesignPatterns.Creational.AbstractFactory.Theory;
using Xunit;

namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    public class AbstractFactoryTheoryTests
    {
        [Fact]
        public void TestAbstractFactoryTheory()
        {
            var factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            var factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();
        }
    }
}