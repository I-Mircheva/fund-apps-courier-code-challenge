using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class Courier_RunSpeedyShould
    {
        private readonly CourierService courierService;

        public Courier_RunSpeedyShould()
        {
            courierService = new CourierService();
        }

        [Fact]
        public void Run_InputMedium_ReturnOutput()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(20, 10, 30));
            parcels.Add(new Parcel(2, 1, 3));
            parcels.Add(new Parcel(50, 10, 30));

            var result = courierService.Run(parcels, true);

            Assert.Equal("Medium parcel: $8\nSmall parcel: $3\nLarge parcel: $15\nTotal Cost with Speedy Shipping: $52", result);
        }
    }
}
