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
    public class returninfoBLL
    {
        returninfoDAL dal = new returninfoDAL();
       public returninfoBLL() { }

        public DataTable select()
        {
            return dal.select();
        }

        public void insert(@return r)
        {
            dal.insert(r);
        }
    }
}
