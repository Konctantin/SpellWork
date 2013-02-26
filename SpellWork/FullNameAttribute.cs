using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class FullNameAttribute : Attribute
    {
        public string FullName { get; private set; }

        public FullNameAttribute(string fullName)
        {
            this.FullName = fullName;
        }
    }
}
