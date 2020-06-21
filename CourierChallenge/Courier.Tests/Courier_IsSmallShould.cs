using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class Courier_IsSmallShould
    {
        private readonly CourierService courierService;

        public Courier_IsSmallShould()
        {
            courierService = new CourierService();
        }

        [Fact]
        public void IsSmall_InputIs1_ReturnFalse()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(20, 10, 30));

            var result = courierService.Run(parcels);

            Assert.Equal("Medium parcel: $8\nTotal Cost: $8", result);
        }
    }
}
