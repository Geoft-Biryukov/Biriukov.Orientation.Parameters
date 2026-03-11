namespace Biriukov.Orientation.Parameters.Domain
{
    public class QuaternionDto(double w, double x, double y, double z)
    {
        public double W { get; } = w;
        public double X { get; } = x;
        public double Y { get; } = y;
        public double Z { get; } = z;

    }
}
