using System;

namespace DBFilesClient.NET
{
    /// <summary>
    /// Controls how the field is treated by the DBC storage loader.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class StoragePresenceAttribute : Attribute
    {
        internal static readonly Type Type = typeof(StoragePresenceAttribute);

        /// <summary>
        /// Gets the value that specifies how the underlying class field should be treated when loading from a DBC storage.
        /// </summary>
        public StoragePresenceOption Option { get; private set; }

        /// <summary>
        /// Gets or sets the name of of the property that should be used instead of the underlying class field.
        /// Use it with <see cref="DBFilesClient.NET.StoragePresenceOption.UseProperty"/> value.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the number of elements in the underlying array.
        /// </summary>
        public int ArraySize { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="DBFilesClient.NET.StoragePresenceAttribute"/>
        /// with the specified <see cref="DBFilesClient.NET.StoragePresenceOption"/>.
        /// </summary>
        /// <param name="option">
        /// Specifies how the underlying class field should be treated when loading from a DBC storage.
        /// </param>
        public StoragePresenceAttribute(StoragePresenceOption option)
        {
            this.Option = option;
        }
    }
}
