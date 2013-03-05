using System;
using System.Windows;
using System.Windows.Documents;

namespace SpellWork.FlowDocumentExtension
{
    public class BindableRun : Run
    {
        public static readonly DependencyProperty BoundTextProperty =
            DependencyProperty.Register("BoundText", typeof(string), typeof(BindableRun),
                new PropertyMetadata((d, e) => ((Run)d).Text = (string)e.NewValue));

        public BindableRun()
        {
            Helpers.FixupDataContext(this);
        }

        public String BoundText
        {
            get { return (string)GetValue(BoundTextProperty); }
            set { SetValue(BoundTextProperty, value); }
        }
    }
}
