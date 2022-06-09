using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using model;

namespace BLL
{
    public class bookinfoBLL
    {
        bookinfoDAL dal = new bookinfoDAL();
        public bookinfoBLL() { }
        public DataTable select()
        {
            return dal.select();
        }

        public void delete(book b)
        {
            dal.delete(b);
        }

        public void insert(book b)
        {
            dal.insert(b);
        }

        public void update(book b, book b1)
        {
            dal.update(b, b1);
        }

        public DataTable select1(book b)
        {
           return  dal.select1(b);
        }
    }
}
