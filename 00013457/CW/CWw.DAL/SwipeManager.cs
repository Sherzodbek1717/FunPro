using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWw.DAL
{
    internal class SwipeManager
    {
        public void Create(sp_swipe c)
        {
            var connection = new SQLiteConnection();
            try
            {
                var sql = $"INSERT INTO sp_swipe (Name) VALUES ('{c.sp_emp_13457}')";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }


        public void Update(sp_swipe c)
        {
            var connection = new SQLiteConnection();
            try
            {
                var sql = $"INSERT INTO sp_swipe (Name) VALUES ('{c.sp_emp_13457}')";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }


    }
}
