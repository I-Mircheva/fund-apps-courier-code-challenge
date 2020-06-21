using System.Collections.Generic;

namespace Courier
{
    public class WeightManager
    {
        private Dictionary<ParcelSize, int> weightList;

        public WeightManager()
        {
            weightList = new Dictionary<ParcelSize, int>();
            weightList.Add(ParcelSize.Small, 1);
            weightList.Add(ParcelSize.Medium, 3);
            weightList.Add(ParcelSize.Large, 6);
            weightList.Add(ParcelSize.XL, 10);
        }
        public int GetParcelWeight(ParcelSize parcelSize)
        {
            return weightList.GetValueOrDefault(parcelSize);
        }
    }
}