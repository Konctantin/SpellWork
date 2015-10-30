using System;
using System.Windows;

namespace SpellWork.FlowDocumentExtension
{
    public class Attached
    {
        static readonly DependencyProperty IsItemsHostProperty =
            DependencyProperty.RegisterAttached("IsItemsHost", typeof(bool), typeof(Attached),
                new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.NotDataBindable, OnIsItemsHostChanged));

        static readonly DependencyProperty ItemsHostProperty =
            DependencyProperty.RegisterAttached("ItemsHost", typeof(FrameworkContentElement), typeof(Attached),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.NotDataBindable));

        public static bool GetIsItemsHost(DependencyObject target)
        {
            return (bool)target.GetValue(IsItemsHostProperty);
        }

        public static void SetIsItemsHost(DependencyObject target, bool value)
        {
            target.SetValue(IsItemsHostProperty, value);
        }

        static void SetItemsHost(FrameworkContentElement element)
        {
            var parent = element;
            while (parent.Parent != null)
                parent = (FrameworkContentElement)parent.Parent;
            parent.SetValue(ItemsHostProperty, element);
        }

        public static FrameworkContentElement GetItemsHost(DependencyObject dp)
        {
            return (FrameworkContentElement)dp.GetValue(ItemsHostProperty);
        }

        static void OnIsItemsHostChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                var element = (FrameworkContentElement)d;
                if (element.IsInitialized)
                    SetItemsHost(element);
                else
                    element.Initialized += ItemsHost_Initialized;
            }
        }

        static void ItemsHost_Initialized(object sender, EventArgs e)
        {
            var element = (FrameworkContentElement)sender;
            element.Initialized -= ItemsHost_Initialized;
            SetItemsHost(element);
        }
    }
}
