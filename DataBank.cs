using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danil_temp
{
    public class DataBank
    {
        public static DataSet ds;
        public static  DataTable dt; 
        public static NpgsqlConnection connString = new NpgsqlConnection("Host=localhost;Port=5432;Database=Danil_temp;Username=postgres;Password=123456");

        public static void SQLtoDB(string sql)
        {
            DataBank.connString.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connString);
            NpgsqlDataAdapter dataAd = new NpgsqlDataAdapter(sql, connString);
            DataBank.ds = new DataSet();
            DataBank.ds.Reset();
            dataAd.Fill(ds);
            DataBank.dt = ds.Tables[0];
            connString.Close();
        }

        public static void SQLtoDBwithChanges(string sql)
        {
            connString.Open();
            NpgsqlCommand comm = new NpgsqlCommand(sql, connString);
            comm.ExecuteNonQuery();
            connString.Close();
            SQLtoDB("SELECT * FROM contact ORDER BY id");
        }
    }
}
