using System.IO;
using System.Reflection;

namespace Sample.Data
{
    public static class DataHelper
    {
        public static string GetDatabaseFilePath()
        {
            var folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var databasePath = $@"Data Source={folder}\university_data.sqlite";
            return databasePath;
        }
    }
}