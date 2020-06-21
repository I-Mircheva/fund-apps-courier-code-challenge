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
            ParcelType smallParcel = ParcelType.Small;
            var result = DefaultWeightManager().GetParcelWeight(smallParcel);

            Assert.Equal(1, result);
        }
    }
}
