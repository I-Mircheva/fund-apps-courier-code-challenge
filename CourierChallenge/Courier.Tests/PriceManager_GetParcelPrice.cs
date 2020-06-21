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
            ParcelSize smallParcel = ParcelSize.Small;
            var result = DefaultPriceManager().GetParcelPrice(smallParcel);

            Assert.Equal(3, result);
        }
        [Fact]
        public void Run_InputMediumSize_ReturnMediumPrice()
        {
            ParcelSize parcelSize = ParcelSize.Medium;
            var result = DefaultPriceManager().GetParcelPrice(parcelSize);

            Assert.Equal(8, result);
        }
        [Fact]
        public void Run_InputLargeSize_ReturnLargePrice()
        {
            ParcelSize parcelSize = ParcelSize.Large;
            var result = DefaultPriceManager().GetParcelPrice(parcelSize);

            Assert.Equal(15, result);
        }
        [Fact]
        public void Run_InputXLSize_ReturnXLPrice()
        {
            ParcelSize parcelSize = ParcelSize.XL;
            var result = DefaultPriceManager().GetParcelPrice(parcelSize);

            Assert.Equal(25, result);
        }
    }
}
