using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using DBFilesClient.NET;
using SpellWork.DBClientFilesStructure;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            SpellWork.Properties.Settings.Default.Save();
            SpellWork.DataBase.Sql.Dispose();
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                //var sw = new Stopwatch();
                //sw.Start();
                DBC.Load();
                //sw.Stop();
                //MessageBox.Show(sw.ElapsedMilliseconds.ToString());
            }
            catch (Exception ex)
            {
                var innerMessage = ex.InnerException == null
                    ? string.Empty :
                    ex.InnerException.Message;

                MessageBox.Show(
                    ex.Message + Environment.NewLine + innerMessage,
                    "SpellWork Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                Application.Current.Shutdown();
                return;
            }

            base.OnStartup(e);
        }
    }
}
