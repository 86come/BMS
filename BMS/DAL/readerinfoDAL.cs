using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using model;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DAL
{
    public class readerinfoDAL
    {
       public readerinfoDAL() { }

        //判断是否存在用户
        public bool Exists(String id,String pwd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from reader where Id=@id and rpwd=@rpwd";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add("@rpwd", SqlDbType.VarChar, 50).Value = pwd;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }


        //增加用户
        public void Add(reader r)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\c# bms\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (r.id != null)
            {
                strSql1.Append("id,");
                strSql2.Append("'" + r.id + "',");
            }
            if (r.rpwd != null)
            {
                strSql1.Append("rpwd,");
                strSql2.Append("'" + r.rpwd + "',");
            }
            if (r.rsex != null)
            {
                strSql1.Append("rsex,");
                strSql2.Append("'" + r.rsex + "',");
            }
            if (r.rtel != null)
            {
                strSql1.Append("rtel,");
                strSql2.Append("'" + r.rtel + "',");
            }
            strSql.Append("insert into reader(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            SqlCommand cmd = new SqlCommand(strSql.ToString(), con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
