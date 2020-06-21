using System.Collections.Generic;

namespace Courier
{
    public class PriceManager
    {
        public Dictionary<ParcelSize, int> priceList { get; }

        public PriceManager()
        {
            priceList = new Dictionary<ParcelSize, int>();
            priceList.Add(ParcelSize.Small, 3);
            priceList.Add(ParcelSize.Medium, 8);
            priceList.Add(ParcelSize.Large, 15);
            priceList.Add(ParcelSize.XL, 25);
        }
    }
}