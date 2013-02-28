using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для FlagsPresenter.xaml
    /// </summary>
    public partial class FlagsPresenter : UserControl
    {
        #region DataSource

        public static DependencyProperty DataSourceProperty = 
            DependencyProperty.Register("DataSource", typeof(Enum), typeof(FlagsPresenter),
                new PropertyMetadata(default(Enum), DataSourcePropertyChanged));

        public Type DataSource
        {
            get { return (Type)GetValue(DataSourceProperty); }
            set { SetValue(DataSourceProperty, value); }
        }

        private static void DataSourcePropertyChanged(DependencyObject dependecyObject, DependencyPropertyChangedEventArgs e)
        {
            var flagsPresenter = dependecyObject as FlagsPresenter;
            if (flagsPresenter != null && e.NewValue != e.OldValue)
            {
                flagsPresenter.panel.Children.Clear();
                if (e.NewValue != null && ((Type)e.NewValue).IsEnum)
                {
                    foreach (var enumValue in Enum.GetValues((Type)e.NewValue))
                    {
                        var checkBox = new CheckBox();

                        #warning todo: get name form resources
                        checkBox.Content = enumValue.ToString();

                        checkBox.Tag = enumValue;

                        checkBox.Checked   += (o, r) => {
                            var val = (uint)flagsPresenter.GetValue(ValueProperty);
                            flagsPresenter.SetValue(ValueProperty, (val |=  (uint)(o as CheckBox).Tag)); 
                        };

                        checkBox.Unchecked += (o, r) => {
                            var val = (uint)flagsPresenter.GetValue(ValueProperty);
                            flagsPresenter.SetValue(ValueProperty, (val &= ~(uint)(o as CheckBox).Tag)); 
                        };

                        flagsPresenter.panel.Children.Add(checkBox);
                    }
                } 
            }
        }

        #endregion

        #region Value

        public static DependencyProperty ValueProperty = 
            DependencyProperty.Register("Value", typeof(uint), typeof(FlagsPresenter),
                new PropertyMetadata(0u, ValuePropertyChanged));

        public uint Value
        {
            get { return (uint)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        private static void ValuePropertyChanged(DependencyObject dependecyObject, DependencyPropertyChangedEventArgs e)
        {
            var flagsPresenter = dependecyObject as FlagsPresenter;
            if (flagsPresenter != null && e.NewValue != e.OldValue)
            {
                int i = 0;
                foreach (CheckBox checkBox in flagsPresenter.panel.Children)
                {
                    bool isChecked = ((uint)checkBox.Tag & (1u << i)) != 0;
                    checkBox.SetValue(CheckBox.IsCheckedProperty, isChecked);
                    ++i;
                }
            }
        }

        #endregion

        public FlagsPresenter()
        {
            InitializeComponent();
        }
    }
}
