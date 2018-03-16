using DesignPatterns.Structural.Flyweight.RealWorld;
using Xunit;

namespace DesignPatterns.Tests.Structural.Flyweight
{
    public class FlyweightRealWorldTests
    {
        [Fact]
        public void test_flyweight_realworld()
        {
            const string document = "AAZZBBZB";
            var chars = document.ToCharArray();

            var factory = new CharacterFactory();

            var pointSize = 10;

            foreach (var c in chars)
            {
                pointSize++;
                var character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}