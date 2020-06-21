namespace Courier
{

    public class OutputParcel
    {
        private ParcelSize parcelSize;
        public int price { get; }
        public int overweight { get; }

        public OutputParcel(ParcelSize parcelSize, int overweight, int price)
        {
            this.parcelSize = parcelSize;
            this.price = price;
            this.overweight = overweight;
        }

        public string GetFormattedOutput()
        {
            if (this.overweight == 0)
            {
                return $"{this.parcelSize} parcel: ${this.price}\n";
            }
            else
            {
                return $"{this.parcelSize} parcel + {this.overweight} kg: ${this.price}\n";
            }
        }
    }
}