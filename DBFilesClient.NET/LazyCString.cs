using System;
using System.Reflection;
using System.Text;

namespace DBFilesClient.NET
{
    /// <summary>
    /// Lazy C string computes the <see cref="System.String"/> from the underlying signed byte stream by demand.
    /// This functionality is disabled by default. Use <see cref="DBFilesClient.NET.LoadFlags.LazyCStrings"/> to enable.
    /// </summary>
    public struct LazyCString
    {
        internal static readonly MethodInfo LoadStringInfo = typeof(LazyCString).GetMethod("LoadString");

        // No idea where to put this method.
        internal static unsafe string LoadString(sbyte* pool, int length, int offset)
        {
            if (offset >= length)
                return null;

            sbyte* strong_end = pool + length;
            pool += offset;
            sbyte* end = pool;
            while (end < strong_end && *end != 0)
                ++end;

            return new string(pool, 0, (int)(end - pool), Encoding.UTF8);
        }

        string m_string;
        byte[] m_pool;
        int m_index;

        public LazyCString(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");

            m_string = str;
            m_pool = null;
            m_index = -1;
        }

        public LazyCString(byte[] stringPool, int index)
        {
            if (stringPool == null)
                throw new ArgumentNullException("str");

            if (index < 0 || index >= stringPool.Length)
                throw new ArgumentOutOfRangeException("index");

            m_string = null;
            m_pool = stringPool;
            m_index = index;
        }

        bool CheckValidity()
        {
            return (m_string != null) ^ (m_pool != null && m_pool.Rank == 1
                && m_index >= 0 && m_index < m_pool.Length);
        }

        void CheckValidityThrowException()
        {
            if (!CheckValidity())
                throw new InvalidOperationException();
        }

        public bool StringLoaded
        {
            get
            {
                CheckValidityThrowException();

                return m_string != null;
            }
        }

        public unsafe void LoadString()
        {
            CheckValidityThrowException();

            fixed (byte* pool = m_pool)
                m_string = LoadString((sbyte*)pool, m_pool.Length, m_index);

            m_pool = null;
            m_index = -1;
        }

        public override string ToString()
        {
            if (m_string == null)
                LoadString();

            return m_string;
        }
    }
}
