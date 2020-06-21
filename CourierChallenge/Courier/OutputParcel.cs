using System;

namespace Courier
{
    public enum ParcelSize
    {
        Small,
        Medium,
        Large,
        XL
    }
    public class OutputParcel
    {
        private const string PARCEL_STRING = " parcel: $";
        private ParcelSize parcelSize;
        public int price { get; }

        public OutputParcel(ParcelSize parcelSize, int price)
        {
            this.parcelSize = parcelSize;
            this.price = price;
        }

        public string GetFormattedOutput()
        {
            return this.parcelSize + PARCEL_STRING + this.price + Environment.NewLine;
        }
    }
}