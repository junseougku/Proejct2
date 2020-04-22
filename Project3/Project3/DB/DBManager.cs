using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project3.DB
{
    static class DBManager
    {
        static SqlConnection sqlCon;

        static public void DBInsert(params string[] _insertString)
        {
            return;
            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=(local);Initial Catalog=Farming;User ID=sa;Password=wooribnc";
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "INSERT INTO LaborerManagementTable(";
           // cmd.CommandText += ""
            foreach (string i in _insertString)
            {
                cmd.CommandText += i;
                cmd.CommandText += ",";
            }
            cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1);

            cmd.CommandText += ") VALUES(";
            //cmd.CommandText += "'"

            cmd.ExecuteNonQuery();

            sqlCon.Close();
        }
    }
}
