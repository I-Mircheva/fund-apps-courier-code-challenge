using System.Collections.Generic;

namespace Courier
{
    public class WeightManager
    {
        private Dictionary<ParcelType, int> weightList;

        public WeightManager()
        {
            weightList = new Dictionary<ParcelType, int>();
            weightList.Add(ParcelType.Small, 1);
            weightList.Add(ParcelType.Medium, 3);
            weightList.Add(ParcelType.Large, 6);
            weightList.Add(ParcelType.XL, 10);
            weightList.Add(ParcelType.Heavy, 50);
        }
        public int GetParcelWeight(ParcelType parcelSize)
        {
            // TODO: Throw Exception if ParcelType has no Weight
            return weightList.GetValueOrDefault(parcelSize);
        }
    }
}