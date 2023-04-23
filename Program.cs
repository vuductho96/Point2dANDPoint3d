using System;

namespace Point2d
{
    public class Point2d
    {
        private float x, y;

        public Point2d(float X = 0.0f, float Y = 0.0f)
        {
            x = X;
            y = Y;
        }

        public float GetX()
        {
            return x;
        }

        public void SetX(float X)
        {
            x = X;
        }

        public void SetY(float Y)
        {
            y = Y;
        }

        public float GetY()
        {
            return y;
        }

        public void SetXY(float X, float Y)
        {
            x = X;
            y = Y;
        }

        public float[] GetXY()
        {
            return new float[] { x, y };
        }

        public override string ToString()
        {
            return string.Format("Toa do cua x va y la: ({0}, {1})", x, y);
        }
    }

    public class Point3d : Point2d
    {
        private float z;

        public Point3d(float X = 0.0f, float Y = 0.0f, float Z = 0.0f) : base(X, Y)
        {
            z = Z;
        }

        public float GetZ()
        {
            return z;
        }

        public void SetZ(float Z)
        {
            z = Z;
        }

        public void SetXYZ(float X, float Y, float Z)
        {
            SetXY(X, Y);
            z = Z;
        }

        public float[] GetXYZ()
        {
            return new float[] { GetX(), GetY(), z };
        }

        public override string ToString()
        {
            return string.Format("Toa do X, Y, Z la: ({0}, {1}, {2})", GetX(), GetY(), z);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Point2d pointxy = new Point2d(1.0f, 2.0f);
            Console.WriteLine(pointxy.ToString());
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Point3d pointxyz = new Point3d(3.0f, 4.0f, 5.0f);
            Console.WriteLine(pointxyz.ToString());
        }
    }
}

