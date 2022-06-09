using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using model;
namespace BLL
{
    public class admininfoBLL
    {
        public readonly admininfoDAL dal = new admininfoDAL();
        public admininfoBLL() { }
        public bool Exists(string id,string pwd)
        {
            return dal.Exists(id,pwd);
        }
    }
}
