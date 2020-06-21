using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class Courier_RunSizeShould
    {
        private readonly CourierService courierService;

        public Courier_RunSizeShould()
        {
            courierService = new CourierService();
        }

        [Fact]
        public void Run_InputMedium_ReturnOutput()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(20, 10, 30));

            var result = courierService.Run(parcels);

            Assert.Equal("Medium parcel: $8\nTotal Cost: $8", result);
        }

        [Fact]
        public void Run_InputSmall_ReturnOutput()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(2, 1, 3));

            var result = courierService.Run(parcels);

            Assert.Equal("Small parcel: $3\nTotal Cost: $3", result);
        }

        [Fact]
        public void Run_InputLarge_ReturnOutput()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(50, 10, 30));

            var result = courierService.Run(parcels);

            Assert.Equal("Large parcel: $15\nTotal Cost: $15", result);
        }
    }
}
