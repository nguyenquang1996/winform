using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    public class billinfodao
    {
        private static billinfodao instance;

        public static billinfodao Instance
        {
            get { if (instance == null) instance = new billinfodao(); return billinfodao.instance; }
            private set { billinfodao.instance = value; }
        }
        private billinfodao() { }
        public List<billinfo> getlistbillinfo(int id)
        {
            List<billinfo> listbillinfo = new List<billinfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM dbo.BillInfo WHERE idBill = '" + id + "'");
            foreach(DataRow item in data.Rows)
            {
                billinfo info = new billinfo(item);
                listbillinfo.Add(info);
            }
            return listbillinfo;
        }
    }
}
