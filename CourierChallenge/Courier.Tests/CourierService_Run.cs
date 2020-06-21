using System.Collections.Generic;
using Moq;
using Xunit;

namespace Courier.UnitTests
{
    public class CourierService_Run
    {

        public CourierService DefaultCourierService()
        {
            return new CourierService();
        }

        [Fact]
        public void Run_InputParcelListNoSpeedy_ReturnOutputString()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(30, 10, 30, 1));
            parcels.Add(new Parcel(30, 10, 30, 1));

            bool isSpeedy = false;
            ParcelSize mediumSize = ParcelSize.Medium;
            OutputParcel outputParcel = new OutputParcel(mediumSize, 0, 8);

            var mockParcelManager = new Mock<ParcelManager>();
            mockParcelManager.Setup(x => x.DetermineOutputParcel(It.IsAny<Parcel>()))
                    .Returns(outputParcel);

            ParcelManager parcelManager = mockParcelManager.SetupAllProperties().Object;

            var result = DefaultCourierService().Run(parcels, isSpeedy, parcelManager);

            Assert.Equal("Medium parcel: $8\nMedium parcel: $8\nTotal Cost: $16", result);
        }

        [Fact]
        public void Run_InputParcelListSpeedy_ReturnOutputString()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(30, 10, 30, 1));
            parcels.Add(new Parcel(30, 10, 30, 1));

            bool isSpeedy = true;
            ParcelSize mediumSize = ParcelSize.Medium;
            OutputParcel outputParcel = new OutputParcel(mediumSize, 0, 8);

            var mockParcelManager = new Mock<ParcelManager>();
            mockParcelManager.Setup(x => x.DetermineOutputParcel(It.IsAny<Parcel>()))
                    .Returns(outputParcel);

            ParcelManager parcelManager = mockParcelManager.SetupAllProperties().Object;

            var result = DefaultCourierService().Run(parcels, isSpeedy, parcelManager);

            Assert.Equal("Medium parcel: $8\nMedium parcel: $8\nTotal Cost with Speedy Shipping: $32", result);
        }
    }
}
