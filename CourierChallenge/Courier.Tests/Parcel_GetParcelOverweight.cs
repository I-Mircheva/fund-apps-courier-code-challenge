using System.Collections.Generic;
using Xunit;

namespace Courier.UnitTests
{
    public class Parcel_GetParcelOverweight
    {
        [Fact]
        public void GetParcelOverweight_InputParcelOverweight_ReturnParcelOverweight()
        {
            Parcel parcel = new Parcel(23, 50, 2, 10);

            var result = parcel.GetParcelOverweight();

            Assert.Equal(4, result);
        }

        [Fact]
        public void GetParcelOverweight_InputParcelRightWeight_Return0()
        {
            Parcel parcel = new Parcel(23, 50, 2, 6);

            var result = parcel.GetParcelOverweight();

            Assert.Equal(0, result);
        }
    }
}
