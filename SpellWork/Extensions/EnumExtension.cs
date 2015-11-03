using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace SpellWork
{
    public static class EnumExtension
    {
        public static T SelectedValue<T>(this ComboBox comboBox)
        {
            if (comboBox.SelectedValue != null)
                return (T)comboBox.SelectedValue;
            return default(T);
        }
    }
}
