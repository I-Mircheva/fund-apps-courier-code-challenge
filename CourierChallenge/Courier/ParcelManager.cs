using System.Linq;
using System.Collections.Generic;
using System;

namespace Courier
{
    public class ParcelManager
    {
        private const int PRICE_PER_KILO = 2;
        private const int PRICE_PER_KILO_HEAVY = 1;
        private const int PRICE_HEAVY = 50;
        public virtual OutputParcel DetermineOutputParcel(Parcel parcel)
        {
            Parcel outputParcel = parcel;

            int overweight = parcel.GetParcelOverweight();
            int basePrice = parcel.GetBasePrice();

            int price = basePrice + overweight * PRICE_PER_KILO;
            int priceWithOverweightAdjustment = price;

            if (price >= PRICE_HEAVY)
            {
                outputParcel = new Parcel(parcel, ParcelType.Heavy);
                overweight = outputParcel.GetParcelOverweight();
                priceWithOverweightAdjustment = outputParcel.GetBasePrice() + overweight * PRICE_PER_KILO_HEAVY;
            }
            return new OutputParcel(outputParcel, overweight, priceWithOverweightAdjustment);
        }
    }
}