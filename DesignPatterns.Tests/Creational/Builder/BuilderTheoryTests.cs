using DesignPatterns.Creational.Builder.Theory;
using Xunit;

namespace DesignPatterns.Tests.Creational.Builder
{


    public class BuilderTheoryTests
    {
        [Fact]
        public void TestBuilderTheory()
        {
            var director = new Director();

            var builder1 = new ConcreteBuilder1();
            var builder2 = new ConcreteBuilder2();
            
            director.Construct(builder1);
            var product1 = builder1.GetResult();
            product1.Show();

            director.Construct(builder2);
            var product2 = builder2.GetResult();
            product2.Show();
        }
    }
}