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
        public event EventHandler ChechedChanged;

        #region HeaderProperty

        public static DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(FlagsPresenter),
                new PropertyMetadata(string.Empty, HeaderPropertyChanged));

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public GroupBox MainGroupBox
        {
            get { return groupBox; }
        }

        private static void HeaderPropertyChanged(DependencyObject dependecyObject, DependencyPropertyChangedEventArgs e)
        {
            var flagsPresenter = dependecyObject as FlagsPresenter;
            if (flagsPresenter != null && e.NewValue != e.OldValue)
            {
                flagsPresenter.MainGroupBox.Header = e.NewValue;
            }
        }

        #endregion

        #region DataSource

        public static DependencyProperty DataSourceProperty = 
            DependencyProperty.Register("DataSource", typeof(Type), typeof(FlagsPresenter),
                new PropertyMetadata(default(Type), DataSourcePropertyChanged));

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

                        checkBox.Checked   += (o, r) =>
                        {
                            var val = (uint)flagsPresenter.GetValue(ValueProperty);
                            var flagValue = (uint)(o as CheckBox).Tag;
                            val |= flagValue;

                            if (flagValue == 0u)
                                val = 0u;

                            flagsPresenter.SetValue(ValueProperty, val);
                            if (flagsPresenter.ChechedChanged != null)
                                flagsPresenter.ChechedChanged(o, new EventArgs());
                        };

                        checkBox.Unchecked += (o, r) =>
                        {
                            var val = (uint)flagsPresenter.GetValue(ValueProperty);
                            val &= ~(uint)(o as CheckBox).Tag;

                            flagsPresenter.SetValue(ValueProperty, val);
                            if (flagsPresenter.ChechedChanged != null)
                                flagsPresenter.ChechedChanged(o, new EventArgs());
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
                foreach (CheckBox checkBox in flagsPresenter.panel.Children)
                {
                    var isChecked = ((uint)e.NewValue & (uint)checkBox.Tag) != 0;

                    if ((uint)checkBox.Tag == 0 && (uint)e.NewValue == 0)
                        isChecked = true;

                    if (checkBox.IsChecked != isChecked)
                        checkBox.SetValue(CheckBox.IsCheckedProperty, isChecked);
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
