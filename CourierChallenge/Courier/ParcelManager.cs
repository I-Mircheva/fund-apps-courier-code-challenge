using System.Linq;
using System.Collections.Generic;

namespace Courier
{
    public class ParcelManager
    {
        public OutputParcel DetermineSizeAndPrice(Parcel parcel)
        {

            List<int> dimentions = new List<int>();
            dimentions.Add(parcel.dimentionX);
            dimentions.Add(parcel.dimentionY);
            dimentions.Add(parcel.dimentionZ);

            int maxDimention = dimentions.Max();
            ParcelSize parcelSize = ParcelSize.Small;

            PriceManager priceManager = new PriceManager();
            int price = 0;

            if (maxDimention < 10)
            {
                parcelSize = ParcelSize.Small;
            }
            else if (maxDimention < 50 && maxDimention >= 10)
            {
                parcelSize = ParcelSize.Medium;
            }
            else if (maxDimention < 100 && maxDimention >= 50)
            {
                parcelSize = ParcelSize.Large;
            }
            else if (maxDimention >= 100)
            {
                parcelSize = ParcelSize.XL;
            }

            price = priceManager.priceList.GetValueOrDefault(parcelSize);


            return new OutputParcel(parcelSize, price);
        }
    }
}