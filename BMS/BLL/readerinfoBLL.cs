using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using model;
namespace BLL
{
    public class readerinfoBLL
    {
        private readonly readerinfoDAL dal = new readerinfoDAL();
        //无参构造方法
        public readerinfoBLL() { }
        public bool Exists(string id, string pwd)
        {
            return dal.Exists(id, pwd);
        }
        //添加用户
        public void Add(reader r)
        {
            dal.Add(r);
        }
    }
}
