using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class PriceManager_GetParcelPrice
    {
        public PriceManager DefaultPriceManager()
        {
            return new PriceManager();
        }

        [Fact]
        public void Run_InputSmallSize_ReturnSmallPrice()
        {
            ParcelType smallParcel = ParcelType.Small;
            var result = DefaultPriceManager().GetParcelPrice(smallParcel);

            Assert.Equal(3, result);
        }
    }
}
