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
            ParcelSize mediumSize = ParcelSize.Medium;
            int overweight = 0;
            int mediumPrice = 8;

            var mockParcelManager = new Mock<ParcelManager>();
            mockParcelManager.CallBase = true;
            mockParcelManager.Setup(x => x.GetParcelSize(mediumParcel))
                    .Returns(mediumSize);
            mockParcelManager.Setup(x => x.GetParcelOverweight(mediumSize, mediumParcel))
                    .Returns(overweight);
            mockParcelManager.Setup(x => x.GetBasePrice(mediumSize))
                    .Returns(mediumPrice);

            ParcelManager parcelManager = mockParcelManager.SetupAllProperties().Object;

            OutputParcel result = parcelManager.DetermineOutputParcel(mediumParcel);

            string formattedResult = result.GetFormattedOutput();

            Assert.Equal("Medium parcel: $8\n", formattedResult);

        }

    }
}
