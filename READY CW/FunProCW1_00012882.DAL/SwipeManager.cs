using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunProCW1_00012882.DAL
{
    public class SwipeManager : DbManager
    {

        //the code was copied form Vasiliy Kuznetsov the best teacher at WIUT, here I changed the Applicant/Course to Employee/Swipe and changed the data
        // used it from the table, for example em_12882, where 12882 is my ID. The main purpose of the code was not changed, just names.
        public void Create(Swipe c)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO sp_swipe_12882
           (sp_emp_id_12882
           ,sp_date_12882
           ,sp_in_12882
           ,sp_out_12882
           )
     VALUES
           ({c.EmployeeID}
           ,{c.SwipeDate.Ticks}
           ,{c.SwipeIn.Ticks}
           ,{c.SwipeOut.Ticks})";
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


        public void Update(Swipe c)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE sp_swipe_12882
           (sp_id_12882
           ,sp_emp_id_12882
           ,sp_date_12882
           ,sp_in_12882
           ,sp_out_12882
           )
     VALUES
           ('{c.Id}'
           ,{c.EmployeeID}
           ,{c.SwipeDate.Ticks}
           ,{c.SwipeIn}
           ,{c.SwipeOut})";
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

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM sp_swipe_12882 WHERE Id={id}";
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

        public List<Swipe> GetAll()
        {
            var connection = Connection;
            var result = new List<Swipe>();
            try
            {
                var sql = @"
SELECT sp_id_12882
            ,sp_emp_id_12882
            ,sp_date_12882
            ,sp_in_12882
            ,sp_out_12882
FROM sp_swipe_12882";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Swipe
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        EmployeeID = Convert.ToInt32(reader.GetValue(1)),
                        SwipeDate = new DateTime(Convert.ToInt64(reader.GetValue(2))),
                        SwipeIn = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        SwipeOut = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
                    result.Add(c);
                }
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

            return result;
        }


        public Swipe GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT Id, Name FROM sp_swipe_12882 WHERE ID={id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var c = new Swipe
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        EmployeeID = Convert.ToInt32(reader.GetValue(1)),
                        SwipeDate = new DateTime(Convert.ToInt64(reader.GetValue(2))),
                        SwipeIn = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        SwipeOut = new DateTime(Convert.ToInt64(reader.GetValue(4)))
                    };
                    return c;
                }
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

            return null;
        }
    }
}
