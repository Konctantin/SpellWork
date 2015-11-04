using System.Windows;
using System.Windows.Documents;

namespace SpellWork.FlowDocumentExtension
{
    public class BlockTemplateContent : Section
    {
        static readonly DependencyProperty TemplateProperty =
            DependencyProperty.Register("DataTemplate", typeof(DataTemplate), typeof(BlockTemplateContent),
                new PropertyMetadata((d, e) => ((BlockTemplateContent)d).OnTemplateChanged((DataTemplate)e.NewValue)));

        public DataTemplate DataTemplate
        {
            get { return (DataTemplate)GetValue(TemplateProperty); }
            set { SetValue(TemplateProperty, value); }
        }

        public BlockTemplateContent()
        {
            Helpers.FixupDataContext(this);
            Loaded += (sender, e) => GenerateContent(DataTemplate);
        }

        void GenerateContent(DataTemplate template)
        {
            Blocks.Clear();
            if (template != null && DataContext!=null)
            {
                FrameworkContentElement element = Helpers.LoadDataTemplate(template);
                Blocks.Add((Block)element);
            }
        }

        void OnTemplateChanged(DataTemplate dataTemplate)
        {
            GenerateContent(dataTemplate);
        }
    }
}
