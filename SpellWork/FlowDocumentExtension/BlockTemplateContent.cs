using System.Windows;
using System.Windows.Documents;

namespace SpellWork.FlowDocumentExtension
{
    public class BlockTemplateContent : Section
    {
        private static readonly DependencyProperty TemplateProperty =
            DependencyProperty.Register("Template", typeof(DataTemplate), typeof(BlockTemplateContent),
                new PropertyMetadata((d, e) => ((BlockTemplateContent)d).OnTemplateChanged((DataTemplate)e.NewValue)));

        public DataTemplate Template
        {
            get { return (DataTemplate)GetValue(TemplateProperty); }
            set { SetValue(TemplateProperty, value); }
        }

        public BlockTemplateContent()
        {
            Helpers.FixupDataContext(this);
            Loaded += (sender, e) => GenerateContent(Template);
        }

        private void GenerateContent(DataTemplate template)
        {
            Blocks.Clear();
            if (template != null)
            {
                FrameworkContentElement element = Helpers.LoadDataTemplate(template);
                Blocks.Add((Block)element);
            }
        }

        private void OnTemplateChanged(DataTemplate dataTemplate)
        {
            GenerateContent(dataTemplate);
        }
    }
}
