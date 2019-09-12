using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
namespace Tgnet.Data.Entity
{
    public static class DbContextExtensions
    {
        private static void CombineParams(ref DbCommand command, params object[] parameters)
        {
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    if (!parameter.ParameterName.Contains("@"))
                        parameter.ParameterName = $"@{parameter.ParameterName}";
                    command.Parameters.Add(parameter);
                }
            }
        }

        private static DbCommand CreateCommand(DatabaseFacade facade, string sql, out DbConnection dbConn, params object[] parameters)
        {
            DbConnection conn = facade.GetDbConnection();
            dbConn = conn;
            conn.Open();
            DbCommand cmd = conn.CreateCommand();
            if (facade.IsSqlServer())
            {
                cmd.CommandText = sql;
                CombineParams(ref cmd, parameters);
            }
            return cmd;
        }

        public static DataTable SqlQuery(this DatabaseFacade facade, string sql, params object[] parameters)
        {
            DbCommand cmd = CreateCommand(facade, sql, out DbConnection conn, parameters);
            DbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;
        }
        public static IEnumerable<T> SqlQuery<T>(this DatabaseFacade facade, string sql, params object[] parameters)
        {
            DataTable dt = SqlQuery(facade, sql, parameters);
            return dt.ToEnumerable<T>();
        }

        public static IEnumerable<T> ToEnumerable<T>(this DataTable dt) 
        {
            var type = typeof(T);
            int i = 0;
            T[] ts = new T[dt.Rows.Count];
            if (type.IsValueType)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ts[i] =  (T)row[0];
                    i++;
                }
            }
            else
            {
                PropertyInfo[] propertyInfos = type.GetProperties();
                foreach (DataRow row in dt.Rows)
                {
                    T t = System.Activator.CreateInstance<T>();
                    //T t = Expression.Lambda<Func<T>>(Expression.New(typeof(T))).Compile().Invoke();
                    foreach (PropertyInfo p in propertyInfos)
                    {
                        if (dt.Columns.IndexOf(p.Name) != -1 && row[p.Name] != DBNull.Value)
                            p.SetValue(t, row[p.Name], null);
                    }
                    ts[i] = t;
                    i++;
                }
            }
            return ts;
            
        }
    }
}
