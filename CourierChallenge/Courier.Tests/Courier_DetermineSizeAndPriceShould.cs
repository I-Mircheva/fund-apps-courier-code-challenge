using Xunit;

namespace Courier.UnitTests
{
    public class Courier_DetermineSizeAndPriceShould
    {
        private readonly ParcelManager parcelManager;

        public Courier_DetermineSizeAndPriceShould()
        {
            parcelManager = new ParcelManager();
        }

        [Fact]
        public void DetermineSizeAndPrice_InputMedium_ReturnOutput()
        {
            Parcel mediumParcel = new Parcel(30, 10, 30);

            var result = parcelManager.DetermineSizeAndPrice(mediumParcel);

            Assert.Equal("Medium parcel: $8\n", result.GetFormattedOutput());
        }

        [Fact]
        public void DetermineSizeAndPrice_InputSmall_ReturnOutput()
        {
            Parcel smallParcel = new Parcel(5, 1, 3);

            var result = parcelManager.DetermineSizeAndPrice(smallParcel);

            Assert.Equal("Small parcel: $3\n", result.GetFormattedOutput());
        }

        [Fact]
        public void DetermineSizeAndPrice_InputLarge_ReturnOutput()
        {
            Parcel largeParcel = new Parcel(50, 10, 30);

            var result = parcelManager.DetermineSizeAndPrice(largeParcel);

            Assert.Equal("Large parcel: $15\n", result.GetFormattedOutput());
        }
        [Fact]
        public void DetermineSizeAndPrice_InputXL_ReturnOutput()
        {
            Parcel XLParcel = new Parcel(50, 100, 30);

            var result = parcelManager.DetermineSizeAndPrice(XLParcel);

            Assert.Equal("XL parcel: $25\n", result.GetFormattedOutput());
        }
    }
}
