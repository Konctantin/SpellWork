using System.Data;
using MySql.Data.MySqlClient;
using SpellWork.Properties;

namespace SpellWork.DataBase
{
    public class Sql
    {
        static MySqlConnection connection;
        static MySqlDataAdapter dataAdapter;

        public static DataTable DataTable { get; set; }

        static Sql()
        {
            DataTable = new DataTable();

            try
            {
                var connectionString = string.Format(
                    "Server={0};Port={1};Uid={2};Pwd={3};Database={4};character set=utf8;Connection Timeout=10",
                    Settings.Default.Host,
                    Settings.Default.Port,
                    Settings.Default.UserName,
                    Settings.Default.Password,
                    Settings.Default.DataBase
                    );

                connection  = new MySqlConnection(connectionString);
                dataAdapter = new MySqlDataAdapter(SelectQuery, connection);
                ConfigureDataAdapter();

                dataAdapter.Fill(DataTable);
            }
            catch 
            {
            }
        }

        static void ConfigureDataAdapter()
        {
            var UpdateCommand = new MySqlCommand(UpdateQuery, connection);
            UpdateCommand.Parameters.Add("@entry", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SchoolMask", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyName", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskA0", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskA1", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskA2", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskB0", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskB1", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskB2", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskC0", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskC1", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@SpellFamilyMaskC2", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@procFlags", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@procEx", MySqlDbType.UInt32);
            UpdateCommand.Parameters.Add("@ppmRate", MySqlDbType.Float);
            UpdateCommand.Parameters.Add("@CustomChance", MySqlDbType.Float);
            UpdateCommand.Parameters.Add("@Cooldown", MySqlDbType.UInt32);

            var InsertCommand = new MySqlCommand(UpdateQuery, connection);
            InsertCommand.Parameters.Add("@entry", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SchoolMask", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyName", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskA0", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskA1", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskA2", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskB0", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskB1", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskB2", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskC0", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskC1", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@SpellFamilyMaskC2", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@procFlags", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@procEx", MySqlDbType.UInt32);
            InsertCommand.Parameters.Add("@ppmRate", MySqlDbType.Float);
            InsertCommand.Parameters.Add("@CustomChance", MySqlDbType.Float);
            InsertCommand.Parameters.Add("@Cooldown", MySqlDbType.UInt32);

            var DeleteCommand = new MySqlCommand(UpdateQuery, connection);
            DeleteCommand.Parameters.Add("@entry", MySqlDbType.UInt32);

            dataAdapter.UpdateCommand = UpdateCommand;
            dataAdapter.InsertCommand = InsertCommand;
            dataAdapter.DeleteCommand = DeleteCommand;
        }

        public static void Dispose()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Dispose();
            }
        }

        #region UpdateQuery
        const string UpdateQuery = @"
            UPDATE spell_proc_event SET 
            SchoolMask        = @SchoolMask,       
            SpellFamilyName   = @SpellFamilyName,  
            SpellFamilyMaskA0 = @SpellFamilyMaskA0,
            SpellFamilyMaskA1 = @SpellFamilyMaskA1,
            SpellFamilyMaskA2 = @SpellFamilyMaskA2,
            SpellFamilyMaskB0 = @SpellFamilyMaskB0,
            SpellFamilyMaskB1 = @SpellFamilyMaskB1,
            SpellFamilyMaskB2 = @SpellFamilyMaskB2,
            SpellFamilyMaskC0 = @SpellFamilyMaskC0,
            SpellFamilyMaskC1 = @SpellFamilyMaskC1,
            SpellFamilyMaskC2 = @SpellFamilyMaskC2,
            procFlags         = @procFlags,    
            procEx            = @procEx,       
            ppmRate           = @ppmRate,      
            CustomChance      = @CustomChance,  
            Cooldown          = @Cooldown
            WHERE entry       = @entry;";
        #endregion

        const string InsertQuery = @"
            INSERT INTO spell_proc_event (entry, SchoolMask, SpellFamilyName, SpellFamilyMaskA0, SpellFamilyMaskA1, SpellFamilyMaskA2, SpellFamilyMaskB0, SpellFamilyMaskB1, SpellFamilyMaskB2, SpellFamilyMaskC0, SpellFamilyMaskC1, SpellFamilyMaskC2, procFlags, procEx, ppmRate, CustomChance, Cooldown) 
            VALUES (@entry, @SchoolMask, @SpellFamilyName, @SpellFamilyMaskA0, @SpellFamilyMaskA1, @SpellFamilyMaskA2, @SpellFamilyMaskB0, @SpellFamilyMaskB1, @SpellFamilyMaskB2, @SpellFamilyMaskC0, @SpellFamilyMaskC1, @SpellFamilyMaskC2, @procFlags, @procEx, @ppmRate, @CustomChance, @Cooldown);";

        const string SelectQuery = @"SELECT * FROM spell_proc_event;";
        const string DeleteQuery = @"DELETE FROM spell_proc_event WHERE entry = @entry;";
    }
}
