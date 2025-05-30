using System;

namespace ProboTankiLibCS.Utils
{
    /// <summary>
    /// Represents a 3D vector with X, Y, and Z coordinates
    /// </summary>
    public class Vector3D
    {
        /// <summary>
        /// Gets or sets the X coordinate
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Gets or sets the Z coordinate
        /// </summary>
        public float Z { get; set; }

        /// <summary>
        /// Creates a new instance of Vector3D with all coordinates set to 0
        /// </summary>
        public Vector3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        /// <summary>
        /// Creates a new instance of Vector3D with the specified coordinates
        /// </summary>
        /// <param name="x">The X coordinate</param>
        /// <param name="y">The Y coordinate</param>
        /// <param name="z">The Z coordinate</param>
        public Vector3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Returns a string representation of this Vector3D
        /// </summary>
        /// <returns>A string in the format "(X, Y, Z)"</returns>
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        /// <summary>
        /// Determines whether this Vector3D is equal to another object
        /// </summary>
        /// <param name="obj">The object to compare with</param>
        /// <returns>True if the objects are equal, false otherwise</returns>
        public override bool Equals(object obj)
        {
            if (obj is Vector3D other)
            {
                return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
            }
            return false;
        }

        /// <summary>
        /// Gets the hash code for this Vector3D
        /// </summary>
        /// <returns>A hash code for this Vector3D</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }
} 