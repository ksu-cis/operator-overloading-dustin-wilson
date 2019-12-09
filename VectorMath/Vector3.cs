using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Vector Addition
        public Vector3 Addition(Vector3 vector)
        {
            Vector3 result = new Vector3(X + vector.X, Y + vector.Y, Z + vector.Z);
            return result;
        }

        public void AddInPlace(Vector3 vector)
        {
            X = X + vector.X;
            Y = Y + vector.Y;
            Z = Z + vector.Z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Vector Subtraction 
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Vector Scaling 
        public static Vector3 operator *(double s, Vector3 a)
        {
            return new Vector3(s * a.X, s * a.Y, s * a.Z);
        }

        // Vector Comparison
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return !(a == b);
        }

        public static Vector3 operator ++(Vector3 a)
        {
            return new Vector3(a.X++, a.Y++, a.Z++);
        }

        public static double operator ~(Vector3 a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        public static readonly Vector3 Zero = new Vector3(0, 0, 0);

        public static bool operator true(Vector3 a)
        {
            return Zero == a;
        }
        public static bool operator false(Vector3 a)
        {
            return Zero != a;
        }
    }
}
