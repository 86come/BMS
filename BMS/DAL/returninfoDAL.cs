using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using System.Data.SqlClient;
using System.Data.Sql;
namespace DAL
{
    public class returninfoDAL
    {
        public returninfoDAL() { }

        public DataTable select()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from \"return\"";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public void insert(@return r)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "insert into \"return\" values(@id,@bno,@rtime,@rtel)";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = r.id;
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = r.bno;
            cmd.Parameters.Add("@rtime", SqlDbType.NVarChar, 50).Value = r.rtime;
            cmd.Parameters.Add("@rtel", SqlDbType.NVarChar, 50).Value = r.rtel;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
