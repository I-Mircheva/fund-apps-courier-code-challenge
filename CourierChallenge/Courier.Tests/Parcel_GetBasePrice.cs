using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class Parcel_GetBasePrice
    {
        public ParcelManager DefaultParcelManager()
        {
            return new ParcelManager();
        }


        [Fact]
        public void GetBasePrice_InputParcelSize_ReturnParcelPrice()
        {
            Parcel parcel = new Parcel(1, 1, 4, 5);

            var result = parcel.GetBasePrice();

            Assert.Equal(3, result);
        }
    }
}
