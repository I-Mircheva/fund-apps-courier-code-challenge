using System.Collections.Generic;

namespace Courier
{
    public class PriceManager
    {
        private Dictionary<ParcelSize, int> priceList;

        public PriceManager()
        {
            priceList = new Dictionary<ParcelSize, int>();
            priceList.Add(ParcelSize.Small, 3);
            priceList.Add(ParcelSize.Medium, 8);
            priceList.Add(ParcelSize.Large, 15);
            priceList.Add(ParcelSize.XL, 25);
        }

        public virtual int GetParcelPrice(ParcelSize parcelSize)
        {
            return priceList.GetValueOrDefault(parcelSize);
        }
    }
}