using System.Collections.Generic;
using System.Linq;

namespace Courier
{
    public enum ParcelType
    {
        Small,
        Medium,
        Large,
        XL,
        Heavy
    }
    public class Parcel
    {
        public int dimentionX { get; }
        public int dimentionY { get; }
        public int dimentionZ { get; }
        public int weight { get; }
        public ParcelType parcelType { get; }

        public Parcel(int dimentionX, int dimentionY, int dimentionZ, int weight)
        {
            this.dimentionX = dimentionX;
            this.dimentionY = dimentionY;
            this.dimentionZ = dimentionZ;
            this.weight = weight;
            this.parcelType = GetParcelType();
        }

        public Parcel(Parcel parcel, ParcelType parcelType)
        {
            this.dimentionX = parcel.dimentionX;
            this.dimentionY = parcel.dimentionY;
            this.dimentionZ = parcel.dimentionZ;
            this.weight = parcel.weight;
            this.parcelType = parcelType;
        }

        public ParcelType GetParcelType()
        {
            List<int> dimentions = new List<int>();
            dimentions.Add(this.dimentionX);
            dimentions.Add(this.dimentionY);
            dimentions.Add(this.dimentionZ);

            int maxDimention = dimentions.Max();
            ParcelType parcelType = ParcelType.Small;

            if (maxDimention < 10)
            {
                parcelType = ParcelType.Small;
            }
            else if (maxDimention < 50 && maxDimention >= 10)
            {
                parcelType = ParcelType.Medium;
            }
            else if (maxDimention < 100 && maxDimention >= 50)
            {
                parcelType = ParcelType.Large;
            }
            else if (maxDimention >= 100)
            {
                parcelType = ParcelType.XL;
            }
            return parcelType;
        }

        public int GetBasePrice()
        {
            PriceManager priceManager = new PriceManager();
            return priceManager.GetParcelPrice(this.parcelType);
        }

        public int GetParcelOverweight()
        {
            WeightManager weightManager = new WeightManager();
            int overweight = 0;
            int maxFreeWeight = weightManager.GetParcelWeight(this.parcelType);

            if (this.weight > maxFreeWeight)
            {
                overweight = this.weight - maxFreeWeight;
            }
            return overweight;
        }
    }
}