using System.Linq;
using System.Collections.Generic;
using System;

namespace Courier
{
    public class ParcelManager
    {
        public OutputParcel DetermineSizeAndPrice(Parcel parcel)
        {
            ParcelSize parcelSize = GetParcelSize(parcel);

            PriceManager priceManager = new PriceManager();
            int price = priceManager.priceList.GetValueOrDefault(parcelSize);

            return new OutputParcel(parcelSize, price);
        }

        private ParcelSize GetParcelSize(Parcel parcel)
        {

            List<int> dimentions = new List<int>();
            dimentions.Add(parcel.dimentionX);
            dimentions.Add(parcel.dimentionY);
            dimentions.Add(parcel.dimentionZ);

            int maxDimention = dimentions.Max();
            ParcelSize parcelSize = ParcelSize.Small;

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
            return parcelSize;

        }
    }
}