using System;

namespace Emby.Naming.AudioBook
{
    /// <summary>
    /// Data object used to pass result of name and year parsing.
    /// </summary>
    public struct AudioBookNameParserResult : IEquatable<AudioBookNameParserResult>
    {
        /// <summary>
        /// Gets or sets name of audiobook.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional year of release.
        /// </summary>
        public int? Year { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public bool Equals(AudioBookNameParserResult other)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

#pragma warning disable SA1201 // Elements should appear in the correct order
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static bool operator ==(AudioBookNameParserResult left, AudioBookNameParserResult right)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return left.Equals(right);
        }
#pragma warning restore SA1201 // Elements should appear in the correct order

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static bool operator !=(AudioBookNameParserResult left, AudioBookNameParserResult right)
        {
            return !(left == right);
        }
    }
}
