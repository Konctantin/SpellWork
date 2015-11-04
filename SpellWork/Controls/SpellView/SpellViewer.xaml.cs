using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using SpellWork.DBClientFilesStructure;
using SpellWork.Enums;

namespace SpellWork.Controls.SpellView
{
    /// <summary>
    /// Логика взаимодействия для SpellViewer.xaml
    /// </summary>
    public partial class SpellViewer : UserControl
    {
        #region SelectedSpell

        public static readonly DependencyProperty SelectedSpellProperty = DependencyProperty.Register("SelectedSpell", typeof(SpellEntry), typeof(SpellViewer),
            new PropertyMetadata(default(SpellEntry), new PropertyChangedCallback(SelectedSpellPropertySelectedChanged)));

        static void SelectedSpellPropertySelectedChanged(DependencyObject dependecyObject, DependencyPropertyChangedEventArgs e)
        {
            if (!(e.NewValue is SpellEntry))
                return;
        }

        public SpellEntry SelectedSpell
        {
            get { return (SpellEntry)GetValue(SelectedSpellProperty); }
            set { SetValue(SelectedSpellProperty, value); }
        }

        #endregion

        public SpellViewer()
        {
            InitializeComponent();
        }
    }
}
