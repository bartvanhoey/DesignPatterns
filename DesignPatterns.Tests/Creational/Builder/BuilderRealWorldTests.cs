using DesignPatterns.Creational.Builder.RealWorld;
using Xunit;

namespace DesignPatterns.Tests.Creational.Builder
{


    public class BuilderRealWorldTests
    {
        [Fact]
        public void TestBuilderRealWorld()
        {
            var shop = new Shop();
            
            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.GetVehicle.Show();
            
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.GetVehicle.Show();
            
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.GetVehicle.Show();
        }
    }
}