using System;
using Mono.Data.Sqlite;

namespace OpenCookly.DAL
{
    public class MonoSQLiteDriver : NHibernate.Driver.ReflectionBasedDriver
    {  
        public MonoSQLiteDriver() 
            : base(
            typeof(SqliteDataReader).Assembly.FullName, //"Mono.Data.Sqlite",
            typeof(SqliteDataReader).Assembly.FullName, //"Mono.Data.Sqlite",  
            typeof(SqliteConnection).FullName, //"Mono.Data.Sqlite.SqliteConnection",  
            typeof(SqliteCommand).FullName //"Mono.Data.Sqlite.SqliteCommand"
            )
        {  
        }

        public override bool UseNamedPrefixInParameter
        {  
            get
            {  
                return true;  
            }  
        }

        public override bool UseNamedPrefixInSql
        {  
            get
            {  
                return true;  
            }  
        }

        public override string NamedPrefix
        {  
            get
            {  
                return "@";  
            }  
        }

        public override bool SupportsMultipleOpenReaders
        {  
            get
            {  
                return false;  
            }  
        }  
    }  
}

