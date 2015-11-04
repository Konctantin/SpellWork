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

namespace SpellWork.Controls
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public delegate bool FilterHandler(object value);

    /// <summary>
    ///
    /// </summary>
    public partial class SpellSimimpleFilter : UserControl
    {
        /// <summary>
        ///
        /// </summary>
        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register(nameof(Filter), typeof(FilterHandler), typeof(SpellSimimpleFilter),
            new PropertyMetadata());

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(object), typeof(SpellSimimpleFilter));

        /// <summary>
        ///
        /// </summary>
        public FilterHandler Filter
        {
            get { return (FilterHandler)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }

        public SpellSimimpleFilter()
        {
            InitializeComponent();
        }
    }
}
