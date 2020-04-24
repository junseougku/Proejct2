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
            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=(local);Initial Catalog=Farming;User ID=sa;Password=wooribnc";
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;

            cmd.CommandText = "INSERT INTO LaborerManagementTable(";
            cmd.CommandText += "SaveDate, ManHireCount, WomanHireCount, LaborerCost, SnakCost) VALUES(";
            foreach (string i in _insertString)
            {
                cmd.CommandText += "'";
                cmd.CommandText += i;
                cmd.CommandText += "'";
                cmd.CommandText += ",";
            }
            cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1);
            cmd.CommandText += ")";
            cmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        static public void DBSelect()
        {
            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=(local);Initial Catalog=Farming;User ID=sa;Password=wooribnc";
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;

            cmd.CommandText = "SELECT COUNT(*) FROM LaborerManagementTable";
            SqlDataReader reader = cmd.ExecuteReader();

        }
    }
}
