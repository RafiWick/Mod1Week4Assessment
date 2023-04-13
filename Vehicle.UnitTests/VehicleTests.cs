namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            // needed to add a comma and a period to match Sumary
            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";
            Assert.Equal(expected, andysBike.Sumary());
        }
        [Fact]
        public void Drive_Adds5MilesAtATime()
        {
            var vehicle1 = new Vehicle(4, "color1");
            vehicle1.Drive();
            Assert.Equal(5, vehicle1.MilesDriven);
            vehicle1.Drive();
            Assert.Equal(10, vehicle1.MilesDriven);
            vehicle1.Drive();
            Assert.Equal(15, vehicle1.MilesDriven);
        }
        [Fact]
        public void Paint_ChangesColor_ToSetNewColor()
        {
            var vehicle1 = new Vehicle(4, "color1");
            vehicle1.Paint("color2");
            Assert.Equal("color2", vehicle1.Color);
            vehicle1.Paint("color3");
            Assert.Equal("color3", vehicle1.Color);
            vehicle1.Paint("color4");
            Assert.Equal("color4", vehicle1.Color);
        }
        // Add more tests here!
    }
}