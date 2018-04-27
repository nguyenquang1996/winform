using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCaFe.DTO;


namespace QuanLyQuanCaFe.DAO
{
    public class billdao
    {
        private static billdao instance;
        public static billdao Instance
        {
            get { if (instance == null) instance = new billdao(); return billdao.instance; }
            private set { billdao.Instance = value; }
        }
        public int getuncheckoutbillidbytableid(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT id FROM dbo.Bill WHERE idTable='"+id+"' AND statuss = 0");
            if (data.Rows.Count > 0)
            {
                bill bil = new bill(data.Rows[0]);
                return bil.Id;
            }
            
            return -1;
        }

    }
}
