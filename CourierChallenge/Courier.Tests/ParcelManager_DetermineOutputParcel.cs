using Xunit;
using Moq;

namespace Courier.UnitTests
{
    public class ParcelManager_DetermineOutputParcel
    {
        public ParcelManager DefaultParcelManager()
        {
            return new ParcelManager();
        }

        [Fact]
        public void DetermineOutputParcel_InputParcel_ReturnOutputParcel()
        {
            Parcel mediumParcel = new Parcel(10, 10, 40, 3);

            ParcelManager parcelManager = DefaultParcelManager();

            OutputParcel result = parcelManager.DetermineOutputParcel(mediumParcel);

            string formattedResult = result.GetFormattedOutput();

            Assert.Equal("Medium parcel: $8\n", formattedResult);

        }
        [Fact]
        public void DetermineOutputParcel_InputHeavyParcel_ReturnOutputParcel()
        {
            Parcel heavyParcel = new Parcel(6, 8, 4, 90);

            ParcelManager parcelManager = DefaultParcelManager();

            OutputParcel result = parcelManager.DetermineOutputParcel(heavyParcel);

            string formattedResult = result.GetFormattedOutput();

            Assert.Equal("Heavy parcel + 40 kg: $90\n", formattedResult);

        }

    }
}
