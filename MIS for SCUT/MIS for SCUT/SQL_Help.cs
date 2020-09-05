using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MIS_for_SCUT
{
    class SQL_Help
    {
        static string admin_connet_string = "data source=siriusxiang.xyz;database=mis_scut;user id=mis_scut_admin;password=misadmin123456;pooling=false;charset=utf8";
        static string teacher_connet_string = "data source=siriusxiang.xyz;database=mis_scut;user id=mis_scut_teacher;password=misteacher123456;pooling=false;charset=utf8";
        static string student_connet_string = "data source=siriusxiang.xyz;database=mis_scut;user id=mis_scut_student;pooling=false;charset=utf8";

        public static MySqlConnection getConnection(Common.UserType user_type = Common.UserType.STUDENT)
        {
            switch (user_type)
            {
                case Common.UserType.STUDENT: return new MySqlConnection(student_connet_string);
                case Common.UserType.TEACHER: return new MySqlConnection(teacher_connet_string);
                case Common.UserType.ADMIN: return new MySqlConnection(admin_connet_string);
                default: return null;
            }
        }

        public static int ExecuteNonQuery(string sql, MySqlConnection connection, MySqlParameter[] param = null)
        {
            if (connection.State == ConnectionState.Closed) connection.Open(); 
            try
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(sql, connection) { Transaction = transaction })
                {
                    try
                    {
                        if (param != null)
                        {
                            foreach (MySqlParameter parm in param)
                                cmd.Parameters.Add(parm);
                        }
                        int rows = cmd.ExecuteNonQuery();
                        transaction.Commit();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (Exception e1)
                    {
                        Common.ShowError("None-Query Execution Error", e1.Message);
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception e2)
                        {
                            Common.ShowError("Transaction Rollback Error", e2.Message);
                            throw e2;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Common.ShowError("Connection Error", e.Message);
                throw e;
            }
            return -1;
        }

        public static DataTable ExecuteDataTable(string sql, MySqlConnection connection, MySqlParameter[] param = null)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            try
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(sql, connection) { Transaction = transaction, })
                {
                    try
                    {
                        if (param != null)
                        {
                            foreach (MySqlParameter parm in param)
                                cmd.Parameters.Add(parm);
                        }
                        DataTable ds = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                        transaction.Commit();
                        cmd.Parameters.Clear();
                        return ds;
                    }
                    catch (MySqlException e1)
                    {
                        Common.ShowError("None-Query Execution Error", e1.Message);
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception e2)
                        {
                            Common.ShowError("Transaction Rollback Error", e2.Message);
                            throw e2;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Common.ShowError("Connection Error", e.Message);
                throw e;
            }
            return null;
        }
    }
}
