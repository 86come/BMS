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
namespace BLL
{
    public class borrowinfoBLL
    {
        borrowinfoDAL dal = new borrowinfoDAL();
        public borrowinfoBLL() { }

        public DataTable select()
        {
            return dal.select();
        }

        public bool insert(borrow b)
        {
            if (dal.select1(b))
            {
                return false;
            }
            else
            {
                dal.insert(b);
                return true;
            }
            
        }

        public DataTable select1(borrow b)
        {
            return dal.select2(b);
        }
    }
}
