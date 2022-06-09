using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class borrowinfoDAL
    {
        public borrowinfoDAL() { }

        public DataTable select()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from borrow";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public DataTable select2(borrow b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from borrow where id=@id";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = b.id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public void insert(borrow b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "insert into borrow values(@id,@bno,@btime,@btel)";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = b.id;
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = b.bno;
            cmd.Parameters.Add("@btime", SqlDbType.NVarChar, 50).Value = b.btime;
            cmd.Parameters.Add("@btel", SqlDbType.NVarChar, 50).Value = b.btel;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool select1(borrow b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from borrow where bno=@bno";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = b.bno;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
