namespace Courier
{
    public class Parcel
    {
        public int dimentionX { get; }
        public int dimentionY { get; }
        public int dimentionZ { get; }

        public Parcel(int dimentionX, int dimentionY, int dimentionZ)
        {
            this.dimentionX = dimentionX;
            this.dimentionY = dimentionY;
            this.dimentionZ = dimentionZ;
        }
    }
}