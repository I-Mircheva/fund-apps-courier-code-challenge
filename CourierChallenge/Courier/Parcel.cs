namespace Courier
{

    public enum ParcelSize
    {
        Small,
        Medium,
        Large,
        XL
    }
    public class Parcel
    {
        public int dimentionX { get; }
        public int dimentionY { get; }
        public int dimentionZ { get; }
        public int weight { get; }

        public Parcel(int dimentionX, int dimentionY, int dimentionZ, int weight)
        {
            this.dimentionX = dimentionX;
            this.dimentionY = dimentionY;
            this.dimentionZ = dimentionZ;
            this.weight = weight;
        }
    }
}