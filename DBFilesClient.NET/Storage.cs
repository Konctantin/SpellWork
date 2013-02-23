using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace DBFilesClient.NET
{
    public abstract class Storage<T> : IDictionary<uint, T>, ICollection<T> where T : class, new()
    {
        #region Enumerator
        public struct Enumerator : IEnumerator<T>, IEnumerator<KeyValuePair<uint, T>>, IEnumerator
        {
            Storage<T> m_storage;
            int m_version;
            uint m_id;

            internal Enumerator(Storage<T> storage)
            {
                if (storage == null)
                    throw new ArgumentNullException("storage");

                m_storage = storage;
                m_version = storage.m_version;
                unchecked
                {
                    m_id = storage.m_minId - 1;
                }
            }

            void CheckStorage()
            {
                if (m_storage == null)
                    throw new ObjectDisposedException("Enumerator");

                if (m_storage.m_version != m_version)
                    throw new InvalidOperationException("The storage has been modified.");
            }

            public void Reset()
            {
                CheckStorage();

                unchecked
                {
                    m_id = m_storage.m_minId - 1;
                }
            }

            public bool MoveNext()
            {
                CheckStorage();

                if (m_storage.m_records == 0)
                    return false;

                var min = m_storage.m_minId;
                var max = m_storage.m_maxId;

                do
                {
                    if (!(min <= m_id + 1 && m_id + 1 <= max))
                        return false;

                    ++m_id;
                }
                while (m_storage.m_entries[m_id - min] == null);

                return true;
            }

            public T Current
            {
                get
                {
                    CheckStorage();

                    if (m_storage.m_records != 0)
                    {
                        var min = m_storage.m_minId;
                        var id = m_id;

                        if (min <= id && id <= m_storage.m_maxId)
                        {
                            var entry = m_storage.m_entries[id - min];
                            if (entry != null)
                                return entry;
                        }
                    }

                    throw new InvalidOperationException("The enumerator does not point to a valid storage record.");
                }
            }

            object IEnumerator.Current { get { return this.Current; } }
            KeyValuePair<uint, T> IEnumerator<KeyValuePair<uint, T>>.Current
            {
                get
                {
                    var entry = this.Current;

                    return new KeyValuePair<uint, T>(m_storage.m_idGetter(entry), entry);
                }
            }

            public void Dispose()
            {
                m_storage = null;
            }
        }
        #endregion

        #region KeyCollection
        public struct KeyCollection : ICollection<uint>, IDisposable
        {
            #region Enumerator
            public struct Enumerator : IEnumerator<uint>
            {
                Storage<T> m_storage;
                int m_version;
                uint m_id;

                internal Enumerator(Storage<T> storage)
                {
                    if (storage == null)
                        throw new ArgumentNullException("storage");

                    m_storage = storage;
                    m_version = storage.m_version;
                    unchecked
                    {
                        m_id = storage.m_minId - 1;
                    }
                }

                void CheckStorage()
                {
                    if (m_storage == null)
                        throw new ObjectDisposedException("Enumerator");

                    if (m_storage.m_version != m_version)
                        throw new InvalidOperationException("The storage has been modified.");
                }

                public void Reset()
                {
                    CheckStorage();

                    unchecked
                    {
                        m_id = m_storage.m_minId - 1;
                    }
                }

                public bool MoveNext()
                {
                    CheckStorage();

                    if (m_storage.m_records == 0)
                        return false;

                    var min = m_storage.m_minId;
                    var max = m_storage.m_maxId;

                    do
                    {
                        if (!(min <= m_id + 1 && m_id + 1 <= max))
                            return false;

                        ++m_id;
                    }
                    while (m_storage.m_entries[m_id - min] == null);

                    return true;
                }

                public uint Current
                {
                    get
                    {
                        CheckStorage();

                        var min = m_storage.m_minId;
                        var id = m_id;

                        if (m_storage.m_records != 0 && min <= id && id <= m_storage.m_maxId)
                            return id;

                        throw new InvalidOperationException("The enumerator does not point to a valid storage record.");
                    }
                }

                object IEnumerator.Current { get { return this.Current; } }

                public void Dispose()
                {
                    m_storage = null;
                }
            }
            #endregion

            Storage<T> m_storage;

            public KeyCollection(Storage<T> storage)
            {
                if (storage == null)
                    throw new ArgumentNullException("storage");

                m_storage = storage;
            }

            void CheckStorage()
            {
                if (m_storage == null)
                    throw new ObjectDisposedException("Enumerator");
            }

            public bool IsReadOnly { get { return true; } }

            public int Count
            {
                get
                {
                    CheckStorage();

                    return m_storage.m_records;
                }
            }

            void ICollection<uint>.Add(uint item)
            {
                throw new NotSupportedException();
            }

            bool ICollection<uint>.Remove(uint item)
            {
                throw new NotSupportedException();
            }

            void ICollection<uint>.Clear()
            {
                throw new NotSupportedException();
            }

            public bool Contains(uint id)
            {
                CheckStorage();

                return m_storage.ContainsKey(id);
            }

            public void CopyTo(uint[] array, int index)
            {
                CheckStorage();

                if (array == null)
                    throw new ArgumentNullException("array");

                if (index < 0 || index + m_storage.m_records >= array.Length)
                    throw new ArgumentOutOfRangeException("index");

                var idGetter = m_storage.m_idGetter;
                foreach (var entry in m_storage)
                    array[index++] = idGetter(entry);
            }

            public Enumerator GetEnumerator()
            {
                return new Enumerator(m_storage);
            }

            IEnumerator<uint> IEnumerable<uint>.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            public void Dispose()
            {
                m_storage = null;
            }
        }
        #endregion

        #region ValueCollection
        public struct ValueCollection : ICollection<T>, IDisposable
        {
            Storage<T> m_storage;

            public ValueCollection(Storage<T> storage)
            {
                if (storage == null)
                    throw new ArgumentNullException("storage");

                m_storage = storage;
            }

            void CheckStorage()
            {
                if (m_storage == null)
                    throw new ObjectDisposedException("Enumerator");
            }

            public bool IsReadOnly { get { return true; } }

            public int Count
            {
                get
                {
                    CheckStorage();

                    return m_storage.m_records;
                }
            }

            void ICollection<T>.Add(T item)
            {
                throw new NotSupportedException();
            }

            bool ICollection<T>.Remove(T item)
            {
                throw new NotSupportedException();
            }

            void ICollection<T>.Clear()
            {
                throw new NotSupportedException();
            }

            public bool Contains(T entry)
            {
                CheckStorage();

                return m_storage.Contains(entry);
            }

            public void CopyTo(T[] array, int index)
            {
                CheckStorage();

                m_storage.CopyTo(array, index);
            }

            public Enumerator GetEnumerator()
            {
                return new Enumerator(m_storage);
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            public void Dispose()
            {
                m_storage = null;
            }
        }
        #endregion

        #region Static Fields
        internal static readonly Type s_intType = typeof(int);
        internal static readonly Type s_uintType = typeof(uint);
        internal static readonly Type s_floatType = typeof(float);
        internal static readonly Type s_longType = typeof(long);
        internal static readonly Type s_ulongType = typeof(ulong);
        internal static readonly Type s_stringType = typeof(string);
        internal static readonly Type s_lazyCStringType = typeof(LazyCString);
        internal static readonly ConstructorInfo s_lazyCStringCtor =
            typeof(LazyCString).GetConstructor(new[] { typeof(byte[]), typeof(int) });
        #endregion

        #region Fields
        internal T[] m_entries;
        internal uint m_minId;
        internal uint m_maxId;
        internal int m_records;
        internal delegate uint IdGetter(T entry);
        internal IdGetter m_idGetter;
        internal Type m_entryType;
        internal string m_entryTypeName;

        internal struct EntryFieldInfo
        {
            public FieldInfo FieldInfo;
            public MethodInfo Getter;
            public MethodInfo Setter;

            // Only used by arrays.
            public Type ElementType;
            public StoredTypeId DBCTypeId;
            public int ArraySize;
        }

        internal EntryFieldInfo[] m_fields;
        internal int m_entrySize;

        internal int m_version;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the number of records currently contained in the storage.
        /// </summary>
        public int Count { get { return m_records; } }

        /// <summary>
        /// Gets the minimum record id in the storage.
        /// Existance of a record with this id is not guaranteed.
        /// </summary>
        public uint MinId
        {
            get
            {
                if (m_records == 0)
                    throw new InvalidOperationException("There are no records in the storage.");

                return m_minId;
            }
        }

        /// <summary>
        /// Gets the maximum record id in the storage.
        /// Existance of a record with this id is not guaranteed.
        /// </summary>
        public uint MaxId
        {
            get
            {
                if (m_records == 0)
                    throw new InvalidOperationException("There are no records in the storage.");

                return m_maxId;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of <see cref="DBFilesClient.NET.Storage&lt;T&gt;"/> class.
        /// </summary>
        public Storage()
        {
            m_entryType = typeof(T);
            m_entryTypeName = m_entryType.Name;
        }
        #endregion

        #region Generators
        internal void GenerateIdGetter()
        {
            if (m_idGetter != null)
                return;

            var method = new DynamicMethod(
                "IdGetter_" + m_entryTypeName,
                typeof(uint),
                new Type[] { typeof(T) },
                typeof(T),
                true
                );

            var ilgen = method.GetILGenerator(20);
            ilgen.Emit(OpCodes.Ldarg_0);

            if (m_fields[0].FieldInfo != null)
                ilgen.Emit(OpCodes.Ldfld, m_fields[0].FieldInfo);
            else if (m_fields[0].Getter != null)
                ilgen.Emit(OpCodes.Callvirt, m_fields[0].Getter);
            else
                throw new InvalidOperationException();

            if (m_fields[0].DBCTypeId != StoredTypeId.UInt32)
                ilgen.Emit(OpCodes.Conv_U4);
            ilgen.Emit(OpCodes.Ret);

            m_idGetter = (IdGetter)method.CreateDelegate(typeof(IdGetter));
        }
        #endregion

        #region Misc Methods
        internal KeyValuePair<FieldInfo, StoragePresenceAttribute>[] GetFields()
        {
            return m_entryType
                .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(field => !(field.Name.StartsWith("<") && field.Name.EndsWith(">k__BackingField")))
                .Select(field => new KeyValuePair<FieldInfo, StoragePresenceAttribute>(
                    field,
                    (StoragePresenceAttribute)field.GetCustomAttributes(StoragePresenceAttribute.Type, false).FirstOrDefault()))
                .Where(pair => pair.Value == null || pair.Value.Option != StoragePresenceOption.Exclude)
                .ToArray();
        }

        internal PropertyInfo[] GetProperties()
        {
            return m_entryType
                .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .ToArray();
        }

        internal bool CheckId(uint id)
        {
            return m_records != 0 && m_minId <= id && id <= m_maxId;
        }

        internal void ResizeToStore(uint id)
        {
            this.Resize(Math.Min(m_minId, id), Math.Max(id, m_maxId));
        }

        internal void Resize(uint min, uint max)
        {
            if (max < min)
                throw new ArgumentOutOfRangeException("max");

            if (m_entries == null || max == 0)
            {
                m_entries = max - min > 0 ? new T[max - min + 1] : null;
                m_minId = min;
                m_maxId = max;
                return;
            }

            int index;
            if (min < m_minId)
                index = (int)(m_minId - min);
            else
                index = 0;
            int count = (int)(m_maxId - m_minId + 1);

            var oldEntries = m_entries;
            m_maxId = Math.Max(m_maxId, max);
            m_minId = Math.Min(m_minId, min);
            m_entries = new T[m_maxId - m_minId + 1];

            Array.Copy(oldEntries, 0, m_entries, index, count);
        }
        #endregion

        #region Collection & Dictionary Method Implementations
        public bool ContainsKey(uint id)
        {
            if (!CheckId(id))
                return false;

            return m_entries[id - m_minId] != null;
        }

        public bool Contains(T entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            var id = m_idGetter(entry);

            return ContainsKey(id) && this[id] == entry;
        }

        public void Add(uint id, T entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            if (m_idGetter(entry) != id)
                throw new ArgumentException("id and id of entry must match.");

            if (ContainsKey(id))
                throw new ArgumentException("A record with the same id already present in the storage.");

            if (!CheckId(id))
                this.ResizeToStore(id);

            m_entries[id - m_minId] = entry;
            ++m_records;
            ++m_version;
        }

        public void Add(T entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            var id = m_idGetter(entry);

            if (ContainsKey(id))
                throw new ArgumentException("A record with the same id already present in the storage.");

            if (!CheckId(id))
                this.ResizeToStore(id);

            m_entries[id - m_minId] = entry;
            ++m_records;
            ++m_version;
        }

        public bool Remove(uint id)
        {
            if (ContainsKey(id))
            {
                m_entries[id - m_minId] = null;
                --m_records;
                ++m_version;
                return true;
            }

            return false;
        }

        public bool Remove(T entry)
        {
            if (entry == null)
                throw new ArgumentNullException("entry");

            var id = m_idGetter(entry);

            return Remove(id);
        }

        public bool TryGetValue(uint id, out T entry)
        {
            if (ContainsKey(id))
            {
                entry = m_entries[id - m_minId];
                return true;
            }

            entry = null;
            return false;
        }

        public T this[uint id]
        {
            get
            {
                if (!ContainsKey(id))
                    throw new KeyNotFoundException();

                return m_entries[id - m_minId];
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                if (m_idGetter(value) != id)
                    throw new ArgumentException("id and id of entry must match.");

                if (!CheckId(id))
                    this.ResizeToStore(id);

                if (m_entries[id - m_minId] != null)
                {
                    ++m_records;
                    ++m_version;
                }

                m_entries[id - m_minId] = value;
            }
        }

        /// <summary>
        /// Removes all records from the current storage.
        /// </summary>
        public void Clear()
        {
            m_minId = 0;
            m_maxId = 0;
            m_records = 0;
            m_entries = null;
        }

        public void CopyTo(T[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (index < 0 || index + m_records >= array.Length)
                throw new ArgumentOutOfRangeException("index");

            foreach (var entry in this)
                array[index++] = entry;
        }

        public void CopyTo(KeyValuePair<uint, T>[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (index < 0 || index + m_records >= array.Length)
                throw new ArgumentOutOfRangeException("index");

            foreach (var entry in this)
                array[index++] = new KeyValuePair<uint, T>(m_idGetter(entry), entry);
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        public KeyCollection Keys { get { return new KeyCollection(this); } }
        ICollection<uint> IDictionary<uint, T>.Keys { get { return this.Keys; } }
        public ValueCollection Values { get { return new ValueCollection(this); } }
        public ValueCollection Records { get { return new ValueCollection(this); } }
        ICollection<T> IDictionary<uint, T>.Values { get { return this.Values; } }

        public bool IsReadOnly { get { return false; } }

        void ICollection<KeyValuePair<uint, T>>.Add(KeyValuePair<uint, T> pair)
        {
            Add(pair.Key, pair.Value);
        }

        bool ICollection<KeyValuePair<uint, T>>.Remove(KeyValuePair<uint, T> pair)
        {
            var entry = pair.Value;

            if (entry == null)
                throw new ArgumentNullException("entry");

            var id = m_idGetter(entry);

            if (pair.Key != id)
                throw new ArgumentException("id and id of entry must match.");

            return Remove(id);
        }

        bool ICollection<KeyValuePair<uint, T>>.Contains(KeyValuePair<uint, T> pair)
        {
            var entry = pair.Value;

            if (entry == null)
                throw new ArgumentNullException("entry");

            var id = m_idGetter(entry);

            if (pair.Key != id)
                throw new ArgumentException("id and id of entry must match.");

            return ContainsKey(id) && this[id] == entry;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<KeyValuePair<uint, T>> IEnumerable<KeyValuePair<uint, T>>.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        #region Loading & Saving
        /// <summary>
        /// Loads the storage from a <see cref="System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">
        /// The <see cref="System.IO.Stream"/> from which the storage should be loaded.
        /// </param>
        public abstract void Load(Stream stream);
        #endregion
    }
}
