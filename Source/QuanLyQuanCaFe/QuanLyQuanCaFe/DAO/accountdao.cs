using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    class accountdao
    {
        private static accountdao instance;

        public static accountdao Instance
        {
            get { if (instance == null) instance = new accountdao(); return instance; }
            private set { instance = value; }
        }
        private accountdao() { }

        public bool login (string username,string passwordd)
        {
            string query = "select * from Account where username=N'"+username+"' and passwordd='"+passwordd+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count>0;
        }
    }
}
