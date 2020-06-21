using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class ParcelManager_GetParcelOverweight
    {
        public ParcelManager DefaultParcelManager()
        {
            return new ParcelManager();
        }

        [Fact]
        public void GetParcelOverweight_InputParcelOverweight_ReturnParcelOverweight()
        {
            ParcelSize parcelSize = ParcelSize.Large;
            Parcel parcel = new Parcel(23, 50, 2, 10);

            var result = DefaultParcelManager().GetParcelOverweight(parcelSize, parcel);

            Assert.Equal(4, result);
        }

        [Fact]
        public void GetParcelOverweight_InputParcelRightWeight_Return0()
        {
            ParcelSize parcelSize = ParcelSize.Large;
            Parcel parcel = new Parcel(23, 50, 2, 6);

            var result = DefaultParcelManager().GetParcelOverweight(parcelSize, parcel);

            Assert.Equal(0, result);
        }
    }
}
