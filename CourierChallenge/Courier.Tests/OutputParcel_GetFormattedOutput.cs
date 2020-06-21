using System.Collections.Generic;
using Moq;
using Xunit;

namespace Courier.UnitTests
{
    public class OutputParcel_GetFormattedOutput
    {

        [Fact]
        public void GetFormattedOutput_InputParcel_ReturnOutputString()
        {
            OutputParcel outputParcel = new OutputParcel(new Parcel(30, 10, 30, 1), 0, 3);
            var result = outputParcel.GetFormattedOutput();

            Assert.Equal("Medium parcel: $3\n", result);
        }
        [Fact]
        public void GetFormattedOutput_InputParcelOverweight_ReturnOverweightString()
        {
            OutputParcel outputParcel = new OutputParcel(new Parcel(30, 10, 30, 1), 10, 3);
            var result = outputParcel.GetFormattedOutput();

            Assert.Equal("Medium parcel + 10 kg: $3\n", result);
        }
    }
}
