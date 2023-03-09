using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FunProCW1_00012882.DAL
{
    public class DbManager
    {
        public SQLiteConnection Connection { 
            get 
            {
                return new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            } 
        }
    }
}
