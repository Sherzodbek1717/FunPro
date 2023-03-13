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
    public partial class EmployeeManager : DbManager
    {

        //the code was copied form Vasiliy Kuznetsov the best teacher at WIUT, here I changed the Applicant/Course to Employee/Swipe and changed the data
        // used it from the table, for example em_12882, where 12882 is my ID. The main purpose of the code was not changed, just names.
        public void Create(Employee a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO em_employee_12882
           (em_name_12882
           ,em_is_active_12882
           ,em_start_date_12882
           ,em_discharge_date_12882
           )
     VALUES
           ('{a.Name}'
           ,{Convert.ToInt32(a.IsActive)}
           ,{a.StartDate.Ticks}
           ,{a.DischargeDate.Ticks}
           )";

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


        public void Update(Employee a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
UPDATE em_employee_12882 
   SET em_name_12882 = '{a.Name}'
      ,em_start_date_12882 = {a.StartDate.Ticks}
      ,em_discharge_date_12882 = {a.DischargeDate.Ticks}
      ,em_is_active_12882 = {Convert.ToInt32(a.IsActive)}
WHERE Id = {a.Id}";
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
                {
                    connection.Close();
                }

            }
        }


        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM em_employee_12882 WHERE em_id_12882 = {id}";
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
                {
                    connection.Close();
                }
            }
        }

        public Employee GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT em_id_12882
      ,em_name_12882
      ,em_is_active_12882
      ,em_start_date_12882
      ,em_discharge_date_12882
FROM em_employee_12882
WHERE ID = {id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var a = GetFromReader(reader);
                    return a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
            return null;

        }

        public List<Employee> GetAll()
        {
            var allSwipes = new SwipeManager().GetAll().ToDictionary(t=>t.Id, t=>t);


            var connection = Connection;
            var result = new List<Employee>();
            try
            {
                var sql = @"
SELECT em_id_12882
      ,em_name_12882
      ,em_is_active_12882
      ,em_start_date_12882
      ,em_discharge_date_12882
FROM em_employee_12882";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }

        private Employee GetFromReader(SQLiteDataReader reader)
        {
            var a = new Employee
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                IsActive = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                StartDate = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                DischargeDate = new DateTime(Convert.ToInt64(reader.GetValue(4))),
            };

            return a;
        }
    }
}

