using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    public class tabledao
    {
        private static tabledao instance;

        public static tabledao Instance
        {
            get { if (instance == null) instance = new tabledao(); return tabledao.instance; }
            private set { tabledao.instance = value; }
        }

        public static int tablewidth = 100;
        public static int tableheight = 100;
        private tabledao() { }
        public List<table> LoadTableList()
        {
              List<table> tablelist = new List<table>();
              DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TableFood");
            foreach(DataRow item in data.Rows)
            {
                table table = new table(item);
                tablelist.Add(table);
            }
              return tablelist;
        }
    }
   
}
