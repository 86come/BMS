using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using model;

namespace DAL
{
    public class bookinfoDAL
    {
        public bookinfoDAL() { }
        public DataTable select()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from book";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public DataTable select1(book b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "select * from book where bno=@bno";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = b.bno;
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public void update(book b, book b1)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "update book set bno=@bno,bname=@bname,bauthor=@bauthor,bcbs=@bcbs,ISBN=@ISBN where bno=@bno1 and bname=@bname1 and bauthor=@bauthor1 and bcbs=@bcbs1 and ISBN=@ISBN1";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = b1.bno;
            cmd.Parameters.Add("@bname", SqlDbType.NVarChar, 50).Value = b1.bname;
            cmd.Parameters.Add("@bauthor", SqlDbType.NVarChar, 50).Value = b1.bauthor;
            cmd.Parameters.Add("@bcbs", SqlDbType.NVarChar, 50).Value = b1.bcbs;
            cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 50).Value = b1.ISBN;
            cmd.Parameters.Add("@bno1", SqlDbType.NVarChar, 50).Value = b.bno;
            cmd.Parameters.Add("@bname1", SqlDbType.NVarChar, 50).Value = b.bname;
            cmd.Parameters.Add("@bauthor1", SqlDbType.NVarChar, 50).Value = b.bauthor;
            cmd.Parameters.Add("@bcbs1", SqlDbType.NVarChar, 50).Value = b.bcbs;
            cmd.Parameters.Add("@ISBN1", SqlDbType.NVarChar, 50).Value = b.ISBN;
            cmd.ExecuteNonQuery();
        }

        public void insert(book b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "insert into book values (@bno,@bname,@bauthor,@bcbs,@ISBN)";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = b.bno;
            cmd.Parameters.Add("@bname", SqlDbType.NVarChar, 50).Value = b.bname;
            cmd.Parameters.Add("@bauthor", SqlDbType.NVarChar, 50).Value = b.bauthor;
            cmd.Parameters.Add("@bcbs", SqlDbType.NVarChar, 50).Value = b.bcbs;
            cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 50).Value = b.ISBN;
            cmd.ExecuteNonQuery();
        }

        public void delete(book b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\卓卓\Desktop\C#\BMS\BMS\BMSDB.mdf;Integrated Security=True");
            con.Open();
            String str1 = "delete from book where bno=@bno and bname=@bname and bauthor=@bauthor and bcbs=@bcbs and ISBN=@ISBN";
            SqlCommand cmd = new SqlCommand(str1, con);
            cmd.Parameters.Add("@bno", SqlDbType.NVarChar, 50).Value = b.bno;
            cmd.Parameters.Add("@bname", SqlDbType.NVarChar, 50).Value = b.bname;
            cmd.Parameters.Add("@bauthor", SqlDbType.NVarChar, 50).Value = b.bauthor;
            cmd.Parameters.Add("@bcbs", SqlDbType.NVarChar, 50).Value = b.bcbs;
            cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 50).Value = b.ISBN;
            cmd.ExecuteNonQuery();
        }
    }
}
