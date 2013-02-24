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
using SpellWork.Dbc;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для SpellViewer.xaml
    /// </summary>
    public partial class SpellViewer : UserControl
    {
        public SpellViewer()
        {
            InitializeComponent();
        }

        private void ApplyFilter(object sender, ExecutedRoutedEventArgs e)
        {
            var spellList = CollectionViewSource.GetDefaultView(lvSpellList.ItemsSource);

            int spellId = 0;
            int.TryParse(tbSpellName.Text, out spellId);

            if (spellList != null)
            {
                spellList.Filter = new Predicate<object>((spellRaw) =>
                {
                    if (!(spellRaw is SpellEntry))
                        return false;

                    var spell = spellRaw as SpellEntry;

                    // SpellName of Id
                    if (!string.IsNullOrWhiteSpace(tbSpellName.Text))
                    {
                        if (spellId > 0 && spell.ID == spellId)
                            return true;

                        if (spell.SpellName.IndexOf(tbSpellName.Text, StringComparison.CurrentCultureIgnoreCase) > -1)
                            return true;
                    }

                    // SpellAura

                    // SpellEffect

                    // SpellFamilyName

                    // Target A

                    // Target B

                    return false;
                });
            }
        }
    }
}
