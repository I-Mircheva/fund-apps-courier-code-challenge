using System.Collections.Generic;

namespace Courier
{
    public class PriceManager
    {
        private Dictionary<ParcelType, int> priceList;

        public PriceManager()
        {
            priceList = new Dictionary<ParcelType, int>();
            priceList.Add(ParcelType.Small, 3);
            priceList.Add(ParcelType.Medium, 8);
            priceList.Add(ParcelType.Large, 15);
            priceList.Add(ParcelType.XL, 25);
            priceList.Add(ParcelType.Heavy, 50);
        }

        public virtual int GetParcelPrice(ParcelType parcelSize)
        {
            // TODO: Throw Exception if ParcelType has no Price
            return priceList.GetValueOrDefault(parcelSize);
        }
    }
}