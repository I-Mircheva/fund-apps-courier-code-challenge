using System;
using System.Collections.Generic;

namespace Courier
{
    public class CourierService
    {
        private const string TOTAL_STRING = "Total Cost: $";
        private const string TOTAL_SPEEDY_STRING = "Total Cost with Speedy Shipping: $";
        static public void Main(String[] args)
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(20, 10, 30, 13));
            parcels.Add(new Parcel(7, 1, 3, 1));
            parcels.Add(new Parcel(50, 10, 40, 4));

            bool isSpeedy = true;
            ParcelManager parcelManager = new ParcelManager();

            string output = new CourierService().Run(parcels, isSpeedy, parcelManager);
        }

        public string Run(List<Parcel> parcels, bool isSpeedy, ParcelManager parcelManager)
        {
            string output = "";
            int total = 0;
            foreach (Parcel parcel in parcels)
            {
                OutputParcel outputParcel = parcelManager.DetermineOutputParcel(parcel);
                total += outputParcel.price;
                output += outputParcel.GetFormattedOutput();
                Console.WriteLine(outputParcel.GetFormattedOutput());
            }

            var totalString = isSpeedy ? TOTAL_SPEEDY_STRING + total * 2 : TOTAL_STRING + total;
            Console.WriteLine(totalString);
            output += totalString;

            return output;
        }
    }
}
