using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class ParcelManager_GetBasePrice
    {
        public ParcelManager DefaultParcelManager()
        {
            return new ParcelManager();
        }


        [Fact]
        public void GetBasePrice_InputParcelSize_ReturnParcelPrice()
        {
            ParcelSize parcelSize = ParcelSize.Large;

            var result = DefaultParcelManager().GetBasePrice(parcelSize);

            Assert.Equal(15, result);
        }
    }
}
