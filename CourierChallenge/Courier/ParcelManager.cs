using System.Linq;
using System.Collections.Generic;
using System;

namespace Courier
{
    public class ParcelManager
    {
        private const int PRICE_PER_KILO = 2;
        public virtual OutputParcel DetermineOutputParcel(Parcel parcel)
        {
            ParcelSize parcelSize = GetParcelSize(parcel);

            int overweight = GetParcelOverweight(parcelSize, parcel);

            int basePrice = GetBasePrice(parcelSize);

            int priceWithOverweightAdjustment = basePrice + overweight * PRICE_PER_KILO;

            return new OutputParcel(parcelSize, overweight, priceWithOverweightAdjustment);
        }

        public virtual int GetBasePrice(ParcelSize parcelSize)
        {
            PriceManager priceManager = new PriceManager();

            return priceManager.GetParcelPrice(parcelSize);
        }

        public virtual int GetParcelOverweight(ParcelSize parcelSize, Parcel parcel)
        {
            WeightManager weightManager = new WeightManager();
            int overweight = 0;
            int maxFreeWeight = weightManager.GetParcelWeight(parcelSize);

            if (parcel.weight > maxFreeWeight)
            {
                overweight = parcel.weight - maxFreeWeight;
            }

            return overweight;
        }
        public virtual ParcelSize GetParcelSize(Parcel parcel)
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