using System.Collections;
namespace Vector3D
{
    
    public class Vector3D : ICloneable, IEnumerable<double>, IEquatable<Vector3D>, IComparable<Vector3D>
    {
        protected double x;
        protected double y;
        protected double z;

     
        public Vector3D() : this(0, 0, 0) { }

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D(Vector3D other) : this(other.x, other.y, other.z) { }

       
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public bool IsInteger
        {
            get { return x % 1 == 0 && y % 1 == 0 && z % 1 == 0; }
        }

        public bool IsPositive
        {
            get { return x > 0 && y > 0 && z > 0; }
        }

        
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static double Distance(Vector3D v1, Vector3D v2)
        {
            double dx = v1.x - v2.x;
            double dy = v1.y - v2.y;
            double dz = v1.z - v2.z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static bool operator |(Vector3D v1, Vector3D v2)
        {
         
            return (v1.x * v2.y - v1.y * v2.x) == 0 && (v1.y * v2.z - v1.z * v2.y) == 0 && (v1.z * v2.x - v1.x * v2.z) == 0;
        }

        public static double operator *(Vector3D v1, Vector3D v2)
        {
            
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static Vector3D operator ^(Vector3D v1, Vector3D v2)
        {
            double x = v1.y * v2.z - v1.z * v2.y;
            double y = v1.z * v2.x - v1.x * v2.z;
            double z = v1.x * v2.y - v1.y * v2.x;
            return new Vector3D(x, y, z);
        }

        public object Clone()
        {
            return new Vector3D(this);
        }

        public IEnumerator<double> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

     
        public bool Equals(Vector3D other)
        {
            if (ReferenceEquals(null, other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != this.GetType())
                return false;

            return Equals((Vector3D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                return hashCode;
            }
        }

        
        public int CompareTo(Vector3D other)
        {
            double length = Length();
            double otherLength = other.Length();

            if (length < otherLength)
                return -1;

            if (length > otherLength)
                return 1;

            return 0;
        }

      
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        public static double Average(Vector3D vector)
        {
            return (vector.x + vector.y + vector.z) / 3;
        }
    }
}