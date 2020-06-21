namespace Courier
{

    public class OutputParcel
    {
        private ParcelType parcelType;
        public int price { get; }
        public int overweight { get; }

        public OutputParcel(Parcel parcel, int overweight, int price)
        {
            this.parcelType = parcel.parcelType;
            this.price = price;
            this.overweight = overweight;
        }

        public string GetFormattedOutput()
        {
            if (this.overweight == 0)
            {
                return $"{this.parcelType} parcel: ${this.price}\n";
            }
            else
            {
                return $"{this.parcelType} parcel + {this.overweight} kg: ${this.price}\n";
            }
        }
    }
}