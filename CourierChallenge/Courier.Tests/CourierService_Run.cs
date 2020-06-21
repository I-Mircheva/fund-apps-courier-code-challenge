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
            OutputParcel outputParcel = new OutputParcel(new Parcel(30, 10, 30, 1), 0, 8);

            var mockParcelManager = new Mock<ParcelManager>();
            mockParcelManager.Setup(x => x.DetermineOutputParcel(It.IsAny<Parcel>()))
                    .Returns(outputParcel);

            ParcelManager parcelManager = mockParcelManager.SetupAllProperties().Object;

            var result = DefaultCourierService().Run(parcels, isSpeedy, parcelManager);
            string combindedString = string.Join("", result.ToArray());

            Assert.Equal("Medium parcel: $8\nMedium parcel: $8\nTotal Cost: $16", combindedString);
        }

        [Fact]
        public void Run_InputParcelListSpeedy_ReturnOutputString()
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(30, 10, 30, 1));
            parcels.Add(new Parcel(30, 10, 30, 1));

            bool isSpeedy = true;
            OutputParcel outputParcel = new OutputParcel(new Parcel(30, 10, 30, 1), 0, 8);

            var mockParcelManager = new Mock<ParcelManager>();
            mockParcelManager.Setup(x => x.DetermineOutputParcel(It.IsAny<Parcel>()))
                    .Returns(outputParcel);

            ParcelManager parcelManager = mockParcelManager.SetupAllProperties().Object;

            var result = DefaultCourierService().Run(parcels, isSpeedy, parcelManager);
            string combindedString = string.Join("", result.ToArray());

            Assert.Equal("Medium parcel: $8\nMedium parcel: $8\nTotal Cost with Speedy Shipping: $32", combindedString);
        }
    }
}
