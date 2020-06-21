using System;
using System.Collections.Generic;

namespace Courier
{
    public class CourierService
    {

        private const string TOTAL_STRING = "Total Cost: $";
        static public void Main(String[] args)
        {
            List<Parcel> parcels = new List<Parcel>();
            parcels.Add(new Parcel(20, 10, 30));
            parcels.Add(new Parcel(7, 1, 3));
            parcels.Add(new Parcel(50, 10, 40));
            string output = new CourierService().Run(parcels);
        }

        public string Run(List<Parcel> parcels)
        {
            string output = "";
            ParcelManager parcelManager = new ParcelManager();
            int total = 0;
            foreach (Parcel parcel in parcels)
            {
                OutputParcel outputParcel = parcelManager.DetermineSizeAndPrice(parcel);
                total += outputParcel.price;
                output += outputParcel.GetFormattedOutput();
                Console.WriteLine(outputParcel.GetFormattedOutput());
            }
            Console.WriteLine(TOTAL_STRING + total);
            output += TOTAL_STRING + total;
            return output;
        }
    }
}
