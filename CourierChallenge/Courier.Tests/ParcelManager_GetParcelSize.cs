using Xunit;

namespace Courier.UnitTests
{
    public class ParcelManager_GetParcelSize
    {
        public ParcelManager DefaultParcelManager()
        {
            return new ParcelManager();
        }

        [Fact]
        public void GetParcelSize_InputSmallParcel_ReturnSmallSize()
        {
            Parcel parcel = new Parcel(6, 6, 2, 10);

            var result = DefaultParcelManager().GetParcelSize(parcel);

            Assert.Equal(ParcelSize.Small, result);
        }

        [Fact]
        public void GetParcelSize_InputMediumParcel_ReturnMediumSize()
        {
            Parcel parcel = new Parcel(15, 14, 12, 1);

            var result = DefaultParcelManager().GetParcelSize(parcel);

            Assert.Equal(ParcelSize.Medium, result);
        }

        [Fact]
        public void GetParcelSize_InputLargeParcel_ReturnLargeSize()
        {
            Parcel parcel = new Parcel(23, 50, 2, 5);

            var result = DefaultParcelManager().GetParcelSize(parcel);

            Assert.Equal(ParcelSize.Large, result);
        }

        [Fact]
        public void GetParcelSize_InputXLParcel_ReturnXLSize()
        {
            Parcel parcel = new Parcel(140, 50, 2, 10);

            var result = DefaultParcelManager().GetParcelSize(parcel);

            Assert.Equal(ParcelSize.XL, result);
        }
    }
}
