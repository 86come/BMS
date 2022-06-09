using System;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class admininfoDAL
    {
        public admininfoDAL() { }
        public bool Exists(String id,String pwd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from admin where aId=@aid and apwd=@apwd";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@aid", SqlDbType.NVarChar, 50).Value = id;
            cmd.Parameters.Add("@apwd", SqlDbType.VarChar, 50).Value = pwd;
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

