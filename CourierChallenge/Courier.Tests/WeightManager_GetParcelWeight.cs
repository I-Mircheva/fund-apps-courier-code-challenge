using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class WeightManager_GetParcelWeight
    {
        public WeightManager DefaultWeightManager()
        {
            return new WeightManager();
        }

        [Fact]
        public void Run_InputSmallSize_ReturnSmallWeight()
        {
            ParcelSize smallParcel = ParcelSize.Small;
            var result = DefaultWeightManager().GetParcelWeight(smallParcel);

            Assert.Equal(1, result);
        }
        [Fact]
        public void Run_InputMediumSize_ReturnMediumWeight()
        {
            ParcelSize parcelSize = ParcelSize.Medium;
            var result = DefaultWeightManager().GetParcelWeight(parcelSize);

            Assert.Equal(3, result);
        }
        [Fact]
        public void Run_InputLargeSize_ReturnLargeWeight()
        {
            ParcelSize parcelSize = ParcelSize.Large;
            var result = DefaultWeightManager().GetParcelWeight(parcelSize);

            Assert.Equal(6, result);
        }
        [Fact]
        public void Run_InputXLSize_ReturnXLWeight()
        {
            ParcelSize parcelSize = ParcelSize.XL;
            var result = DefaultWeightManager().GetParcelWeight(parcelSize);

            Assert.Equal(10, result);
        }
    }
}
