using System;
using System.Diagnostics.CodeAnalysis;

namespace Zee.CSharp.ValueEquality
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        private string identityNo;

        public Person(string identityNo)
        {
            this.IdentityNo = identityNo;
        }

        #region properties
        public string IdentityNo { get => identityNo; private set => identityNo = value;}
        public string Name { get; set; }
        #endregion

        #region override
        public override bool Equals(object obj) => this.Equals(obj);

        // two objects that have value equality produce the same hash code.
        public override int GetHashCode() => this.IdentityNo.GetHashCode();
        #endregion

        #region implement IEquatable
        public bool Equals([AllowNull] Person other)
        {
            if (object.ReferenceEquals(null, other)) return false;

            if (object.ReferenceEquals(this, other)) return true;

            if (this.GetType() != other.GetType()) return false;

            return IdentityNo.ToUpper() == other.IdentityNo.ToUpper();
        }

        #endregion

        #region Implement Icomparable
        public int CompareTo([AllowNull] Person other)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region override operators
        public static bool operator ==(Person left, Person right)
        {
            // Check for null on left side.
            if (Object.ReferenceEquals(left, null))
            {
                if (Object.ReferenceEquals(right, null))
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return left.Equals(right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }

        public static bool operator <=(Person left, Person right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >=(Person left, Person right)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
