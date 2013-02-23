
namespace DBFilesClient.NET
{
    /// <summary>
    /// Specifies how a class field should be treated when loading from a DBC storage.
    /// </summary>
    public enum StoragePresenceOption
    {
        /// <summary>
        /// Specifies that the field should be included into the storage entry structure.
        /// This is the default behavior.
        /// </summary>
        Include,

        /// <summary>
        /// Specifies that the field should be completely ignored by the DBC stoarge loader.
        /// </summary>
        Exclude,

        /// <summary>
        /// Specifies that the DBC storage loader should use property instead.
        /// You should specify the <see cref="DBFilesClient.NET.StoragePresenceAttribute.PropertyName"/> property.
        /// The property should be of the same type as the field, and its setter should be public.
        /// </summary>
        UseProperty,
    }
}
