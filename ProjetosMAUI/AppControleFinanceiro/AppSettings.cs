using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro
{
    public class AppSettings
    {
        private static string DatabaseName = "database.db";
        private static string DatabasePath = Path.Combine(FileSystem.Current.AppDataDirectory, DatabaseName);
        public static string DatabaseConnection = $"Filename={AppSettings.DatabasePath};Connection=Shared;";
    }
}
