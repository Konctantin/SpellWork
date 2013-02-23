using System;

namespace DBFilesClient.NET
{
    [Flags]
    public enum LoadFlags
    {
        None                    = 0,
        IgnoreWrongFourCC       = 1 << 0,
        /// <summary>
        /// Enables laziness of <see cref="DBFilesClient.NET.LazyCString"/>.
        /// </summary>
        LazyCStrings            = 1 << 1,
    }
}
